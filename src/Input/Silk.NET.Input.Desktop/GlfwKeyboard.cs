// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;

namespace Silk.NET.Input.Desktop
{
    internal class GlfwKeyboard : IKeyboard, IGlfwDevice, IGlfwSubscriber
    {
        private static readonly Key[] Keys = ((Keys[]) Enum.GetValues(typeof(Keys))).Select(ConvertKey).ToArray();
        private unsafe WindowHandle* _handle;
        private GlfwCallbacks.CharCallback _char;
        private GlfwCallbacks.KeyCallback _key;
        public string Name { get; } = "Silk.NET Keyboard (via GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<Key> SupportedKeys { get; } = Keys;

        public unsafe bool IsKeyPressed
            (Key key) => GlfwProvider.GLFW.Value.GetKey(_handle, ConvertKey(key)) == (int) InputAction.Press;

        public event Action<IKeyboard, Key, int> KeyDown;
        public event Action<IKeyboard, Key, int> KeyUp;
        public event Action<IKeyboard, char> KeyChar;


        public unsafe void Subscribe(GlfwEvents events)
        {
            _handle = events.Handle;
            events.Char += _char = (_, c) => KeyChar?.Invoke(this, (char) c);
            events.Key += _key = (_, key, code, action, mods) =>
                (action switch
                {
                    InputAction.Press => KeyDown,
                    InputAction.Release => KeyUp,
                    InputAction.Repeat => null,
                    _ => null
                })?.Invoke(this, ConvertKey(key), code);
        }

        public void Unsubscribe(GlfwEvents events)
        {
            events.Char -= _char;
            events.Key -= _key;
        }

