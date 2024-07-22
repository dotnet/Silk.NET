// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.SDL;

namespace Silk.NET.Windowing;

internal class SdlSurface(SdlNativeWindow native) : ISurface, IDisposable
{
    // TODO child windows
    public static bool TryConfigure<THost>(THost dest, [HluHostedComponent] IPlatformInfo platform)
        where THost : IHluComponentHost =>
        Instance is not null
            ? throw new InvalidOperationException(
                "All subsequent surfaces must be created from the root surface i.e. must be a child of the "
                    + "first surface created. A surface has already been created without a parent."
            )
            : platform is SdlNativeWindow native
                && dest.TrySet<ISurface, SdlSurface>(Instance = new SdlSurface(native));

    public Vector2 ClientSize
    {
        get
        {
            if (native.Window == nullptr)
            {
                return default;
            }

            int w = 0,
                h = 0;
            if (native.Api.GetWindowSizeInPixels(native.Window, w.AsRef(), h.AsRef()) != 0)
            {
                native.Api.ThrowError();
            }

            return new Vector2(w, h);
        }
    }

    public unsafe IntPtr Handle => (nint)native.Window.Handle;

    public void Run<T>(T actor)
        where T : ISurfaceActor
    {
        // TODO: ANDROID NOTE: There will be no blocking on Android! Instead, onCreate calls into the user's main
        // TODO (assumed to be xplat code that assumes blocking) which when calling Run, will do nothing other than set
        // the actor. The runnable returned from createMainRunnable will then call into SDL, so it's a slight
        // separation.
        Event @event = default;
        while (true)
        {
            actor.HandleTick();

            if (native.Api.PollEvent(@event.AsRef()))
            {
                switch ((EventType)@event.Type)
                {
                    case EventType.First:
                        break;
                    case EventType.Quit:
                    {
                        break;
                    }
                    case EventType.Terminating:
                        break;
                    case EventType.LowMemory:
                        break;
                    case EventType.WillEnterBackground:
                        break;
                    case EventType.DidEnterBackground:
                        break;
                    case EventType.WillEnterForeground:
                        break;
                    case EventType.DidEnterForeground:
                        break;
                    case EventType.LocaleChanged:
                        break;
                    case EventType.SystemThemeChanged:
                        break;
                    case EventType.DisplayOrientation:
                        break;
                    case EventType.DisplayAdded:
                        break;
                    case EventType.DisplayRemoved:
                        break;
                    case EventType.DisplayMoved:
                        break;
                    case EventType.DisplayContentScaleChanged:
                        break;
                    case EventType.DisplayHdrStateChanged:
                        break;
                    case EventType.WindowShown:
                        break;
                    case EventType.WindowHidden:
                        break;
                    case EventType.WindowExposed:
                        break;
                    case EventType.WindowMoved:
                        break;
                    case EventType.WindowResized:
                        break;
                    case EventType.WindowPixelSizeChanged:
                        break;
                    case EventType.WindowMinimized:
                        break;
                    case EventType.WindowMaximized:
                        break;
                    case EventType.WindowRestored:
                        break;
                    case EventType.WindowMouseEnter:
                        break;
                    case EventType.WindowMouseLeave:
                        break;
                    case EventType.WindowFocusGained:
                        break;
                    case EventType.WindowFocusLost:
                        break;
                    case EventType.WindowCloseRequested:
                        break;
                    case EventType.WindowTakeFocus:
                        break;
                    case EventType.WindowHitTest:
                        break;
                    case EventType.WindowIccprofChanged:
                        break;
                    case EventType.WindowDisplayChanged:
                        break;
                    case EventType.WindowDisplayScaleChanged:
                        break;
                    case EventType.WindowOccluded:
                        break;
                    case EventType.WindowEnterFullscreen:
                        break;
                    case EventType.WindowLeaveFullscreen:
                        break;
                    case EventType.WindowDestroyed:
                        break;
                    case EventType.WindowPenEnter:
                        break;
                    case EventType.WindowPenLeave:
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
                    case EventType.ClipboardUpdate:
                        break;
                    case EventType.DropFile:
                        break;
                    case EventType.DropText:
                        break;
                    case EventType.DropBegin:
                        break;
                    case EventType.DropComplete:
                        break;
                    case EventType.DropPosition:
                        break;
                    case EventType.AudioDeviceAdded:
                        break;
                    case EventType.AudioDeviceRemoved:
                        break;
                    case EventType.AudioDeviceFormatChanged:
                        break;
                    case EventType.SensorUpdate:
                        break;
                    case EventType.PenDown:
                        break;
                    case EventType.PenUp:
                        break;
                    case EventType.PenMotion:
                        break;
                    case EventType.PenButtonDown:
                        break;
                    case EventType.PenButtonUp:
                        break;
                    case EventType.CameraDeviceAdded:
                        break;
                    case EventType.CameraDeviceRemoved:
                        break;
                    case EventType.CameraDeviceApproved:
                        break;
                    case EventType.CameraDeviceDenied:
                        break;
                    case EventType.RenderTargetsReset:
                        break;
                    case EventType.RenderDeviceReset:
                        break;
                    case EventType.PollSentinel:
                        break;
                    case EventType.User:
                        break;
                    case EventType.Last:
                        break;
                    case EventType.EnumPadding:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    private static SdlSurface? Instance { get; set; }

    public void Dispose() => Instance = null;
}
