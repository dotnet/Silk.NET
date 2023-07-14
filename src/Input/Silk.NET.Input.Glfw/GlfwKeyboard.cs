// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.GLFW;

namespace Silk.NET.Input.Glfw
{
    internal class GlfwKeyboard : IKeyboard, IGlfwSubscriber
    {
        private static readonly Key[] _keys = ((Keys[]) Enum.GetValues(typeof(Keys))).Select
                (ConvertKey)
            .Where(static x => x != Key.Unknown)
            .Distinct()
            .ToArray();
        private unsafe WindowHandle* _handle;
        private GlfwCallbacks.CharCallback? _char;
        private GlfwCallbacks.KeyCallback? _key;
        private List<int> _scancodesDown = new List<int>();

        public string Name { get; } = "Silk.NET Keyboard (via GLFW)";
        public int Index { get; } = 0;
        public bool IsConnected { get; } = true;
        public IReadOnlyList<Key> SupportedKeys { get; } = _keys;
        public unsafe string ClipboardText
        {
            get => GlfwProvider.GLFW.Value.GetClipboardString(_handle);
            set => GlfwProvider.GLFW.Value.SetClipboardString(_handle, value);
        }

        public unsafe bool IsKeyPressed
            (Key key) => GlfwProvider.GLFW.Value.GetKey(_handle, ConvertKey(key)) == (int) InputAction.Press;

        public unsafe bool IsScancodePressed(int scancode) => _scancodesDown.Contains(scancode);

        public event Action<IKeyboard, Key, int>? KeyDown;
        public event Action<IKeyboard, Key, int>? KeyUp;
        public event Action<IKeyboard, char>? KeyChar;
        public void BeginInput()
        {
            // do nothing
        }

        public void EndInput()
        {
            // do nothing
        }

        public unsafe void Subscribe(GlfwEvents events)
        {
            _handle = events.Handle;
            events.Char += _char = (_, c) => KeyChar?.Invoke(this, (char) c);
            events.Key += _key = (_, key, code, action, mods) =>
            {
                Action<IKeyboard, Key, int>? evt = null;
                switch(action)
                {
                    case InputAction.Press:
                        evt = KeyDown;
                        _scancodesDown.Add(code);
                        break;
                    case InputAction.Release:
                        evt = KeyUp;
                        _scancodesDown.Remove(code);
                        break;
                }

                evt?.Invoke(this, ConvertKey(key), code);
            };
        }

        public void Unsubscribe(GlfwEvents events)
        {
            events.Char -= _char;
            events.Key -= _key;
        }

        private static Key ConvertKey(Keys keys) => keys switch
        {
            Keys.Unknown => Key.Unknown,
            Keys.Space => Key.Space,
            Keys.Apostrophe => Key.Apostrophe,
            Keys.Comma => Key.Comma,
            Keys.Minus => Key.Minus,
            Keys.Period => Key.Period,
            Keys.Slash => Key.Slash,
            Keys.Number0 => Key.Number0,
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
            _ => Key.Unknown
        };

