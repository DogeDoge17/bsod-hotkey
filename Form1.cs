namespace bluescreen_trigger
{
    public partial class Form1 : Form
    {
        KeyboardHook hook = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255,0, 120, 215);
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(Keys.M);
            hook.RegisterHotKey(Keys.N);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.Key == Keys.M)
            {
                this.WindowState = FormWindowState.Maximized;
                Cursor.Hide();
                this.TopMost= true;
                Cursor.Position = (Point)Screen.PrimaryScreen.Bounds.Size;
            }
            else if (e.Key == Keys.N)
            {
                this.WindowState = FormWindowState.Minimized;
                Cursor.Show();
                this.TopMost = false;
            }
        }
    }
}