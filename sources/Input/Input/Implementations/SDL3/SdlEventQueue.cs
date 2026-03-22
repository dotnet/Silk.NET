// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3;

internal class SdlEventQueue<T> : ISdlEventQueue<T> where T : struct
{
    private T[] _events = GC.AllocateUninitializedArray<T>(8);
    private ulong[] _sdlTimestamps = new ulong[8];

#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
    protected ref T GetPtr(int index, out ulong sdlTimestamp)
    {
        sdlTimestamp = _sdlTimestamps[index];
        return ref _events[index];
    }
#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type

    public int Count { get; protected set; }


    public void Enqueue(in T item, ulong sdlTimestamp)
    {
        if (Count == _events.Length)
        {
            var newLen = _events.Length * 2;
            var newEvents = GC.AllocateUninitializedArray<T>(newLen);
            _events.CopyTo(newEvents, 0);
            _events = newEvents;

            Array.Resize(ref _sdlTimestamps, newLen);
        }

        _sdlTimestamps[Count] = sdlTimestamp;
        _events[Count++] = item;
    }


    internal readonly ref struct ValuePair<TValue>(TValue[] values, ulong[] sdlTimestamps, int count)
    {
        public readonly TValue[] Values = values;
        public readonly ulong[] SdlTimestamps = sdlTimestamps;
        public readonly int Count = count;
    }

    internal ValuePair<T> Consume()
    {
        var count = Count;
        Count = 0;
        return new ValuePair<T>(_events, _sdlTimestamps, count);
    }

    public void Clear()
    {
        _events.AsSpan().Clear();
        Count = 0;
    }
}

internal sealed class GenericEventQueue : SdlEventQueue<GenericEvent>
{
    private readonly SdlTimestampCalculator.Basis _basis;
    public GenericEventQueue(SdlTimestampCalculator.Basis basis) => _basis = basis;


    public unsafe void ConsumeQueue<T>(in SdlEventQueue<T> queue) where T : struct, ITimestampedEvent
    {
        var q = queue.Consume();
        for (var i = 0; i < q.Count; i++)
        {
            ref var src = ref q.Values[i];
            var genericEvent = new GenericEvent(
                EventPtr: (nint)Unsafe.AsPointer(ref Unsafe.AsRef(ref src)),
                Type: typeof(T));

            Enqueue(genericEvent, q.SdlTimestamps[i]);
        }
    }

    public ReadOnlySpan<GenericEvent> ConsumeAndGetSorted()
    {
        var pair = Consume();
        var valuesToSort = pair.Values.AsSpan(0, pair.Count);
        var sdlTimestamps = pair.SdlTimestamps.AsSpan(0, pair.Count);

        Span<FractionalTimestamp> sortKeys = stackalloc FractionalTimestamp[valuesToSort.Length];
        for (var i = 0; i < valuesToSort.Length; i++)
        {
            sortKeys[i] = SdlTimestampCalculator.ToTimestamp(sdlTimestamps[i], _basis);
        }

        sortKeys.Sort(valuesToSort, (timeA, timeB) => timeA.CompareTo(timeB));

        return valuesToSort;
    }


    // taking a pointer to this type is safe, as we're not using any

    private readonly ref struct Timing(long timestamp, ulong sdlTimestamp)
    {
        public readonly ulong SdlTimestamp = sdlTimestamp;
        public readonly long StopwatchTimestamp = timestamp;
    }

    public unsafe bool TryDequeue([NotNullWhen(true)] out void* value, out ulong timestamp)
    {
        if (Count == 0)
        {
            value = null;
            timestamp = 0;
            return false;
        }


        ref var valRef = ref GetPtr(--Count, out timestamp);
        value = Unsafe.AsPointer(ref valRef);
        return true;
    }
}

internal interface ISdlEventQueue<T> where T : struct
{
    public void Enqueue(in T item, ulong sdlTimestamp);
}

internal readonly record struct GenericEvent(nint EventPtr, Type Type)
{
    public unsafe T Value<T>() => Unsafe.AsRef<T>((void*)EventPtr);
}

internal interface ITimestampedEvent
{
    public long Timestamp { get; }
}
