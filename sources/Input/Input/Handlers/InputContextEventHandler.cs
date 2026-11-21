// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Buffers;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

internal class InputContextEventHandler<T> where T : struct
{
    private readonly List<Action<T>> _handlers = [];
    private readonly Lock _lock = new();
    private ulong _handlerCountLive;

    public void Invoke(T item)
    {
        Action<T>[] handlers;
        int handlerCount;

        lock (_lock)
        {
            handlerCount = _handlers.Count;
            if (handlerCount == 0)
            {
                return;
            }

            // so we don't hold the lock while running user code.
            handlers = ArrayPool<Action<T>>.Shared.Rent(handlerCount);
            _handlers.CopyTo(handlers);
        }

        // We invoke each subscriber individually so that one misbehaving subscriber can't stop the others from
        // receiving the event.
        for (var index = 0; index < handlerCount; ++index)
        {
            var handler = handlers[index];
            try
            {
                handler.Invoke(item);
            }
            catch (Exception e)
            {
                InputLog.Error($"Exception in connection changed event `{handler}`: {e.Message}\n{e.StackTrace}");
            }
        }

        ArrayPool<Action<T>>.Shared.Return(handlers);
    }

    public void Add(Action<T>? handler)
    {
        if (handler is null)
        {
            return;
        }

        lock (_lock)
        {
            _handlers.Add(handler);
        }

        Interlocked.Increment(ref _handlerCountLive);
    }

    public bool Remove(Action<T>? handler)
    {
        if (handler is null)
        {
            return false;
        }

        bool removed;
        lock (_lock)
        {
            removed = _handlers.Remove(handler);
        }

        if (removed)
        {
            Interlocked.Decrement(ref _handlerCountLive);
        }

        return removed;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Any() => Interlocked.Read(ref _handlerCountLive) > 0;
}