        private static Keys ConvertKey(Key keys) => keys switch
        {
            Key.Unknown => Keys.Unknown,
            Key.Space => Keys.Space,
            Key.Apostrophe => Keys.Apostrophe,
            Key.Comma => Keys.Comma,
            Key.Minus => Keys.Minus,
            Key.Period => Keys.Period,
            Key.Slash => Keys.Slash,
            Key.Number0 => Keys.Number0,
            Key.Number1 => Keys.Number1,
            Key.Number2 => Keys.Number2,
            Key.Number3 => Keys.Number3,
            Key.Number4 => Keys.Number4,
            Key.Number5 => Keys.Number5,
            Key.Number6 => Keys.Number6,
            Key.Number7 => Keys.Number7,
            Key.Number8 => Keys.Number8,
            Key.Number9 => Keys.Number9,
            Key.Semicolon => Keys.Semicolon,
            Key.Equal => Keys.Equal,
            Key.A => Keys.A,
            Key.B => Keys.B,
            Key.C => Keys.C,
            Key.D => Keys.D,
            Key.E => Keys.E,
            Key.F => Keys.F,
            Key.G => Keys.G,
            Key.H => Keys.H,
            Key.I => Keys.I,
            Key.J => Keys.J,
            Key.K => Keys.K,
            Key.L => Keys.L,
            Key.M => Keys.M,
            Key.N => Keys.N,
            Key.O => Keys.O,
            Key.P => Keys.P,
            Key.Q => Keys.Q,
            Key.R => Keys.R,
            Key.S => Keys.S,
            Key.T => Keys.T,
            Key.U => Keys.U,
            Key.V => Keys.V,
            Key.W => Keys.W,
            Key.X => Keys.X,
            Key.Y => Keys.Y,
            Key.Z => Keys.Z,
            Key.LeftBracket => Keys.LeftBracket,
            Key.BackSlash => Keys.BackSlash,
            Key.RightBracket => Keys.RightBracket,
            Key.GraveAccent => Keys.GraveAccent,
            Key.World1 => Keys.World1,
            Key.World2 => Keys.World2,
            Key.Escape => Keys.Escape,
            Key.Enter => Keys.Enter,
            Key.Tab => Keys.Tab,
            Key.Backspace => Keys.Backspace,
            Key.Insert => Keys.Insert,
            Key.Delete => Keys.Delete,
            Key.Right => Keys.Right,
            Key.Left => Keys.Left,
            Key.Down => Keys.Down,
            Key.Up => Keys.Up,
            Key.PageUp => Keys.PageUp,
            Key.PageDown => Keys.PageDown,
            Key.Home => Keys.Home,
            Key.End => Keys.End,
            Key.CapsLock => Keys.CapsLock,
            Key.ScrollLock => Keys.ScrollLock,
            Key.NumLock => Keys.NumLock,
            Key.PrintScreen => Keys.PrintScreen,
            Key.Pause => Keys.Pause,
            Key.F1 => Keys.F1,
            Key.F2 => Keys.F2,
            Key.F3 => Keys.F3,
            Key.F4 => Keys.F4,
            Key.F5 => Keys.F5,
            Key.F6 => Keys.F6,
            Key.F7 => Keys.F7,
            Key.F8 => Keys.F8,
            Key.F9 => Keys.F9,
            Key.F10 => Keys.F10,
            Key.F11 => Keys.F11,
            Key.F12 => Keys.F12,
            Key.F13 => Keys.F13,
            Key.F14 => Keys.F14,
            Key.F15 => Keys.F15,
            Key.F16 => Keys.F16,
            Key.F17 => Keys.F17,
            Key.F18 => Keys.F18,
            Key.F19 => Keys.F19,
            Key.F20 => Keys.F20,
            Key.F21 => Keys.F21,
            Key.F22 => Keys.F22,
            Key.F23 => Keys.F23,
            Key.F24 => Keys.F24,
            Key.F25 => Keys.F25,
            Key.Keypad0 => Keys.Keypad0,
            Key.Keypad1 => Keys.Keypad1,
            Key.Keypad2 => Keys.Keypad2,
            Key.Keypad3 => Keys.Keypad3,
            Key.Keypad4 => Keys.Keypad4,
            Key.Keypad5 => Keys.Keypad5,
            Key.Keypad6 => Keys.Keypad6,
            Key.Keypad7 => Keys.Keypad7,
            Key.Keypad8 => Keys.Keypad8,
            Key.Keypad9 => Keys.Keypad9,
            Key.KeypadDecimal => Keys.KeypadDecimal,
            Key.KeypadDivide => Keys.KeypadDivide,
            Key.KeypadMultiply => Keys.KeypadMultiply,
            Key.KeypadSubtract => Keys.KeypadSubtract,
            Key.KeypadAdd => Keys.KeypadAdd,
            Key.KeypadEnter => Keys.KeypadEnter,
            Key.KeypadEqual => Keys.KeypadEqual,
            Key.ShiftLeft => Keys.ShiftLeft,
            Key.ControlLeft => Keys.ControlLeft,
            Key.AltLeft => Keys.AltLeft,
            Key.SuperLeft => Keys.SuperLeft,
            Key.ShiftRight => Keys.ShiftRight,
            Key.ControlRight => Keys.ControlRight,
            Key.AltRight => Keys.AltRight,
            Key.SuperRight => Keys.SuperRight,
            Key.Menu => Keys.Menu,
            _ => Keys.Unknown
        };
    }
}
