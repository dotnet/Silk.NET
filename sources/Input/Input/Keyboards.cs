namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IKeyboard"/>s from which input events can be received.
/// </summary>
public sealed class Keyboards : InputContextDeviceList<IKeyboard>, IKeyboardInputHandler
{
    internal Keyboards(InputContext ctx)
        : base(ctx) { }

    /// <summary>
    /// Raised when state pertaining to a pushable key on the keyboard changes (e.g. key up, key down, key repeat).
    /// </summary>
    public event Action<KeyChangedEvent>? KeyChanged;

    /// <summary>
    /// Raised when the user types a character using the keyboard.
    /// </summary>
    public event Action<KeyCharEvent>? KeyChar;

    internal void HandleButtonChanged(ButtonChangedEvent<KeyName> @event) { }

    void IButtonInputHandler<KeyName>.HandleButtonChanged(ButtonChangedEvent<KeyName> @event) =>
        HandleButtonChanged(@event);

    internal void HandleKeyChanged(KeyChangedEvent @event) => KeyChanged?.Invoke(@event);

    void IKeyboardInputHandler.HandleKeyChanged(KeyChangedEvent @event) => HandleKeyChanged(@event);

    internal void HandleKeyChar(KeyCharEvent @event) => KeyChar?.Invoke(@event);

    void IKeyboardInputHandler.HandleKeyChar(KeyCharEvent @event) => HandleKeyChar(@event);
}
