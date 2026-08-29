// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.DataStructures;

internal class SdlInputEventQueue<T> : ISdlInputEventQueue<T>, IDisposable where T : struct
{
    // Currently unused, so just commenting this out
    /*public int Count
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Debug.Assert(_sdlTimestamps.Count == _events.Count);
            return _sdlTimestamps.Count;
        }
    }*/


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


    internal readonly ref struct SdlTimestampedValues<TValue>(NativeMemory<TValue>.UnsafeView values, NativeMemory<ulong>.UnsafeView sdlTimestamps) where TValue : struct
    {
        public readonly NativeMemory<TValue>.UnsafeView Values = values;
        public readonly NativeMemory<ulong>.UnsafeView SdlTimestamps = sdlTimestamps;

        public int Length
        {
            get
            {
                Debug.Assert(Values.Length == SdlTimestamps.Length);
                return Values.Length;
            }
        }
    }

    /// <Summary>
    /// Returns a reference to our data as two spans and clears the inner count of our buffers
    /// (the functional equivalent of calling <see cref="List{T}.Clear()"/>)
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal SdlTimestampedValues<T> ConsumeWithoutClearing() => new(_events.ConsumeWithoutClearing(), _sdlTimestamps.ConsumeWithoutClearing());

    public void Clear(bool entireCapacity, int startIndex = 0)
    {
        _events.ClearValues(entireCapacity, (uint)startIndex);
        _sdlTimestamps.ClearValues(entireCapacity, (uint)startIndex);
    }

    public void Dispose()
    {
        if(_disposed)
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
        if (_disposed)
            return;

        _sdlTimestamps.Dispose();
        _events.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public SdlTimestampedValues<T> AsSpanPair() => new(_events.AsSpan(), _sdlTimestamps.AsSpan());

    private bool _disposed;
    private NativeMemory<T> _events;
    private NativeMemory<ulong> _sdlTimestamps;
}
