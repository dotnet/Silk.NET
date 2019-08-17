// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    public class GlfwKeyboard : IKeyboard
    {
        private GlfwInputContext _gic;

        public GlfwKeyboard(GlfwInputContext gic)
        {
            _gic = gic;
        }
        public string Name { get; } = $"Silk.NET Keyboard (GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<Key> SupportedKeys { get; } = Util.SupportedKeys;
        public unsafe bool IsKeyPressed(Key key)
        {
            return Util.Do(() => Util.Glfw.GetKey((WindowHandle*)_gic._window.Handle, Util.SilkKeyToGlfwKey(key))) == 1;
        }

        public unsafe bool IsKeyPressed(uint scancode)
        {
            return Util.Do(() => Util.Glfw.GetKey((WindowHandle*)_gic._window.Handle, (Keys)scancode)) == 1;
        }

        public event Action<IKeyboard, Key> KeyDown;
        public event Action<IKeyboard, Key> KeyUp;

        internal void RaisePressEvent(Keys key, int scancode, KeyModifiers mods)
        {
            KeyDown?.Invoke(this, Util.GlfwKeyToSilkKey(key));
        }

        internal void RaiseReleaseEvent(Keys key, int scancode, KeyModifiers mods)
        {
            KeyUp?.Invoke(this, Util.GlfwKeyToSilkKey(key));
        }
    }
}
