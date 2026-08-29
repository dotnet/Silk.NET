// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3.DataStructures;

internal sealed class GenericEventQueueSdl : SdlInputEventQueue<GenericEvent>
{
    private readonly SdlTimestampCalculator.TimeBasis _basis;
    public GenericEventQueueSdl(SdlTimestampCalculator.TimeBasis basis) => _basis = basis;

    /// <summary>
    /// Populates this instance's buffer with events from another <see cref="SdlInputEventQueue{T}"/> <see cref="queueSdl"/>
    /// of any kind by calling <see cref="SdlInputEventQueue{T}.ConsumeWithoutClearing"/> on it.<br/><br/>
    ///
    /// It is <b>imperative</b> that you do not allow any writes to the provided <see cref="SdlInputEventQueue{T}"/>
    /// until you are done processing the sorted data returned by <see cref="ConsumeAndSortSelf"/>. Changes to the
    /// provided <see cref="SdlInputEventQueue{T}"/> will invalidate the data this class stores and can lead to confusing
    /// bugs, or even memory access violations.<br/><br/>
    /// </summary>
    /// <param name="queueSdl">The queue whose data to reference</param>
    /// <param name="consume">If true (default), <see cref="queueSdl"/> will be "consumed" -
    /// the equivalent of calling <see cref="List{T}.Clear()"/></param>
    /// <typeparam name="T"></typeparam>
    public unsafe void StoreReferencesTo<T>(in SdlInputEventQueue<T> queueSdl, bool consume = true) where T : struct
    {
        var q = consume ? queueSdl.ConsumeWithoutClearing() : queueSdl.AsSpanPair();
        var values = q.Values;
        var timestamps = q.SdlTimestamps;
        for (var i = 0; i < q.Length; i++)
        {
            var genericEvent = new GenericEvent(
                EventPtr: values.PointerAt(i),
                Type: typeof(T));

            Enqueue(genericEvent, timestamps.Ptr[i]);
        }
    }

    /// <summary>
    /// This method is the final method that should be called to consume our events in-order.
    /// After this is call, our memory will appear unused, so any additional writes will overwrite data in the
    /// returned span.<br/><br/>
    /// Therefore, it is <b>imperative</b> that you do not allow any writes to this
    /// <see cref="GenericEventQueueSdl"/> until you are done processing the sorted data.
    /// consuming.<br/><br/>
    /// </summary>
    /// <returns></returns>
    public unsafe NativeMemory<GenericEvent>.UnsafeView ConsumeAndSortSelf()
    {
        var pair = ConsumeWithoutClearing();
        var valuesToSort = pair.Values;
        var sdlTimestamps = pair.SdlTimestamps;

        var length = valuesToSort.Length;
        var heap = length > 512 ? ArrayPool<FractionalTimestamp>.Shared.Rent(length) : null;
        var sortKeys = heap ?? stackalloc FractionalTimestamp[length];
        for (var i = 0; i < length; i++)
        {
            sortKeys[i] = SdlTimestampCalculator.ToTimestamp(sdlTimestamps.Ptr[i], _basis);
        }

        sortKeys.StableSortWith(valuesToSort, _timestampComparer);

        if (heap is not null)
        {
            ArrayPool<FractionalTimestamp>.Shared.Return(heap);
        }

        return valuesToSort;
    }

    private static readonly Comparison<FractionalTimestamp> _timestampComparer = (timeA, timeB) => timeA.CompareTo(timeB);
}
