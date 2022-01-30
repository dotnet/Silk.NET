// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Internals;

namespace Silk.NET.Input.Internals;

internal abstract class InputContextImplementationBase : IInputContext
{
    protected InputContextImplementationBase(IView window)
    {
        Window = window;
        if (window is ViewImplementationBase view)
        {
            view.ProcessEvents += ProcessEvents;
        }
        else
        {
            window.Update += Update;
        }
    }

    private void Update(double delta) => ProcessEvents();

    public void Dispose()
    {
        if (Window is ViewImplementationBase view)
        {
            view.ProcessEvents -= ProcessEvents;
        }
        else
        {
            Window.Update -= Update;
        }
        CoreDispose();
    }
    
    public abstract void CoreDispose();
    public abstract void ProcessEvents();
    public IView Window { get; }
    public abstract nint Handle { get; }
    public abstract IReadOnlyList<IGamepad> Gamepads { get; }
    public abstract IReadOnlyList<IJoystick> Joysticks { get; }
    public abstract IReadOnlyList<IKeyboard> Keyboards { get; }
    public abstract IReadOnlyList<IMouse> Mice { get; }
    public abstract IReadOnlyList<IInputDevice> OtherDevices { get; }
    public abstract event Action<IInputDevice, bool>? ConnectionChanged;
}
