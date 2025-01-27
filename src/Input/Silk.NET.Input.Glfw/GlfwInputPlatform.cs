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
            }
            else
            {
                throw new ObjectDisposedException($"Input context already disposed for window {(nint) handle}");
            }
        }
    }
}
