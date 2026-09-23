// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.DataStructures;

internal sealed class SdlInputEventQueue<T> where T : struct
{
    public static readonly SdlEventDiscriminator TypeDiscriminator = InputEventKinds.Get(typeof(T));

    public int Count => _events.Count;

    public void Enqueue(in T item, ulong sdlTimestamp)
    {
        if (_disposed)
        {
            GC.ReRegisterForFinalize(this);
            _disposed = false;
        }

        _events.Add(item);
        _sdlTimestamps.Add(sdlTimestamp);
    }

    public ReadOnlySpan<ulong> SdlTimestamps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _sdlTimestamps.AsSpan();
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
        _sdlTimestamps.Dispose();
        _events.Dispose();
        GC.SuppressFinalize(this);
    }

    ~SdlInputEventQueue()
    {
        if (!_disposed)
        {
            _sdlTimestamps.Dispose();
            _events.Dispose();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal SdlTimestampedValues<T> AsSpanPair() => new(_events.AsSpan(), _sdlTimestamps.AsSpan());


    internal readonly ref struct SdlTimestampedValues<TValue> where TValue : struct
    {
        public readonly Span<TValue> Values;
        public readonly Span<ulong> SdlTimestamps;

        public SdlTimestampedValues(Span<TValue> values,
            Span<ulong> sdlTimestamps)
        {
            Values = values;
            SdlTimestamps = sdlTimestamps;
        }

        public int Length
        {
            get
            {
                Debug.Assert(Values.Length == SdlTimestamps.Length);
                return Values.Length;
            }
        }
    }

    private bool _disposed;
    private PinnedGcMemory<T> _events;
    private PinnedGcMemory<ulong> _sdlTimestamps;

    /// <summary>
    /// Resets the count of our events without explicitly clearing the memory
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void ResetCount()
    {
        _events.ResetCount();
        _sdlTimestamps.ResetCount();
    }
}
