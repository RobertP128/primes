using System;
using Gtk;

namespace CheckPrime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mono.Unix.Catalog.Init("CheckPrime", "./locale");

            Application.Init();

            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
