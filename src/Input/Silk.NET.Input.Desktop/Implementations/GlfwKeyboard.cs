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
    /// <summary>
    /// A GLFW-based keyboard.
    /// </summary>
    internal class GlfwKeyboard : IKeyboard
    {
        private readonly GlfwInputContext _gic;

        internal GlfwKeyboard(GlfwInputContext gic)
        {
            _gic = gic;
        }
        
        /// <inheritdoc />
        public string Name { get; } = "Silk.NET Keyboard (GLFW)";
        
        /// <inheritdoc />
        public int Index { get; } = 0;
        
        /// <inheritdoc />
        public bool IsConnected { get; } = true;
        
        /// <inheritdoc />
        public IReadOnlyList<Key> SupportedKeys { get; } = Util.SupportedKeys;
        
        /// <inheritdoc />
        public unsafe bool IsKeyPressed(Key key)
        {
            return Util.Glfw.GetKey((WindowHandle*)_gic._window.Handle, Util.SilkKeyToGlfwKey(key)) == 1;
        }

        /// <inheritdoc />
        public event Action<IKeyboard, Key, int> KeyDown;
        
        /// <inheritdoc />
        public event Action<IKeyboard, Key, int> KeyUp;
        
        /// <inheritdoc />
        public event Action<IKeyboard, char> KeyChar;

        internal void RaisePressEvent(Keys key, int scancode, KeyModifiers mods)
        {
            KeyDown?.Invoke(this, Util.GlfwKeyToSilkKey(key), scancode);
        }

        internal void RaiseReleaseEvent(Keys key, int scancode, KeyModifiers mods)
        {
            KeyUp?.Invoke(this, Util.GlfwKeyToSilkKey(key), scancode);
        }

        internal void RaiseCharEvent(char c)
        {
            KeyChar?.Invoke(this, c);
        }
    }
}
