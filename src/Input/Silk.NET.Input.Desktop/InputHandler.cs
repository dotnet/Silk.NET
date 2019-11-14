// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silk.NET.GLFW;
using Silk.NET.Input.Common;
using MouseButton = Silk.NET.GLFW.MouseButton;

namespace Silk.NET.Input.Desktop
{
    internal class InputHandler
    {
        public static List<GlfwInputContext> Contexts { get; }

        static InputHandler()
        {
            Contexts = new List<GlfwInputContext>();
            Util.Glfw.SetJoystickCallback(JoystickCallback);
        }

        public static unsafe void RegisterContext(GlfwInputContext ctx)
        {
            if (Contexts.Any(x => x._window == ctx._window))
            {
                return;
            }

            Contexts.Add(ctx);

            // register callbacks
            var handle = (WindowHandle*) ctx._window.Handle;
            Util.Glfw.SetKeyCallback(handle, KeyCallback);
            Util.Glfw.SetMouseButtonCallback(handle, MouseCallback);
            Util.Glfw.SetScrollCallback(handle, ScrollCallback);
            Util.Glfw.SetCursorPosCallback(handle, CursorCallback);
            Util.Glfw.SetCharCallback(handle, CharCallback);
            ctx._window.Update += ctx.WindowUpdate;
        }

        private static unsafe void CharCallback(WindowHandle* window, uint codepoint)
        {
            // multiple contexts for one window should be allowed, but frowned upon
            var allContexts = Contexts.Where(z => z._window.Handle == (IntPtr) window);

            foreach (var context in allContexts)
            {
                ((GlfwKeyboard) context._keyboard).RaiseCharEvent(Convert.ToChar(codepoint));
            }
        }

        private static unsafe void CursorCallback(WindowHandle* window, double x, double y)
        {
            // multiple contexts for one window should be allowed, but frowned upon
            var allContexts = Contexts.Where(z => z._window.Handle == (IntPtr) window);

            foreach (var context in allContexts)
            {
                ((GlfwMouse) context._mouse).RaiseMouseMove(new PointF((float) x, (float) y));
            }
        }

        private static unsafe void ScrollCallback(WindowHandle* window, double offsetx, double offsety)
        {
            // multiple contexts for one window should be allowed, but frowned upon
            var allContexts = Contexts.Where(x => x._window.Handle == (IntPtr) window);

            foreach (var context in allContexts)
            {
                ((GlfwMouse) context._mouse).RaiseScroll(new ScrollWheel((float) offsetx, (float) offsety));
            }
        }

        private static void JoystickCallback(int joystick, ConnectedState state)
        {
            Contexts.ForEach(x => x.RaiseConnectionChange(joystick, state));
        }

        private static unsafe void MouseCallback
            (WindowHandle* window, MouseButton button, InputAction action, KeyModifiers mods)
        {
            // multiple contexts for one window should be allowed, but frowned upon
            var allContexts = Contexts.Where(x => x._window.Handle == (IntPtr) window);

            foreach (var context in allContexts)
            {
                if (action == InputAction.Press)
                {
                    ((GlfwMouse) context._mouse).RaiseMouseDown(Util.GlfwButtonToSilkButton(button));
                }
                else if (action == InputAction.Release)
                {
                    ((GlfwMouse) context._mouse).RaiseMouseUp(Util.GlfwButtonToSilkButton(button));
                }
            }
        }

        private static unsafe void KeyCallback
            (WindowHandle* window, Keys key, int scancode, InputAction action, KeyModifiers mods)
        {
            // multiple contexts for one window should be allowed, but frowned upon
            var allContexts = Contexts.Where(x => x._window.Handle == (IntPtr) window);

            foreach (var context in allContexts)
            {
                if (action == InputAction.Press)
                {
                    ((GlfwKeyboard) context._keyboard).RaisePressEvent(key, scancode, mods);
                }
                else if (action == InputAction.Release)
                {
                    ((GlfwKeyboard) context._keyboard).RaiseReleaseEvent(key, scancode, mods);
                }
            }
        }

        public static void UnregisterContext(GlfwInputContext ctx)
        {
            Contexts.Remove(ctx);
            ctx._window.Update -= ctx.WindowUpdate;
        }
    }
}
