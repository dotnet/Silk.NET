// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Triangle
{
    public class Game
    {
        private IWindow window;
        private GL gl = GL.GetApi();

        public Game()
        {
            var options = WindowOptions.Default;
            window = Window.Create(options);

            window.OnLoad += OnLoad;
            window.OnRender += OnRender;
        }

        public void OnLoad()
        {
            gl.ClearColor(1.0f, 0.4f, 0.3f, 1.0f);
        }
        
        public void Run()
        {
            window.Run();
        }

        public void OnRender(double delta)
        {
            gl.Clear(0x4000);
        }
    }
}