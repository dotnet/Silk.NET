// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

public partial class InputContext
    : IJoystickInputHandler,
        IGamepadInputHandler,
        IMouseInputHandler,
        IPointerInputHandler,
        IKeyboardInputHandler,
        IInputHandler<ConnectionEvent>,
        IList<IInputBackend>,
        IReadOnlyList<IInputBackend>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IInputHandler<ConnectionEvent>.Handle(ConnectionEvent e) => HandleDeviceConnectionChanged(e);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IInputHandler<PointerTargetChangedEvent>.Handle(PointerTargetChangedEvent @event) =>
        _pointers?.HandleTargetChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IInputHandler<PointChangedEvent>.Handle(PointChangedEvent @event) =>
        _pointers?.HandlePointChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IInputHandler<PointerGripChangedEvent>.Handle(PointerGripChangedEvent @event) =>
        _pointers?.HandleGripChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(ButtonChangedEvent<JoystickButton> @event) =>
        _joysticks?.HandleButtonChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IJoystickInputHandler.HandleAxisMove(JoystickAxisMoveEvent @event) =>
        _joysticks?.HandleAxisMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IJoystickInputHandler.HandleHatMove(JoystickHatMoveEvent @event) =>
        _joysticks?.HandleHatMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IGamepadInputHandler.HandleThumbstickMove(GamepadThumbstickMoveEvent @event) =>
        _gamepads?.HandleThumbstickMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IGamepadInputHandler.HandleTriggerMove(GamepadTriggerMoveEvent @event) =>
        _gamepads?.HandleTriggerMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IButtonInputHandler<PointerButton>.HandleButtonChanged(ButtonChangedEvent<PointerButton> @event) =>
        _pointers?.HandleButtonChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IMouseInputHandler.HandleScroll(MouseScrollEvent @event) =>
        _pointers?.HandleScroll(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IPointerInputHandler.HandleTargetChanged(PointerTargetChangedEvent @event) =>
        _pointers?.HandleTargetChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IPointerInputHandler.HandlePointChanged(PointChangedEvent @event) =>
        _pointers?.HandlePointChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IPointerInputHandler.HandleGripChanged(PointerGripChangedEvent @event) =>
        _pointers?.HandleGripChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IButtonInputHandler<KeyName>.HandleButtonChanged(ButtonChangedEvent<KeyName> @event) =>
        _keyboards?.HandleButtonChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IKeyboardInputHandler.HandleKeyChanged(KeyChangedEvent @event) =>
        _keyboards?.HandleKeyChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IKeyboardInputHandler.HandleKeyChar(KeyCharEvent @event) =>
        _keyboards?.HandleKeyChar(@event);

    void IInputHandler.HandleDeviceConnectionChanged(ConnectionEvent @event)
    {
        HandleDeviceConnectionChanged(@event);

        try
        {
            ConnectionChanged?.Invoke(@event);
        }
        catch (Exception e)
        {
            InputLog.Error(e.ToString());
        }
    }

    IEnumerator<IInputBackend> IEnumerable<IInputBackend>.GetEnumerator() =>
        _backends.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _backends.GetEnumerator();

    void ICollection<IInputBackend>.Add(IInputBackend item)
    {
        HandleBackendAddition(item);
        _backends.Add(item);
    }

    void ICollection<IInputBackend>.Clear()
    {
        foreach (var backend in Backends)
        {
            HandleBackendRemoval(backend);
        }

        _backends.Clear();
    }

    bool ICollection<IInputBackend>.Contains(IInputBackend item) => _backends.Contains(item);

    void ICollection<IInputBackend>.CopyTo(IInputBackend[] array, int arrayIndex) =>
        _backends.CopyTo(array, arrayIndex);

    bool ICollection<IInputBackend>.Remove(IInputBackend item)
    {
        HandleBackendRemoval(item);
        return _backends.Remove(item);
    }

    int ICollection<IInputBackend>.Count
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _backends.Count;
    }

    bool ICollection<IInputBackend>.IsReadOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    int IList<IInputBackend>.IndexOf(IInputBackend item) => _backends.IndexOf(item);

    void IList<IInputBackend>.Insert(int index, IInputBackend item)
    {
        HandleBackendAddition(item);
        _backends.Insert(index, item);
    }

    void IList<IInputBackend>.RemoveAt(int index)
    {
        var backend = _backends[index];
        HandleBackendRemoval(backend);
        _backends.RemoveAt(index);
    }

    IInputBackend IList<IInputBackend>.this[int index]
    {
        get => _backends[index];
        set
        {
            ArgumentNullException.ThrowIfNull(value);

            var existing = _backends[index];
            if (existing == value)
            {
                return;
            }

            HandleBackendRemoval(existing);
            HandleBackendAddition(value);
            _backends[index] = value;
        }
    }

    int IReadOnlyCollection<IInputBackend>.Count => _backends.Count;

    /// <summary>
    /// Returns the <see cref="IInputBackend"/> at the specified index.
    /// </summary>
    /// <param name="index"></param>
    public IInputBackend this[int index] => _backends[index];
}
