using System;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Silk.NET.Input;
using Silk.NET.Windowing;

namespace MonitorPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            //var window = Window.Create(WindowOptions.Default);
            //IInputContext input = null;
            //window.Load += () =>
            //{
            //    input = window.CreateInput();
            //    foreach (var monitor in Monitor.GetMonitors())
            //    {
            //        Console.WriteLine(monitor.Index + " " + monitor.Bounds);
            //    }
            //};
            //window.Move += newPos => { Console.WriteLine(newPos); };
            //window.Update += delta =>
            //{
            //    //Console.WriteLine(window.Monitor.Index + " " + window.Monitor.Bounds);
            //    if (input.Keyboards[0].IsKeyPressed(Key.Enter))
            //    {
            //        input.Mice[0].Position = new PointF
            //            (window.Size.Width / 2f, window.Size.Height / 2f);
            //    }
            //    
            //    if (input.Keyboards[0].IsKeyPressed(Key.Escape))
            //    {
            //        window.Close();
            //    }
            //};
            //
            //window.Run();
            var opts = WindowOptions.Default;
            //opts.WindowState = WindowState.Fullscreen;
            var window = Monitor.GetMainMonitor(null).CreateWindow(opts);
            IInputContext input = null;
            var currentMonitor = 0;
            window.Load += () =>
            {
                input = window.CreateInput();
                foreach (var monitor in Monitor.GetMonitors(null))
                {
                    Console.WriteLine(monitor.Index + " " + monitor.Bounds);
                }
            };
            window.Update += delta =>
            {
                //Console.WriteLine(window.Monitor.Index + " " + window.Monitor.Bounds);
                if (input.Keyboards[0].IsKeyPressed(Key.Enter))
                {
                    try
                    {
                        window.Monitor = Monitor.GetMonitors(window).ElementAt(currentMonitor++);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        window.Monitor = Monitor.GetMonitors(window).ElementAt(currentMonitor = 0);
                    }
                }

                if (input.Keyboards[0].IsKeyPressed(Key.Space))
                {
                    window.Center();
                }

                if (input.Keyboards[0].IsKeyPressed(Key.Escape))
                {
                    window.Close();
                }

                input.Mice[0].Position = new Vector2(window.Size.X / 2f, window.Size.Y / 2f);
            };

            window.Run();
        }
    }
}
