namespace Calculator_de_note
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
<<<<<<< HEAD


            Application.Run(new chooseForm());
            //Application.Run(new StartForm());
            //Application.Run(new ProfilRealForm());
            //Application.Run(new ProfilUmanForm());
=======
            Application.Run(new StartForm());
>>>>>>> 1dda2d033d2d390a3fa53d17250aa26428d7bac7


        }
    }
}
