// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.Input.SDL3.Devices.Pointers;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A class used to collect all of the input events from all of our input devices and execute them in the order
/// in which they occurred, to the best of our ability.
/// <br/><br/>
/// To use this class, create an instance of it and share its various event queues with SDL event producers
/// </summary>
internal sealed class SdlInputEventContext : IDisposable
{
    public SdlInputEventQueue<ButtonChangedEvent<JoystickButton>> JoyButtonChangedEvents { get; } = new();
    public SdlInputEventQueue<ConnectionEvent> ConnectionEvents { get; } = new();
    public SdlInputEventQueue<KeyChangedEvent> KeyChangedEvents { get; } = new();
    public SdlInputEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveEvents { get; } = new();
    public SdlInputEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveEvents { get; } = new();
    public SdlInputEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveEvents { get; } = new();
    public SdlInputEventQueue<JoystickHatMoveEvent> JoystickHatMoveEvents { get; } = new();
    public SdlInputEventQueue<KeyCharEvent> KeyCharEvents { get; } = new();
    public SdlInputEventQueue<MouseScrollEvent> MouseScrollEvents { get; } = new();
    public SdlInputEventQueue<PointChangedEvent> PointChangedEvents { get; } = new();
    public SdlInputEventQueue<PointerClickEvent> PointerClickEvents { get; } = new();
    public SdlInputEventQueue<PointerGripChangedEvent> PointerGripChangedEvents { get; } = new();
    public SdlInputEventQueue<PointerTargetChangedEvent> PointerTargetChangedEvents { get; } = new();
    public SdlInputEventQueue<ButtonChangedEvent<PointerButton>> PointerButtonEvents { get; } = new();

    private readonly GenericEventQueueSdl _orderedSdlEvents;

    public SdlInputEventContext(SdlTimestampCalculator.TimeBasis basis) =>
        _orderedSdlEvents = new GenericEventQueueSdl(basis);

    public void RaiseEvents(params Span<IInputHandler> handlers)
    {
        _orderedSdlEvents.LoadAndReset(JoyButtonChangedEvents);
        _orderedSdlEvents.LoadAndReset(ConnectionEvents);
        _orderedSdlEvents.LoadAndReset(KeyChangedEvents);
        _orderedSdlEvents.LoadAndReset(GamepadThumbstickMoveEvents);
        _orderedSdlEvents.LoadAndReset(GamepadTriggerMoveEvents);
        _orderedSdlEvents.LoadAndReset(JoystickAxisMoveEvents);
        _orderedSdlEvents.LoadAndReset(JoystickHatMoveEvents);
        _orderedSdlEvents.LoadAndReset(KeyCharEvents);
        _orderedSdlEvents.LoadAndReset(MouseScrollEvents);
        _orderedSdlEvents.LoadAndReset(PointChangedEvents);
        _orderedSdlEvents.LoadAndReset(PointerClickEvents);
        _orderedSdlEvents.LoadAndReset(PointerGripChangedEvents);
        _orderedSdlEvents.LoadAndReset(PointerTargetChangedEvents);
        _orderedSdlEvents.LoadAndReset(PointerButtonEvents);


        if (handlers is { Length: > 0 })
        {
            try
            {
                var genericEvents = _orderedSdlEvents.Sorted();

                for (var index = 0; index < genericEvents.Length; index++)
                {
                    ref readonly var evt = ref genericEvents[index];
                    switch (evt.Type)
                    {
                        case SdlEventDiscriminator.PointChanged:
                            RaiseEvent(in handlers, in evt.Value<PointChangedEvent>());
                            break;

                        case SdlEventDiscriminator.PointerClick:
                            RaiseEvent(in handlers, in evt.Value<PointerClickEvent>());
                            break;

                        case SdlEventDiscriminator.PointerButtonChanged:
                            RaiseEvent(in handlers, in evt.Value<ButtonChangedEvent<PointerButton>>());
                            break;

                        case SdlEventDiscriminator.PointerGripChanged:
                            RaiseEvent(in handlers, in evt.Value<PointerGripChangedEvent>());
                            break;

                        case SdlEventDiscriminator.PointerTargetChanged:
                            RaiseEvent(in handlers, in evt.Value<PointerTargetChangedEvent>());
                            break;

                        case SdlEventDiscriminator.JoystickButtonChanged:
                            RaiseEvent(in handlers, in evt.Value<ButtonChangedEvent<JoystickButton>>());
                            break;

                        case SdlEventDiscriminator.KeyButtonChanged:
                            RaiseEvent(in handlers, in evt.Value<ButtonChangedEvent<KeyName>>());
                            break;

                        case SdlEventDiscriminator.KeyChanged:
                            RaiseEvent(in handlers, in evt.Value<KeyChangedEvent>());
                            break;

                        case SdlEventDiscriminator.GamepadThumbstickMove:
                            RaiseEvent(in handlers, in evt.Value<GamepadThumbstickMoveEvent>());
                            break;

                        case SdlEventDiscriminator.GamepadTriggerMove:
                            RaiseEvent(in handlers, in evt.Value<GamepadTriggerMoveEvent>());
                            break;

                        case SdlEventDiscriminator.JoystickAxisMove:
                            RaiseEvent(in handlers, in evt.Value<JoystickAxisMoveEvent>());
                            break;

                        case SdlEventDiscriminator.JoystickHatMove:
                            RaiseEvent(in handlers, in evt.Value<JoystickHatMoveEvent>());
                            break;

                        case SdlEventDiscriminator.KeyChar:
                            RaiseEvent(in handlers, in evt.Value<KeyCharEvent>());
                            break;

                        case SdlEventDiscriminator.MouseScroll:
                            RaiseEvent(in handlers, in evt.Value<MouseScrollEvent>());
                            break;

                        case SdlEventDiscriminator.Connection:
                        {
                            var value = evt.Value<ConnectionEvent>();
                            for (var i = 0; i < handlers.Length; ++i)
                            {
                                handlers[i].HandleDeviceConnectionChanged(value);
                            }

                            break;
                        }

                        default:
                            throw new InvalidOperationException("Invalid type: " + evt.Type);
                    }
                }
            }
            catch (Exception e)
            {
                InputLog.Error(e.ToString());
            }
        }

        _orderedSdlEvents.Clear();

        return;

        static void RaiseEvent<TItem>(ref readonly Span<IInputHandler> handlers, ref readonly TItem evt) where TItem : struct
        {
            for (var index = 0; index < handlers.Length; ++index)
            {
                if (handlers[index] is IInputHandler<TItem> appropriateHandler)
                {
                    appropriateHandler.Handle(evt);
                }
#if DEBUG
                else
                {
                    InputLog.Debug($"Unhandled event type {typeof(TItem).Name} from {handlers[index].GetType().Name}.");
                }
#endif
            }
        }
    }


