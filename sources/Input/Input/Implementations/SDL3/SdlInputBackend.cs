// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlInputBackend : IInputBackend
{
    public unsafe SdlInputBackend(INativeWindow window, SdlPlatformInfo info)
    {
        var ptr = new EventFilter(OnEvent);
        Info = info;
        Sdl.AddEventWatch(ptr, nullptr);
        Id = (nint)ptr.Handle;
        Window = window;
        // ===============================================================================================
        // === If we ever need to share common state across window-specific "backends", use the below: ===
        // ===============================================================================================
        // var rootSurface = info.Window;
        // var parent = rootSurface;
        // while ((parent = Sdl.GetWindowParent(rootSurface)) != nullptr)
        // {
        //     rootSurface = parent;
        // }
        // var props = Sdl.GetWindowProperties(rootSurface);
        // if (props == 0)
        // {
        //     Sdl.ThrowError();
        // }
        // Ref<sbyte> pname = "org.dotnetfoundation.silkdotnet.inputroot";
        // var root = (nint)Sdl.GetPointerProperty(props, pname, nullptr);
        // if (root != 0)
        // {
        //     Root =
        //         GCHandle.FromIntPtr(root).Target as SdlBackendRoot
        //         ?? throw new InvalidOperationException(
        //             "The global input data for this ancestry of SDL windows was not in an expected format."
        //         );
        // }
        // else
        // {
        //     Root = new SdlBackendRoot();
        //     var newHandle = GCHandle.Alloc(Root);
        //     if (
        //         Sdl.SetPointerPropertyWithCleanup(
        //             props,
        //             pname,
        //             (Ptr)GCHandle.ToIntPtr(newHandle),
        //             new CleanupPropertyCallback(&CleanupRoot),
        //             nullptr
        //         )
        //     )
        //     {
        //         return;
        //     }
        //     newHandle.Free();
        //     Sdl.ThrowError();
        // }
    }

    // [UnmanagedCallersOnly]
    // private static unsafe void CleanupRoot(void* _, void* value) =>
    //    GCHandle.FromIntPtr((nint)value).Free();

    public INativeWindow Window { get; }
    public SdlPlatformInfo Info { get; }
    public ISdl Sdl => Info.Sdl ?? SDL.Sdl.Instance;

    // public SdlBackendRoot Root { get; }

    public string Name =>
        $"Silk.NET.Input Reference Implementation using SDL3 ({Sdl.GetPlatform().ReadToString()})";

    public nint Id { get; }

    public IReadOnlyList<IInputDevice> Devices => throw new NotImplementedException();

    public void Update(IInputHandler? handler = null) => throw new NotImplementedException();

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    private unsafe byte OnEvent(void* arg0, Event* arg1)
    {
        // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
        switch ((EventType)arg1->Common.Type)
        {
            case EventType.WindowMouseEnter:
                break;
            case EventType.WindowMouseLeave:
                break;
            case EventType.KeyDown:
                break;
            case EventType.KeyUp:
                break;
            case EventType.TextEditing:
                break;
            case EventType.TextInput:
                break;
            case EventType.KeymapChanged:
                break;
            case EventType.KeyboardAdded:
                break;
            case EventType.KeyboardRemoved:
                break;
            case EventType.TextEditingCandidates:
                break;
            case EventType.MouseMotion:
                break;
            case EventType.MouseButtonDown:
                break;
            case EventType.MouseButtonUp:
                break;
            case EventType.MouseWheel:
                break;
            case EventType.MouseAdded:
                break;
            case EventType.MouseRemoved:
                break;
            case EventType.JoystickAxisMotion:
                break;
            case EventType.JoystickBallMotion:
                break;
            case EventType.JoystickHatMotion:
                break;
            case EventType.JoystickButtonDown:
                break;
            case EventType.JoystickButtonUp:
                break;
            case EventType.JoystickAdded:
                break;
            case EventType.JoystickRemoved:
                break;
            case EventType.JoystickBatteryUpdated:
                break;
            case EventType.JoystickUpdateComplete:
                break;
            case EventType.GamepadAxisMotion:
                break;
            case EventType.GamepadButtonDown:
                break;
            case EventType.GamepadButtonUp:
                break;
            case EventType.GamepadAdded:
                break;
            case EventType.GamepadRemoved:
                break;
            case EventType.GamepadRemapped:
                break;
            case EventType.GamepadTouchpadDown:
                break;
            case EventType.GamepadTouchpadMotion:
                break;
            case EventType.GamepadTouchpadUp:
                break;
            case EventType.GamepadSensorUpdate:
                break;
            case EventType.GamepadUpdateComplete:
                break;
            case EventType.GamepadSteamHandleUpdated:
                break;
            case EventType.FingerDown:
                break;
            case EventType.FingerUp:
                break;
            case EventType.FingerMotion:
                break;
            case EventType.FingerCanceled:
                break;
            case EventType.ClipboardUpdate:
                break;
            case EventType.SensorUpdate:
                break;
            case EventType.PenProximityIn:
                break;
            case EventType.PenProximityOut:
                break;
            case EventType.PenDown:
                break;
            case EventType.PenUp:
                break;
            case EventType.PenButtonDown:
                break;
            case EventType.PenButtonUp:
                break;
            case EventType.PenMotion:
                break;
            case EventType.PenAxis:
                break;
        }

        return 1;
    }

    private bool IsSupported(EventType type) =>
        type
            is EventType.WindowMouseEnter
                or EventType.WindowMouseLeave
                or EventType.KeyDown
                or EventType.KeyUp
                or EventType.TextEditing
                or EventType.TextInput
                or EventType.KeymapChanged
                or EventType.KeyboardAdded
                or EventType.KeyboardRemoved
                or EventType.TextEditingCandidates
                or EventType.MouseMotion
                or EventType.MouseButtonDown
                or EventType.MouseButtonUp
                or EventType.MouseWheel
                or EventType.MouseAdded
                or EventType.MouseRemoved
                or EventType.JoystickAxisMotion
                or EventType.JoystickBallMotion
                or EventType.JoystickHatMotion
                or EventType.JoystickButtonDown
                or EventType.JoystickButtonUp
                or EventType.JoystickAdded
                or EventType.JoystickRemoved
                or EventType.JoystickBatteryUpdated
                or EventType.JoystickUpdateComplete
                or EventType.GamepadAxisMotion
                or EventType.GamepadButtonDown
                or EventType.GamepadButtonUp
                or EventType.GamepadAdded
                or EventType.GamepadRemoved
                or EventType.GamepadRemapped
                or EventType.GamepadTouchpadDown
                or EventType.GamepadTouchpadMotion
                or EventType.GamepadTouchpadUp
                or EventType.GamepadSensorUpdate
                or EventType.GamepadUpdateComplete
                or EventType.GamepadSteamHandleUpdated
                or EventType.FingerDown
                or EventType.FingerUp
                or EventType.FingerMotion
                or EventType.FingerCanceled
                or EventType.ClipboardUpdate
                or EventType.SensorUpdate
                or EventType.PenProximityIn
                or EventType.PenProximityOut
                or EventType.PenDown
                or EventType.PenUp
                or EventType.PenButtonDown
                or EventType.PenButtonUp
                or EventType.PenMotion
                or EventType.PenAxis;

    private unsafe void ReleaseUnmanagedResources()
    {
        Sdl.RemoveEventWatch(
            new EventFilter((delegate* unmanaged<void*, Event*, byte>)(void*)Id),
            nullptr
        );
        SilkMarshal.Free((Ptr)Id);
    }

    ~SdlInputBackend() => ReleaseUnmanagedResources();
}
