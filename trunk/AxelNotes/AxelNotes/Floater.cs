using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormsTimer = System.Windows.Forms.Timer;

namespace AxelNotes
{
    public partial class Floater : Form
    {
        private static List<Floater> instances = new List<Floater>();
        private static Brush brush = new SolidBrush(Properties.Settings.Default.FloaterColor);
        private const int REPOSITION_CHECK_INTERVAL = 2000;

        private bool isMoving;
        private Point prevMouse;
        private DateTime creationTime;
        private FormsTimer timer;
        private Point prevLocation;
        
        public static void SetBackgroundColor(Color color)
        {
            Floater.brush.Dispose();
            Floater.brush = new SolidBrush(color);
            foreach (Floater f in Floater.instances) f.Invalidate();
        }

        public Floater(String content)
        {
            InitializeComponent();
            this.TopLevel = true;
            this.TopMost = true;
            this.lblMessage.Text = content;
            if (this.Width < Properties.Settings.Default.FloaterMinSize.Width)
                this.Width = Properties.Settings.Default.FloaterMinSize.Width;
            if (this.Height < Properties.Settings.Default.FloaterMinSize.Height)
                this.Height = Properties.Settings.Default.FloaterMinSize.Height;
            creationTime = DateTime.Now;
            isMoving = false;
            timer = new FormsTimer();
            timer.Interval = Floater.REPOSITION_CHECK_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed) return;

            if (this.pbHandle.RectangleToScreen(new Rectangle(0, 0, this.pbHandle.Width, this.pbHandle.Height)).Contains(MousePosition) ||
                this.btnClose.RectangleToScreen(new Rectangle(0, 0, this.btnClose.Width, this.btnClose.Height)).Contains(MousePosition))
                return;

            // Weirdly, this.DesktopBounds.Top tells distance to bottom of screen, not to top
            if (!(new Rectangle(prevLocation, this.Size)).Contains(MousePosition.X, Screen.FromControl(this).Bounds.Height - MousePosition.Y))
            {
                timer.Stop();
                this.Location = prevLocation;
            }
        }
        
        private Point EnsureOnScreen(Point location)
        {
            Screen screen = Screen.FromControl(this);
            Point result = new Point(location.X, location.Y);
            if (result.X < 0) result.X = -result.X;
            if (result.Y < 0) result.Y = -result.Y;
            if (result.X + this.Width > screen.Bounds.Right) result.X = screen.Bounds.Right - this.Width;
            if (result.Y + this.Height > screen.WorkingArea.Bottom) result.Y = screen.WorkingArea.Bottom - this.Height;
            return result;
        }

        private Point ComputeInitialPosition()
        {
            Point result = EnsureOnScreen(Properties.Settings.Default.FloaterPosition);
            int tries = 0;
            while (instances.Exists(floater => floater.Location == result) && tries++ < instances.Count)
            {
                result.Offset(+25, -25);
                result = EnsureOnScreen(result);
            }
            return result;
        }

        private void Floater_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();
            Floater.instances.Remove(this);
            Properties.Settings.Default.FloaterPosition = this.Location;
            this.Dispose(true);
        }

        private void Floater_Shown(object sender, EventArgs e)
        {
            this.Location = ComputeInitialPosition();
            Floater.instances.Add(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbHandle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isMoving = true;
                this.prevMouse = this.pbHandle.PointToScreen(e.Location);
            }
            if (e.Button == MouseButtons.Right)
            {
                TimeSpan diff = new TimeSpan(DateTime.Now.Ticks - this.creationTime.Ticks);
                this.toolTip.Hide(this);
                if (diff.TotalSeconds < 120)
                    this.toolTip.Show("Floating for " + (int) diff.TotalSeconds + " seconds", this, new Point(0, 0), 5000);
                else
                    if (diff.Hours == 0)
                        this.toolTip.Show("Floating for " + diff.Minutes + " minutes", this, new Point(0, 0), 5000);
                    else
                        this.toolTip.Show("Floating for " + diff.Hours + "h" + diff.Minutes + "m", this, new Point(0, 0), 5000);
            }
        }

        private void pbHandle_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMoving = false;
        }

        private void pbHandle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                Point newMouse = this.pbHandle.PointToScreen(e.Location);
                this.Left += newMouse.X - this.prevMouse.X;
                this.Top += newMouse.Y - this.prevMouse.Y;
                this.prevMouse = newMouse;
                if (timer.Enabled) timer.Stop();
                this.prevLocation = this.Location;
            }
        }

        private void Floater_MouseMove(object sender, MouseEventArgs e)
        {
            // somehow if I click under move handle and drag over form area it start flipping out..
            if (e.Button != System.Windows.Forms.MouseButtons.None) return;

            if (!this.isMoving && (e.Location.X < this.btnClose.Left || e.Location.Y > this.btnClose.Bottom))
            {
                if (!timer.Enabled) prevLocation = this.Location;

                Rectangle screen = Screen.FromControl(this).Bounds;
                
                Point mouse = this.PointToScreen(e.Location);
                Point center = new Point(screen.Width / 2, screen.Height / 2);
                Point current = this.PointToScreen(new Point(this.Width / 2, this.Height / 2));
                
                int left = current.X + 2 * (center.X - current.X) - this.Width / 2;
                int top = current.Y + 2 * (center.Y - current.Y) - this.Height / 2;
                
                if (new Rectangle(left, top, this.Width, this.Height).Contains(mouse))
                {
                    left = (screen.Width - this.Width) / 2;
                    top = 0;
                }
                
                this.Left = left;
                this.Top = top;

                if (!timer.Enabled) timer.Start();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, 0, 0, this.Width, this.Height);
            e.Graphics.FillRoundedRectangle(Floater.brush, 0, 0, this.Width, this.Height, 10);
        }
    }
}
