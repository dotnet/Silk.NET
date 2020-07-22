// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
        public GlfwInputPlatform(){}
        private static Dictionary<IntPtr, GlfwEvents> _subs = new Dictionary<IntPtr, GlfwEvents>();
        /// <inheritdoc />
        public bool IsApplicable(IView window) => window is GlfwWindow;

        /// <inheritdoc />
        public IInputContext CreateInput(IView window) => new GlfwInputContext(window);
        
        internal static unsafe void RegisterWindow(WindowHandle* handle, IEnumerable<IGlfwSubscriber> subscribers)
        {
            var events = _subs.ContainsKey
                ((IntPtr) handle)
                ? _subs[(IntPtr) handle]
                : _subs[(IntPtr) handle] = new GlfwEvents(handle);
            foreach (var subscriber in subscribers)
            {
                subscriber.Subscribe(events);
            }
        }
        
        internal static unsafe void UnregisterWindow(WindowHandle* handle, IEnumerable<IGlfwSubscriber> subscribers)
        {
            var events = _subs.ContainsKey
                ((IntPtr) handle)
                ? _subs[(IntPtr) handle]
                : _subs[(IntPtr) handle] = new GlfwEvents(handle);
            foreach (var subscriber in subscribers)
            {
                subscriber.Unsubscribe(events);
            }
        }
    }
}
