// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.GLFW;
using Silk.NET.Input.Internals;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;
using Silk.NET.Windowing.Internals;

namespace Silk.NET.Input.Glfw
{
    internal class GlfwInputContext : InputContextImplementationBase
    {
        private readonly GlfwGamepad[] _gamepads = new GlfwGamepad[16];
        private readonly GlfwJoystick[] _joysticks = new GlfwJoystick[16];
        private readonly GlfwKeyboard[] _keyboards = new GlfwKeyboard[1];
        private readonly GlfwMouse[] _mice = new GlfwMouse[1];
        private readonly IGlfwSubscriber[] _subscribers = new IGlfwSubscriber[2];

        public unsafe GlfwInputContext(IView window) : base(window)
        {
            void OnConnectionChanged(IInputDevice a, bool b) => ConnectionChanged?.Invoke(a, b);

            if (window is not GlfwWindow)
            {
                throw new ArgumentNullException
                    (nameof(window), "Attempted to create input context for null or non-GLFW window.");
            }

            Handle = window.Handle;
            for (var i = 0; i < _gamepads.Length; i++)
            {
                _gamepads[i] = new GlfwGamepad(i) {OnConnectionChanged = OnConnectionChanged};
            }

            for (var i = 0; i < _joysticks.Length; i++)
            {
                _joysticks[i] = new GlfwJoystick(i) {OnConnectionChanged = OnConnectionChanged};
            }

            _subscribers[0] = _keyboards[0] = new GlfwKeyboard();
            _subscribers[1] = _mice[0] = new GlfwMouse();

            Gamepads = new IsConnectedWrapper<GlfwGamepad>(_gamepads);
            Joysticks = new IsConnectedWrapper<GlfwJoystick>(_joysticks);
            Keyboards = _keyboards;
            Mice = _mice;

            GlfwInputPlatform.RegisterWindow((WindowHandle*) Handle, _subscribers);
        }

        public override void ProcessEvents()
        {
            foreach (var updatable in _mice)
            {
                updatable.Update();
            }

            foreach (var updatable in _gamepads)
            {
                updatable.Update();
            }

            foreach (var updatable in _joysticks)
            {
                updatable.Update();
            }
        }

        public override unsafe void CoreDispose()
        {
            GlfwInputPlatform.UnregisterWindow((WindowHandle*) Handle, _subscribers);
            foreach (var gamepad in _gamepads)
            {
                gamepad.Dispose();
            }

            foreach (var joystick in _joysticks)
            {
                joystick.Dispose();
            }

            foreach (var mouse in _mice)
            {
                mouse.Dispose();
            }
        }

        public sealed override nint Handle { get; }
        public override IReadOnlyList<IGamepad> Gamepads { get; }
        public override IReadOnlyList<IJoystick> Joysticks { get; }
        public override IReadOnlyList<IKeyboard> Keyboards { get; }
        public override IReadOnlyList<IMouse> Mice { get; }
        public override IReadOnlyList<IInputDevice> OtherDevices { get; } = Array.Empty<IInputDevice>();
        public override event Action<IInputDevice, bool>? ConnectionChanged;
    }
}
