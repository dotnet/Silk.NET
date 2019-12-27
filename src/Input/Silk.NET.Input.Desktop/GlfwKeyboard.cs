// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Silk.NET.Input.Desktop.Utilities;

namespace Silk.NET.Input.Desktop
{
    internal class GlfwKeyboard : IKeyboard, IGlfwDevice, IGlfwSubscriber
    {
        private static readonly Key[] _keys = ((Keys[]) Enum.GetValues(typeof(Keys))).Select(ConvertKey).ToArray();
        public string Name { get; } = "Silk.NET Keyboard (via GLFW)";
        public int Index { get; } = 0;
        public Action<bool> OnConnectionChange { get; set; }
        public bool IsConnected { get; } = true;
        public IReadOnlyList<Key> SupportedKeys { get; } = _keys;

        public bool IsKeyPressed(Key key)
        {
            throw new NotImplementedException();
        }

        public event Action<IKeyboard, Key, int> KeyDown;
        public event Action<IKeyboard, Key, int> KeyUp;
        public event Action<IKeyboard, char> KeyChar;
        public void Update()
        {
            throw new NotImplementedException();
        }

        public static Key ConvertKey(Keys keys) => keys switch
        {
            Keys.Unknown => Key.Unknown,
            Keys.Space => Key.Space,
            Keys.Apostrophe => Key.Apostrophe,
            Keys.Comma => Key.Comma,
            Keys.Minus => Key.Minus,
            Keys.Period => Key.Period,
            Keys.Slash => Key.Slash,
            Keys.D0 => Key.D0,
            Keys.Number1 => Key.Number1,
            Keys.Number2 => Key.Number2,
            Keys.Number3 => Key.Number3,
            Keys.Number4 => Key.Number4,
            Keys.Number5 => Key.Number5,
            Keys.Number6 => Key.Number6,
            Keys.Number7 => Key.Number7,
            Keys.Number8 => Key.Number8,
            Keys.Number9 => Key.Number9,
            Keys.Semicolon => Key.Semicolon,
            Keys.Equal => Key.Equal,
            Keys.A => Key.A,
            Keys.B => Key.B,
            Keys.C => Key.C,
            Keys.D => Key.D,
            Keys.E => Key.E,
            Keys.F => Key.F,
            Keys.G => Key.G,
            Keys.H => Key.H,
            Keys.I => Key.I,
            Keys.J => Key.J,
            Keys.K => Key.K,
            Keys.L => Key.L,
            Keys.M => Key.M,
            Keys.N => Key.N,
            Keys.O => Key.O,
            Keys.P => Key.P,
            Keys.Q => Key.Q,
            Keys.R => Key.R,
            Keys.S => Key.S,
            Keys.T => Key.T,
            Keys.U => Key.U,
            Keys.V => Key.V,
            Keys.W => Key.W,
            Keys.X => Key.X,
            Keys.Y => Key.Y,
            Keys.Z => Key.Z,
            Keys.LeftBracket => Key.LeftBracket,
            Keys.BackSlash => Key.BackSlash,
            Keys.RightBracket => Key.RightBracket,
            Keys.GraveAccent => Key.GraveAccent,
            Keys.World1 => Key.World1,
            Keys.World2 => Key.World2,
            Keys.Escape => Key.Escape,
            Keys.Enter => Key.Enter,
            Keys.Tab => Key.Tab,
            Keys.Backspace => Key.Backspace,
            Keys.Insert => Key.Insert,
            Keys.Delete => Key.Delete,
            Keys.Right => Key.Right,
            Keys.Left => Key.Left,
            Keys.Down => Key.Down,
            Keys.Up => Key.Up,
            Keys.PageUp => Key.PageUp,
            Keys.PageDown => Key.PageDown,
            Keys.Home => Key.Home,
            Keys.End => Key.End,
            Keys.CapsLock => Key.CapsLock,
            Keys.ScrollLock => Key.ScrollLock,
            Keys.NumLock => Key.NumLock,
            Keys.PrintScreen => Key.PrintScreen,
            Keys.Pause => Key.Pause,
            Keys.F1 => Key.F1,
            Keys.F2 => Key.F2,
            Keys.F3 => Key.F3,
            Keys.F4 => Key.F4,
            Keys.F5 => Key.F5,
            Keys.F6 => Key.F6,
            Keys.F7 => Key.F7,
            Keys.F8 => Key.F8,
            Keys.F9 => Key.F9,
            Keys.F10 => Key.F10,
            Keys.F11 => Key.F11,
            Keys.F12 => Key.F12,
            Keys.F13 => Key.F13,
            Keys.F14 => Key.F14,
            Keys.F15 => Key.F15,
            Keys.F16 => Key.F16,
            Keys.F17 => Key.F17,
            Keys.F18 => Key.F18,
            Keys.F19 => Key.F19,
            Keys.F20 => Key.F20,
            Keys.F21 => Key.F21,
            Keys.F22 => Key.F22,
            Keys.F23 => Key.F23,
            Keys.F24 => Key.F24,
            Keys.F25 => Key.F25,
            Keys.Keypad0 => Key.Keypad0,
            Keys.Keypad1 => Key.Keypad1,
            Keys.Keypad2 => Key.Keypad2,
            Keys.Keypad3 => Key.Keypad3,
            Keys.Keypad4 => Key.Keypad4,
            Keys.Keypad5 => Key.Keypad5,
            Keys.Keypad6 => Key.Keypad6,
            Keys.Keypad7 => Key.Keypad7,
            Keys.Keypad8 => Key.Keypad8,
            Keys.Keypad9 => Key.Keypad9,
            Keys.KeypadDecimal => Key.KeypadDecimal,
            Keys.KeypadDivide => Key.KeypadDivide,
            Keys.KeypadMultiply => Key.KeypadMultiply,
            Keys.KeypadSubtract => Key.KeypadSubtract,
            Keys.KeypadAdd => Key.KeypadAdd,
            Keys.KeypadEnter => Key.KeypadEnter,
            Keys.KeypadEqual => Key.KeypadEqual,
            Keys.ShiftLeft => Key.ShiftLeft,
            Keys.ControlLeft => Key.ControlLeft,
            Keys.AltLeft => Key.AltLeft,
            Keys.SuperLeft => Key.SuperLeft,
            Keys.ShiftRight => Key.ShiftRight,
            Keys.ControlRight => Key.ControlRight,
            Keys.AltRight => Key.AltRight,
            Keys.SuperRight => Key.SuperRight,
            Keys.Menu => Key.Menu,
            _ => throw new ArgumentOutOfRangeException()
        };

        public void Subscribe(GlfwEvents events)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(GlfwEvents events)
        {
            throw new NotImplementedException();
        }
    }
}
