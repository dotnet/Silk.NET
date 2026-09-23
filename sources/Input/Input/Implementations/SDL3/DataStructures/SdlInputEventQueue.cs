// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.DataStructures;

internal sealed class SdlInputEventQueue<T> where T : struct
{
    private static readonly SdlEventDiscriminator _typeDiscriminator = InputEventKinds.Get(typeof(T));

    /// <summary>
    /// The "master" list of events we append each of our events to
    /// </summary>
    private readonly List<GenericEvent> _genericEvents;

    public SdlInputEventQueue(List<GenericEvent> genericEventQueue) => _genericEvents = genericEventQueue;

    public void Enqueue(in T item)
    {
        if (_disposed)
        {
            GC.ReRegisterForFinalize(this);
            _disposed = false;
        }

        _genericEvents.Add(new GenericEvent(this, _events.Count, _typeDiscriminator));
        _events.Add(item);
    }

    /// <inheritdoc cref="PinnedGcMemory{T}.UnsafeGetRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref readonly T UnsafeGetRef(int index) => ref _events.UnsafeGetRef(index);


    public void Dispose()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(SdlInputEventQueue<>));
        }

        _disposed = true;
        _events.Dispose();
        GC.SuppressFinalize(this);
    }

    ~SdlInputEventQueue()
    {
        if (!_disposed)
        {
            _events.Dispose();
        }
    }

    private bool _disposed;
    private PinnedGcMemory<T> _events;

    /// <summary>
    /// Resets the count of our events without explicitly clearing the memory
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void ResetCount() => _events.ResetCount();
}