    public void Dispose()
    {
        JoyButtonChangedEvents.Dispose();
        ConnectionEvents.Dispose();
        KeyChangedEvents.Dispose();
        GamepadThumbstickMoveEvents.Dispose();
        GamepadTriggerMoveEvents.Dispose();
        JoystickAxisMoveEvents.Dispose();
        JoystickHatMoveEvents.Dispose();
        KeyCharEvents.Dispose();
        MouseScrollEvents.Dispose();
        PointChangedEvents.Dispose();
        PointerClickEvents.Dispose();
        PointerButtonEvents.Dispose();
        PointerGripChangedEvents.Dispose();
        PointerTargetChangedEvents.Dispose();
        _orderedSdlEvents.Clear();
    }


    private sealed class GenericEventQueueSdl
    {
        private readonly SdlTimestampCalculator.TimeBasis _basis;
        private readonly List<GenericEvent> _events = [];
        public GenericEventQueueSdl(SdlTimestampCalculator.TimeBasis basis) => _basis = basis;

        public void LoadAndReset<T>(in SdlInputEventQueue<T> queueSdl) where T : struct
        {
            var sdlTimestamps = queueSdl.SdlTimestamps;
            for (var i = 0; i < queueSdl.Count; i++)
            {
                var genericEvent = new GenericEvent(
                    Queue: queueSdl,
                    Index: i,
                    Type: SdlInputEventQueue<T>.TypeDiscriminator,
                    Timestamp: SdlTimestampCalculator.ToTimestamp(sdlTimestamps[i], _basis));

                _events.Add(genericEvent);
            }

            queueSdl.ResetCount();
        }

        public Span<GenericEvent> Sorted()
        {
            var valuesToSort = CollectionsMarshal.AsSpan(_events);
            valuesToSort.StableSort(_timestampComparer);
            return valuesToSort;
        }

        private static readonly Comparison<GenericEvent> _timestampComparer =
            (timeA, timeB) => timeA.Timestamp.CompareTo(timeB.Timestamp);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear() => _events.Clear();


        internal readonly record struct GenericEvent(object Queue, int Index, SdlEventDiscriminator Type, FractionalTimestamp Timestamp)
        {
            public ref readonly T Value<T>() where T : struct
            {
                var queue = (SdlInputEventQueue<T>)Queue;
                return ref queue.UnsafeGetRef(Index);
            }
        }
    }
}
