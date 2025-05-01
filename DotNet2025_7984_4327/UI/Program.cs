namespace UI
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
/*            DalTest.Intialization.initialize();
*/            ApplicationConfiguration.Initialize();
            Application.Run(new PandoraHome());
        }
    }
}