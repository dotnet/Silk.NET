// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using Ultz.Dispatcher.Unsafe;
using MouseButton = Silk.NET.Input.Common.MouseButton;

namespace Silk.NET.Input.Desktop
{
    internal static class Util
    {
        private static string[] _glfwKeys = Enum.GetNames(typeof(Keys));
        private static string[] _glfwButtons = Enum.GetNames(typeof(GLFW.MouseButton));

        public static Glfw Glfw => GlfwProvider.GLFW.Value;
        public static Key[] SupportedKeys { get; } // this is expensive, but only runs once.
            = Enum.GetNames(typeof(Key)).Where(_glfwKeys.Contains).Select(StringToSilkKey).ToArray();
        public static MouseButton[] SupportedButtons { get; } // this is expensive, but only runs once.
            = Enum.GetNames(typeof(MouseButton)).Where(_glfwButtons.Contains).Select(StringToSilkButton).ToArray();

        public static Key StringToSilkKey(string s)
        {
            if (Enum.TryParse<Key>(s, out var k))
            {
                return k;
            }
            throw new ArgumentOutOfRangeException(nameof(s), $"Key name mismatch (couldn't find a Key value for {s})");
        }
        
        public static ButtonName IntToSilkButton(int i)
        {
            var s = ((GamepadButton) i).ToString();
            if (Enum.TryParse<ButtonName>(s, out var k))
            {
                return k;
            }
            if (Enum.IsDefined(typeof(ButtonName), i))
            {
                return (ButtonName)i;
            }
            throw new ArgumentOutOfRangeException(nameof(s), $"Button name mismatch (couldn't find a ButtonName value for {s})");
        }

        public static Keys SilkKeyToGlfwKey(Key k)
        {
            if (Enum.TryParse<Keys>(k.ToString(), out var gk))
            {
                return gk;
            }
            if (Enum.IsDefined(typeof(Keys), k))
            {
                return (Keys)k;
            }
            throw new ArgumentOutOfRangeException(nameof(k));
        }

        public static Key GlfwKeyToSilkKey(Keys k)
        {
            if (Enum.TryParse<Key>(k.ToString(), out var sk))
            {
                return sk;
            }
            if (Enum.IsDefined(typeof(Key), k))
            {
                return (Key)k;
            }
            throw new ArgumentOutOfRangeException(nameof(k));
        }

        public static MouseButton StringToSilkButton(string s)
        {
            if (Enum.TryParse<MouseButton>(s, out var k))
            {
                return k;
            }
            throw new ArgumentOutOfRangeException(nameof(s), $"Button name mismatch (couldn't find a MouseButton value for {s})");
        }

        public static MouseButton GlfwButtonToSilkButton(GLFW.MouseButton k)
        {
            if (Enum.TryParse<MouseButton>(k.ToString(), out var sk))
            {
                return sk;
            }
            if (Enum.IsDefined(typeof(MouseButton), k))
            {
                return (MouseButton)k;
            }
            throw new ArgumentOutOfRangeException(nameof(k));
        }

        public static Thumbstick ApplyDeadzone(Thumbstick thumbstick, Deadzone deadzone)
        {
            return new Thumbstick(thumbstick.Index, deadzone.Apply(thumbstick.X), deadzone.Apply(thumbstick.Y));
        }

        public static Axis ApplyDeadzone(Axis axis, Deadzone deadzone)
        {
            return new Axis(axis.Index, deadzone.Apply(axis.Position));
        }
    }
}
