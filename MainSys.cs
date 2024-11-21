namespace FitX
{
    internal static class MainSys
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignupPanel());
        }
    }
}