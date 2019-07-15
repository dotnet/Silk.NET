// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.Input.Desktop
{
    internal class InputHandler
    {
        public static List<GlfwInputContext> Contexts { get; }
        
        static InputHandler()
        {
            Contexts = new List<GlfwInputContext>();
        }

        public static void RegisterContext(GlfwInputContext ctx)
        {
            Contexts.Add(ctx);
            ctx._window.OnUpdate += ctx.WindowUpdate;
        }

        public static void UnregisterContext(GlfwInputContext ctx)
        {
            Contexts.Remove(ctx);
            ctx._window.OnUpdate -= ctx.WindowUpdate;
        }
    }
}
