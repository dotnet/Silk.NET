// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// Our internal representation of an SDL Touch Device.
/// See SDL's <a href="https://wiki.libsdl.org/SDL3/SDL_TouchDeviceType">documentation</a> for more information.
/// <br/><br/>
/// A touch device, according to SDL, can be one of three types:
/// <list type="bullet">
///     <item>Direct: touch screen with window-relative coordinates</item>
///     <item>IndirectAbsolute: trackpad with absolute device coordinates</item>
///     <item>IndirectRelative: trackpad with screen cursor-relative coordinates</item>
/// </list>
/// </summary>
internal class SdlTouchSurface : SdlPointerDevice, ISdlDevice<SdlTouchSurface>, IPointerDevice
{
    public static SdlTouchSurface CreateDevice(ulong sdlDeviceId, SdlInputBackend backend)
    {
        var namePtr = backend.Sdl.GetTouchDeviceName(sdlDeviceId);

        nint uniqueId = 0;
        if (backend.AttemptUniqueId(sdlDeviceId, ref uniqueId))
        {
            return Create();
        }
        if (backend.AttemptUniqueId(namePtr, ref uniqueId))
        {
            return Create();
        }

        uniqueId = SdlInputBackend.FallbackUniqueId(sdlDeviceId, uniqueId);

        return Create();

        SdlTouchSurface Create()
        {
            // https://wiki.libsdl.org/SDL3/SDL_MOUSE_TOUCHID
            // todo - did i get this right ??
            const ulong simulatedId = ulong.MaxValue;
            //const ulong simulatedId = (1UL << 63) & 1UL;
            //const ulong simulatedId = (1UL << 31) & 1UL;
            var isSimulated = sdlDeviceId == simulatedId;
            var deviceType = backend.Sdl.GetTouchDeviceType(sdlDeviceId);
            return new SdlTouchSurface(sdlDeviceId, uniqueId, backend, backend.UnboundedPointerTarget, deviceType, isSimulated);
        }
    }

    public bool IsSimulated { get; }

    public override string Name
    {
        get
        {
            var ptr = NativeBackend.GetTouchDeviceName(SdlDeviceId);
            if (ptr == nullptr)
            {
                SdlLog.Debug("Failed to get touch device name");
                return "Unknown Touch Surface";
            }

            return ptr.ReadToString();
        }
    }


    protected override void Release() => InputLog.Debug("Releasing touch device, but touch devices have no special release logic.");

    // todo - consider whether we want to use the related mouse device's buttons here
    //  (if this is a simulated touch device),
    //  or some other simulation method?
   // protected override uint GetButtonMaskSdl() => 0;

    public override PointerState State { get; }

    protected override bool OnePointOnly => false;
    private readonly TouchDeviceType _type;

    public SdlTouchSurface(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend, IPointerTarget unbounded, TouchDeviceType type, bool isSimulated) : base(backend, uniqueId, sdlDeviceId, unbounded)
    {
        _type = type;
        IsSimulated = isSimulated;
        if (type == TouchDeviceType.Invalid)
        {
            throw new ArgumentException("Invalid touch device type");
        }

        State = new PointerState(Buttons, Points);
    }

    public override void Initialize()
    {

    }

    public void Event(in TouchFingerEvent finger, IPointerTarget? target, SdlInputBackend.FingerEventType fingerType)
    {
    }
}
