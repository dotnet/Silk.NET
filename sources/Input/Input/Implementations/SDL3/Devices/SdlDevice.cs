// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A base class for all SDL input devices.
/// </summary>
internal abstract class SdlDevice : IInputDevice, IDisposable
{
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    bool IEquatable<IInputDevice>.Equals(IInputDevice? other) => Equals(other);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode() => Id.GetHashCode();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object? obj) => obj is SdlDevice device && Equals(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool Equals(SdlDevice? other) => other != null &&
                                             Id == other.Id &&
                                             GetType() == other.GetType() &&
                                             NativeBackend == other.NativeBackend;

    protected internal abstract void Initialize(long timestamp, ulong sdlTimestamp);

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
}
