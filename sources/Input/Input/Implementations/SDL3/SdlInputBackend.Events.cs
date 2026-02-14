// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend
{
    internal class SilkEventQueues
    {
        public IEventQueue<ButtonChangedEvent<JoystickButton>> ButtonChangedEvents => _buttonChangedEvents;

        public IEventQueue<ConnectionEvent> ConnectionEvents => _connectionEvents;

        public IEventQueue<KeyChangedEvent> KeyChangedEvents => _keyChangedEvents;

        public IEventQueue<GamepadThumbstickMoveEvent> GamepadThumbstickMoveEvents => _gamepadThumbstickMoveEvents;

        public IEventQueue<GamepadTriggerMoveEvent> GamepadTriggerMoveEvents => _gamepadTriggerMoveEvents;

        public IEventQueue<JoystickAxisMoveEvent> JoystickAxisMoveEvents => _joystickAxisMoveEvents;

        public IEventQueue<JoystickHatMoveEvent> JoystickHatMoveEvents => _joystickHatMoveEvents;

        public IEventQueue<KeyCharEvent> KeyCharEvents => _keyCharEvents;

        public IEventQueue<MouseScrollEvent> MouseScrollEvents => _mouseScrollEvents;

        public IEventQueue<PointChangedEvent> PointChangedEvents => _pointChangedEvents;

        public IEventQueue<PointerClickEvent> PointerClickEvents => _pointerClickEvents;

        public IEventQueue<PointerGripChangedEvent> PointerGripChangedEvents => _pointerGripChangedEvents;

        public IEventQueue<PointerTargetChangedEvent> PointerTargetChangedEvents => _pointerTargetChangedEvents;

        private readonly OrderedEventQueue _orderedEvents = new();
        private readonly EventQueue<ButtonChangedEvent<JoystickButton>> _buttonChangedEvents = new();
        private readonly EventQueue<ConnectionEvent> _connectionEvents = new();
        private readonly EventQueue<KeyChangedEvent> _keyChangedEvents = new();
        private readonly EventQueue<GamepadThumbstickMoveEvent> _gamepadThumbstickMoveEvents = new();
        private readonly EventQueue<GamepadTriggerMoveEvent> _gamepadTriggerMoveEvents = new();
        private readonly EventQueue<JoystickAxisMoveEvent> _joystickAxisMoveEvents = new();
        private readonly EventQueue<JoystickHatMoveEvent> _joystickHatMoveEvents = new();
        private readonly EventQueue<KeyCharEvent> _keyCharEvents = new();
        private readonly EventQueue<MouseScrollEvent> _mouseScrollEvents = new();
        private readonly EventQueue<PointChangedEvent> _pointChangedEvents = new();
        private readonly EventQueue<PointerClickEvent> _pointerClickEvents = new();
        private readonly EventQueue<PointerGripChangedEvent> _pointerGripChangedEvents = new();
        private readonly EventQueue<PointerTargetChangedEvent> _pointerTargetChangedEvents = new();

        public void RaiseEvents(params Span<IInputHandler> handlers)
        {
            _orderedEvents.Enqueue(_buttonChangedEvents);
            _orderedEvents.Enqueue(_connectionEvents);
            _orderedEvents.Enqueue(_keyChangedEvents);
            _orderedEvents.Enqueue(_gamepadThumbstickMoveEvents);
            _orderedEvents.Enqueue(_gamepadTriggerMoveEvents);
            _orderedEvents.Enqueue(_joystickAxisMoveEvents);
            _orderedEvents.Enqueue(_joystickHatMoveEvents);
            _orderedEvents.Enqueue(_keyCharEvents);
            _orderedEvents.Enqueue(_mouseScrollEvents);
            _orderedEvents.Enqueue(_pointChangedEvents);
            _orderedEvents.Enqueue(_pointerClickEvents);
            _orderedEvents.Enqueue(_pointerGripChangedEvents);
            _orderedEvents.Enqueue(_pointerTargetChangedEvents);
            _orderedEvents.SortDescending();

            if (handlers is { Length: > 0 })
            {
                while (_orderedEvents.TryDequeue(out var evt))
                {
                    switch (evt.Value)
                    {
                        case var genericEvt when genericEvt.Type == typeof(ButtonChangedEvent<JoystickButton>):
                        {
                            RaiseEvent(handlers, genericEvt.Value<ButtonChangedEvent<JoystickButton>>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(ConnectionEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<ConnectionEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(KeyChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<KeyChangedEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(GamepadThumbstickMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<GamepadThumbstickMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(GamepadTriggerMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<GamepadTriggerMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(JoystickAxisMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<JoystickAxisMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(JoystickHatMoveEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<JoystickHatMoveEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(KeyCharEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<KeyCharEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(MouseScrollEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<MouseScrollEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointChangedEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointerClickEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointerClickEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointerGripChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointerGripChangedEvent>());
                            break;
                        }
                        case var genericEvt when genericEvt.Type == typeof(PointerTargetChangedEvent):
                        {
                            RaiseEvent(handlers, genericEvt.Value<PointerTargetChangedEvent>());
                            break;
                        }
                        default:
                        {
                            throw new InvalidOperationException(nameof(evt.Value.Type));
                        }
                    }
                }
            }


            _buttonChangedEvents.Clear();
            _connectionEvents.Clear();
            _keyChangedEvents.Clear();
            _gamepadThumbstickMoveEvents.Clear();
            _gamepadTriggerMoveEvents.Clear();
            _joystickAxisMoveEvents.Clear();
            _joystickHatMoveEvents.Clear();
            _keyCharEvents.Clear();
            _mouseScrollEvents.Clear();
            _pointChangedEvents.Clear();
            _pointerClickEvents.Clear();
            _pointerGripChangedEvents.Clear();
            _pointerTargetChangedEvents.Clear();
        }

        private static void RaiseEvent<TItem>(Span<IInputHandler> handlers, in TItem evt)
            where TItem : struct, ITimestampedEvent
        {
            for (var index = 0; index < handlers.Length; index++)
            {
                var handler = handlers[index];
                if (handler is IInputHandler<TItem> inputHandler)
                {
                    inputHandler.Handle(evt);
                }
            }
        }
    }
}

internal interface IEventQueue<T> where T : struct, ITimestampedEvent
{
    public void Enqueue(in T item);
}

internal readonly record struct GenericEvent(nint EventPtr, long Timestamp, Type Type) : ITimestampedEvent
{
    public unsafe T Value<T>() => Unsafe.AsRef<T>((void*)EventPtr);

    public static GenericEvent Create<T>([ReadOnly(true)] ref T evt, long timestamp) where T : struct
    {
        unsafe
        {
            return new GenericEvent((nint)Unsafe.AsPointer(ref evt), timestamp, typeof(T));
        }
    }
}

internal interface ITimestampedEvent
{
    public long Timestamp { get; }
}

internal sealed class OrderedEventQueue : EventQueue<GenericEvent>
{
    public void Enqueue<T>(in EventQueue<T> queue) where T : struct, ITimestampedEvent
    {
        for (var i = 0; i < queue.Count; ++i)
        {
            Enqueue(queue.AsGenericEvent(i));
        }
    }

    public void Sort()
    {
        var span = Events.AsSpan(0, Count);
        span.Sort((x, y) => x.Timestamp.CompareTo(y.Timestamp));
    }

    public void SortDescending()
    {
        var span = Events.AsSpan(0, Count);
        span.Sort((x, y) => y.Timestamp.CompareTo(x.Timestamp));
    }
}

internal unsafe class EventQueue<T> : IEventQueue<T> where T : struct, ITimestampedEvent
{
    protected T[] Events { get; private set; } = [];
    public int Count { get; private set; }

    public nint this[int index] => (nint)Unsafe.AsPointer(ref Events[index]);

    public GenericEvent AsGenericEvent(int index)
    {
        ref var evt = ref Events[index];
        return new GenericEvent((nint)Unsafe.AsPointer(ref evt), evt.Timestamp, typeof(T));
    }

    public void Enqueue(in T item)
    {
        if (Events.Length == Count)
        {
            var newEvts = GC.AllocateArray<T>(length: Events.Length == 0 ? 16 : Events.Length * 2, pinned: true);
            Events.CopyTo(newEvts, 0);
            Events = newEvts;
            Debug.Assert(Events.Length > Count);
        }

        Events[Count++] = item;
    }

    public bool TryDequeue([NotNullWhen(true)] out T? value)
    {
        if (Count == 0)
        {
            value = null;
            return false;
        }

        value = Events[--Count];
        return true;
    }

    public void Clear()
    {
        Events.AsSpan().Clear();
        Count = 0;
    }
}