        private static Key ConvertKey(Keys keys) => keys switch
        {
            GLFW.Keys.Unknown => Key.Unknown,
            GLFW.Keys.Space => Key.Space,
            GLFW.Keys.Apostrophe => Key.Apostrophe,
            GLFW.Keys.Comma => Key.Comma,
            GLFW.Keys.Minus => Key.Minus,
            GLFW.Keys.Period => Key.Period,
            GLFW.Keys.Slash => Key.Slash,
            GLFW.Keys.Number0 => Key.Number0,
            GLFW.Keys.Number1 => Key.Number1,
            GLFW.Keys.Number2 => Key.Number2,
            GLFW.Keys.Number3 => Key.Number3,
            GLFW.Keys.Number4 => Key.Number4,
            GLFW.Keys.Number5 => Key.Number5,
            GLFW.Keys.Number6 => Key.Number6,
            GLFW.Keys.Number7 => Key.Number7,
            GLFW.Keys.Number8 => Key.Number8,
            GLFW.Keys.Number9 => Key.Number9,
            GLFW.Keys.Semicolon => Key.Semicolon,
            GLFW.Keys.Equal => Key.Equal,
            GLFW.Keys.A => Key.A,
            GLFW.Keys.B => Key.B,
            GLFW.Keys.C => Key.C,
            GLFW.Keys.D => Key.D,
            GLFW.Keys.E => Key.E,
            GLFW.Keys.F => Key.F,
            GLFW.Keys.G => Key.G,
            GLFW.Keys.H => Key.H,
            GLFW.Keys.I => Key.I,
            GLFW.Keys.J => Key.J,
            GLFW.Keys.K => Key.K,
            GLFW.Keys.L => Key.L,
            GLFW.Keys.M => Key.M,
            GLFW.Keys.N => Key.N,
            GLFW.Keys.O => Key.O,
            GLFW.Keys.P => Key.P,
            GLFW.Keys.Q => Key.Q,
            GLFW.Keys.R => Key.R,
            GLFW.Keys.S => Key.S,
            GLFW.Keys.T => Key.T,
            GLFW.Keys.U => Key.U,
            GLFW.Keys.V => Key.V,
            GLFW.Keys.W => Key.W,
            GLFW.Keys.X => Key.X,
            GLFW.Keys.Y => Key.Y,
            GLFW.Keys.Z => Key.Z,
            GLFW.Keys.LeftBracket => Key.LeftBracket,
            GLFW.Keys.BackSlash => Key.BackSlash,
            GLFW.Keys.RightBracket => Key.RightBracket,
            GLFW.Keys.GraveAccent => Key.GraveAccent,
            GLFW.Keys.World1 => Key.World1,
            GLFW.Keys.World2 => Key.World2,
            GLFW.Keys.Escape => Key.Escape,
            GLFW.Keys.Enter => Key.Enter,
            GLFW.Keys.Tab => Key.Tab,
            GLFW.Keys.Backspace => Key.Backspace,
            GLFW.Keys.Insert => Key.Insert,
            GLFW.Keys.Delete => Key.Delete,
            GLFW.Keys.Right => Key.Right,
            GLFW.Keys.Left => Key.Left,
            GLFW.Keys.Down => Key.Down,
            GLFW.Keys.Up => Key.Up,
            GLFW.Keys.PageUp => Key.PageUp,
            GLFW.Keys.PageDown => Key.PageDown,
            GLFW.Keys.Home => Key.Home,
            GLFW.Keys.End => Key.End,
            GLFW.Keys.CapsLock => Key.CapsLock,
            GLFW.Keys.ScrollLock => Key.ScrollLock,
            GLFW.Keys.NumLock => Key.NumLock,
            GLFW.Keys.PrintScreen => Key.PrintScreen,
            GLFW.Keys.Pause => Key.Pause,
            GLFW.Keys.F1 => Key.F1,
            GLFW.Keys.F2 => Key.F2,
            GLFW.Keys.F3 => Key.F3,
            GLFW.Keys.F4 => Key.F4,
            GLFW.Keys.F5 => Key.F5,
            GLFW.Keys.F6 => Key.F6,
            GLFW.Keys.F7 => Key.F7,
            GLFW.Keys.F8 => Key.F8,
            GLFW.Keys.F9 => Key.F9,
            GLFW.Keys.F10 => Key.F10,
            GLFW.Keys.F11 => Key.F11,
            GLFW.Keys.F12 => Key.F12,
            GLFW.Keys.F13 => Key.F13,
            GLFW.Keys.F14 => Key.F14,
            GLFW.Keys.F15 => Key.F15,
            GLFW.Keys.F16 => Key.F16,
            GLFW.Keys.F17 => Key.F17,
            GLFW.Keys.F18 => Key.F18,
            GLFW.Keys.F19 => Key.F19,
            GLFW.Keys.F20 => Key.F20,
            GLFW.Keys.F21 => Key.F21,
            GLFW.Keys.F22 => Key.F22,
            GLFW.Keys.F23 => Key.F23,
            GLFW.Keys.F24 => Key.F24,
            GLFW.Keys.F25 => Key.F25,
            GLFW.Keys.Keypad0 => Key.Keypad0,
            GLFW.Keys.Keypad1 => Key.Keypad1,
            GLFW.Keys.Keypad2 => Key.Keypad2,
            GLFW.Keys.Keypad3 => Key.Keypad3,
            GLFW.Keys.Keypad4 => Key.Keypad4,
            GLFW.Keys.Keypad5 => Key.Keypad5,
            GLFW.Keys.Keypad6 => Key.Keypad6,
            GLFW.Keys.Keypad7 => Key.Keypad7,
            GLFW.Keys.Keypad8 => Key.Keypad8,
            GLFW.Keys.Keypad9 => Key.Keypad9,
            GLFW.Keys.KeypadDecimal => Key.KeypadDecimal,
            GLFW.Keys.KeypadDivide => Key.KeypadDivide,
            GLFW.Keys.KeypadMultiply => Key.KeypadMultiply,
            GLFW.Keys.KeypadSubtract => Key.KeypadSubtract,
            GLFW.Keys.KeypadAdd => Key.KeypadAdd,
            GLFW.Keys.KeypadEnter => Key.KeypadEnter,
            GLFW.Keys.KeypadEqual => Key.KeypadEqual,
            GLFW.Keys.ShiftLeft => Key.ShiftLeft,
            GLFW.Keys.ControlLeft => Key.ControlLeft,
            GLFW.Keys.AltLeft => Key.AltLeft,
            GLFW.Keys.SuperLeft => Key.SuperLeft,
            GLFW.Keys.ShiftRight => Key.ShiftRight,
            GLFW.Keys.ControlRight => Key.ControlRight,
            GLFW.Keys.AltRight => Key.AltRight,
            GLFW.Keys.SuperRight => Key.SuperRight,
            GLFW.Keys.Menu => Key.Menu,
            _ => throw new ArgumentOutOfRangeException()
        };

