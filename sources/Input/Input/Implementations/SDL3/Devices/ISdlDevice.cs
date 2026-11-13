// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.SDL3;

/// <summary>
/// An interface defining a generic "constructor" for managed SDL devices.
/// </summary>
/// <typeparam name="T"></typeparam>
internal interface ISdlDevice<out T> : IInputDevice where T : SdlDevice
{
    public static abstract T? CreateDevice(ulong sdlDeviceId, long timestamp, bool isSimulated, SdlInputBackend backend, SdlInputEventContext context);
}

/// <summary>
/// For devices that need a finalization step after each "frame" of input. For instance, keyboards may need it for
/// finalizing text entry state.
/// </summary>
internal interface INeedCompletionEachFrame
{
    public void CompleteUpdate();
}

/// <summary>
/// For devices that need to reset state prior to a new round of input. For instance, mouse wheel position
/// </summary>
internal interface INeedPreUpdate
{
    public void PreUpdate();
}

/// <summary>
/// For devices that need additional pointer targets to generate points other than the one for their own primary target.
/// For instance, a mouse may be based on a window as its pointer target, but through this method can generate points
/// for other targets such as the desktop.
/// </summary>
internal interface IMapTargetPoints
{
    public void AppendPointsTranslatedToOtherTargets(IReadOnlyList<IPointerTarget> allTargets, IPointerTarget unboundedTarget);
}

/// <summary>
/// For devices such as gamepads and joysticks, as their SDL IDs are likely to change when other devices
/// are removed (likely what drives controller numbers 1-4, etc).
/// </summary>
internal interface IOrderedDevice
{
    public void RefreshSdlId();
}
