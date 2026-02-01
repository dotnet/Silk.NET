// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Input.SDL3.Devices.Pointers;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A base class for all SDL input devices.
/// </summary>
internal abstract class SdlDevice : IInputDevice, IDisposable
{
    bool IEquatable<IInputDevice>.Equals(IInputDevice? other) =>
        other?.GetType() == GetType()
        && other.Id == Id
        && (other as SdlDevice)!.NativeBackend == NativeBackend;

    public nint Id { get; }

    public virtual ulong SdlDeviceId { get; }

    public SdlInputBackend Backend { get; }

    /// <summary>
    /// For readability and refactorability - provides the SDL interface instance.
    /// </summary>
    protected ISdl NativeBackend => Backend.Sdl;

    public abstract string Name { get; }

    protected SdlDevice(SdlInputBackend backend, nint uniqueId, ulong sdlDeviceId)
    {
        Backend = backend;
        Id = uniqueId;
        SdlDeviceId = sdlDeviceId;
    }

    /// <summary>
    /// This is called directly after the device's constructor completes.
    /// Use it for initialization logic that requires object construction to be complete to perform.
    /// </summary>
    public abstract void Initialize();


    protected abstract void Release();

    public void Dispose()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, GetType());
        _isDisposed = true;
        Release();
        GC.SuppressFinalize(this);
    }

    ~SdlDevice()
    {
        if (!_isDisposed)
        {
            InputLog.Error($"Failed to properly dispose {GetType().Name} {Id} (sdl ID: {SdlDeviceId}).");
        }

        _isDisposed = true;
        Release();
    }

    private bool _isDisposed;
    public abstract void FinalizeUpdate(SdlInputBackend.SilkEventQueues silkEvents);
}
