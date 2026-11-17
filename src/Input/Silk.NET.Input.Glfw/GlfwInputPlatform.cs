// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Input;
using Silk.NET.Input.Glfw;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;

[assembly: InputPlatform(typeof(GlfwInputPlatform))]

namespace Silk.NET.Input.Glfw
{
    /// <inheritdoc />
    internal class GlfwInputPlatform : IInputPlatform
    {
        private static readonly Dictionary<nint, GlfwEvents> _subs = new Dictionary<nint, GlfwEvents>();

        // Unlike the keyboard/mouse callbacks, GLFW's joystick callback is global rather than per window, so it is
        // owned here instead of by GlfwEvents.cs and available to every live input context.
        private static readonly GlfwCallbacks.JoystickCallback _joystickCallback =
            (jid, state) => JoystickConnectionChanged?.Invoke(jid, state);

        /// <summary>
        /// Raised when GLFW reports that a joystick has been connected to or disconnected from the system. The
        /// underlying GLFW callback is only installed while at least one input context is alive.
        /// </summary>
        internal static event GlfwCallbacks.JoystickCallback? JoystickConnectionChanged;

        /// <inheritdoc />
        public bool IsApplicable(IView window) => window is GlfwWindow;

        /// <inheritdoc />
        public IInputContext CreateInput(IView window) => new GlfwInputContext(window);

        internal static unsafe void RegisterWindow(WindowHandle* handle, IEnumerable<IGlfwSubscriber> subscribers)
        {
            if (_subs.ContainsKey((nint) handle))
            {
                throw new InvalidOperationException($"More than one input context for window {(nint) handle}.");
            }

            if (_subs.Count == 0)
            {
                GlfwProvider.GLFW.Value.SetJoystickCallback(_joystickCallback);
            }

            var events = _subs[(nint) handle] = new GlfwEvents(handle);
            foreach (var subscriber in subscribers)
            {
                subscriber.Subscribe(events);
            }
        }

        internal static unsafe void UnregisterWindow(WindowHandle* handle, IEnumerable<IGlfwSubscriber> subscribers)
        {
            if (_subs.TryGetValue((nint) handle, out var events))
            {
                foreach (var subscriber in subscribers)
                {
                    subscriber.Unsubscribe(events);
                }

                events.Dispose();
                _subs.Remove((nint) handle);

                if (_subs.Count == 0)
                {
                    GlfwProvider.GLFW.Value.SetJoystickCallback(null);
                }
            }
            else
            {
                throw new ObjectDisposedException($"Input context already disposed for window {(nint) handle}");
            }
        }
    }
}
