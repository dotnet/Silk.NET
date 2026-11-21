using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IJoystick"/>s from which input events can be received.
/// </summary>
public sealed class Joysticks : InputContextDeviceList<IJoystick>, IJoystickInputHandler
{
    internal Joysticks(InputContext ctx)
        : base(ctx) { }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the joystick changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<JoystickButton>>? ButtonChanged
    {
        add => _buttonChangedEventHandler.Add(value);
        remove => _buttonChangedEventHandler.Remove(value);
    }

    /// <summary>
    /// Raised when a movable axis on the joystick changes position.
    /// </summary>
    public event Action<JoystickAxisMoveEvent>? AxisMove
    {
        add => _axisMoveEventHandler.Add(value);
        remove => _axisMoveEventHandler.Remove(value);
    }

    /// <summary>
    /// Raised when a joystick hat moves.
    /// </summary>
    public event Action<JoystickHatMoveEvent>? HatMove
    {
        add => _hatMoveEventHandler.Add(value);
        remove => _hatMoveEventHandler.Remove(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void HandleButtonChanged(ButtonChangedEvent<JoystickButton> @event)
    {
        if (@event.Device is IJoystick)
        {
            _buttonChangedEventHandler.Invoke(@event);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IButtonInputHandler<JoystickButton>.HandleButtonChanged(
        ButtonChangedEvent<JoystickButton> @event
    ) => HandleButtonChanged(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void HandleAxisMove(JoystickAxisMoveEvent @event) => _axisMoveEventHandler.Invoke(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IJoystickInputHandler.HandleAxisMove(JoystickAxisMoveEvent @event) =>
        HandleAxisMove(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void HandleHatMove(JoystickHatMoveEvent @event) => _hatMoveEventHandler.Invoke(@event);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IJoystickInputHandler.HandleHatMove(JoystickHatMoveEvent @event) => HandleHatMove(@event);

    private readonly InputContextEventHandler<ButtonChangedEvent<JoystickButton>> _buttonChangedEventHandler = new();
    private readonly InputContextEventHandler<JoystickAxisMoveEvent> _axisMoveEventHandler = new();
    private readonly InputContextEventHandler<JoystickHatMoveEvent> _hatMoveEventHandler = new();
}
