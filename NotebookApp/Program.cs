namespace NotebookApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //new Form1() hangi k�s�mdan ba�lamas�n� istersek onun ismini yazaca��z mesela art�k Login Formundan ba�layacak.
            Application.Run(new Login());
            //Uygulamy� sonland�rabiliriz.
            //Application.Exit();

        }
    }
}