        private static Keys ConvertKey(Key keys) => keys switch
        {
            Key.Unknown => GLFW.Keys.Unknown,
            Key.Space => GLFW.Keys.Space,
            Key.Apostrophe => GLFW.Keys.Apostrophe,
            Key.Comma => GLFW.Keys.Comma,
            Key.Minus => GLFW.Keys.Minus,
            Key.Period => GLFW.Keys.Period,
            Key.Slash => GLFW.Keys.Slash,
            Key.Number0 => GLFW.Keys.Number0,
            Key.Number1 => GLFW.Keys.Number1,
            Key.Number2 => GLFW.Keys.Number2,
            Key.Number3 => GLFW.Keys.Number3,
            Key.Number4 => GLFW.Keys.Number4,
            Key.Number5 => GLFW.Keys.Number5,
            Key.Number6 => GLFW.Keys.Number6,
            Key.Number7 => GLFW.Keys.Number7,
            Key.Number8 => GLFW.Keys.Number8,
            Key.Number9 => GLFW.Keys.Number9,
            Key.Semicolon => GLFW.Keys.Semicolon,
            Key.Equal => GLFW.Keys.Equal,
            Key.A => GLFW.Keys.A,
            Key.B => GLFW.Keys.B,
            Key.C => GLFW.Keys.C,
            Key.D => GLFW.Keys.D,
            Key.E => GLFW.Keys.E,
            Key.F => GLFW.Keys.F,
            Key.G => GLFW.Keys.G,
            Key.H => GLFW.Keys.H,
            Key.I => GLFW.Keys.I,
            Key.J => GLFW.Keys.J,
            Key.K => GLFW.Keys.K,
            Key.L => GLFW.Keys.L,
            Key.M => GLFW.Keys.M,
            Key.N => GLFW.Keys.N,
            Key.O => GLFW.Keys.O,
            Key.P => GLFW.Keys.P,
            Key.Q => GLFW.Keys.Q,
            Key.R => GLFW.Keys.R,
            Key.S => GLFW.Keys.S,
            Key.T => GLFW.Keys.T,
            Key.U => GLFW.Keys.U,
            Key.V => GLFW.Keys.V,
            Key.W => GLFW.Keys.W,
            Key.X => GLFW.Keys.X,
            Key.Y => GLFW.Keys.Y,
            Key.Z => GLFW.Keys.Z,
            Key.LeftBracket => GLFW.Keys.LeftBracket,
            Key.BackSlash => GLFW.Keys.BackSlash,
            Key.RightBracket => GLFW.Keys.RightBracket,
            Key.GraveAccent => GLFW.Keys.GraveAccent,
            Key.World1 => GLFW.Keys.World1,
            Key.World2 => GLFW.Keys.World2,
            Key.Escape => GLFW.Keys.Escape,
            Key.Enter => GLFW.Keys.Enter,
            Key.Tab => GLFW.Keys.Tab,
            Key.Backspace => GLFW.Keys.Backspace,
            Key.Insert => GLFW.Keys.Insert,
            Key.Delete => GLFW.Keys.Delete,
            Key.Right => GLFW.Keys.Right,
            Key.Left => GLFW.Keys.Left,
            Key.Down => GLFW.Keys.Down,
            Key.Up => GLFW.Keys.Up,
            Key.PageUp => GLFW.Keys.PageUp,
            Key.PageDown => GLFW.Keys.PageDown,
            Key.Home => GLFW.Keys.Home,
            Key.End => GLFW.Keys.End,
            Key.CapsLock => GLFW.Keys.CapsLock,
            Key.ScrollLock => GLFW.Keys.ScrollLock,
            Key.NumLock => GLFW.Keys.NumLock,
            Key.PrintScreen => GLFW.Keys.PrintScreen,
            Key.Pause => GLFW.Keys.Pause,
            Key.F1 => GLFW.Keys.F1,
            Key.F2 => GLFW.Keys.F2,
            Key.F3 => GLFW.Keys.F3,
            Key.F4 => GLFW.Keys.F4,
            Key.F5 => GLFW.Keys.F5,
            Key.F6 => GLFW.Keys.F6,
            Key.F7 => GLFW.Keys.F7,
            Key.F8 => GLFW.Keys.F8,
            Key.F9 => GLFW.Keys.F9,
            Key.F10 => GLFW.Keys.F10,
            Key.F11 => GLFW.Keys.F11,
            Key.F12 => GLFW.Keys.F12,
            Key.F13 => GLFW.Keys.F13,
            Key.F14 => GLFW.Keys.F14,
            Key.F15 => GLFW.Keys.F15,
            Key.F16 => GLFW.Keys.F16,
            Key.F17 => GLFW.Keys.F17,
            Key.F18 => GLFW.Keys.F18,
            Key.F19 => GLFW.Keys.F19,
            Key.F20 => GLFW.Keys.F20,
            Key.F21 => GLFW.Keys.F21,
            Key.F22 => GLFW.Keys.F22,
            Key.F23 => GLFW.Keys.F23,
            Key.F24 => GLFW.Keys.F24,
            Key.F25 => GLFW.Keys.F25,
            Key.Keypad0 => GLFW.Keys.Keypad0,
            Key.Keypad1 => GLFW.Keys.Keypad1,
            Key.Keypad2 => GLFW.Keys.Keypad2,
            Key.Keypad3 => GLFW.Keys.Keypad3,
            Key.Keypad4 => GLFW.Keys.Keypad4,
            Key.Keypad5 => GLFW.Keys.Keypad5,
            Key.Keypad6 => GLFW.Keys.Keypad6,
            Key.Keypad7 => GLFW.Keys.Keypad7,
            Key.Keypad8 => GLFW.Keys.Keypad8,
            Key.Keypad9 => GLFW.Keys.Keypad9,
            Key.KeypadDecimal => GLFW.Keys.KeypadDecimal,
            Key.KeypadDivide => GLFW.Keys.KeypadDivide,
            Key.KeypadMultiply => GLFW.Keys.KeypadMultiply,
            Key.KeypadSubtract => GLFW.Keys.KeypadSubtract,
            Key.KeypadAdd => GLFW.Keys.KeypadAdd,
            Key.KeypadEnter => GLFW.Keys.KeypadEnter,
            Key.KeypadEqual => GLFW.Keys.KeypadEqual,
            Key.ShiftLeft => GLFW.Keys.ShiftLeft,
            Key.ControlLeft => GLFW.Keys.ControlLeft,
            Key.AltLeft => GLFW.Keys.AltLeft,
            Key.SuperLeft => GLFW.Keys.SuperLeft,
            Key.ShiftRight => GLFW.Keys.ShiftRight,
            Key.ControlRight => GLFW.Keys.ControlRight,
            Key.AltRight => GLFW.Keys.AltRight,
            Key.SuperRight => GLFW.Keys.SuperRight,
            Key.Menu => GLFW.Keys.Menu,
            _ => throw new ArgumentOutOfRangeException()
        };

    }
}
