namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IKeyboard"/>s from which input events can be received.
/// </summary>
public sealed class Keyboards : InputContextDeviceList<IKeyboard>, IKeyboardInputHandler
{
    internal Keyboards(InputContext ctx)
        : base(ctx)
    {
    }

    /// <summary>
    /// Raised when state pertaining to a pushable key on the keyboard changes (e.g. key up, key down, key repeat).
    /// </summary>
    public event Action<KeyChangedEvent>? KeyChanged
    {
        add => _keyChangedEventHandler.Add(value);
        remove => _keyChangedEventHandler.Remove(value);
    }

    /// <summary>
    /// Raised when the user types a character using the keyboard.
    /// </summary>
    public event Action<KeyCharEvent>? KeyChar
    {
        add => _keyCharEventHandler.Add(value);
        remove => _keyCharEventHandler.Remove(value);
    }

    internal void HandleKeyChanged(KeyChangedEvent @event) => _keyChangedEventHandler.Invoke(@event);

    void IKeyboardInputHandler.HandleKeyChanged(KeyChangedEvent @event) => HandleKeyChanged(@event);

    internal void HandleKeyChar(KeyCharEvent @event) => _keyCharEventHandler.Invoke(@event);

    void IKeyboardInputHandler.HandleKeyChar(KeyCharEvent @event) => HandleKeyChar(@event);

    internal void HandleButtonChanged(ButtonChangedEvent<KeyName> @event) => _buttonChangedEventHandler.Invoke(@event);

    void IButtonInputHandler<KeyName>.HandleButtonChanged(ButtonChangedEvent<KeyName> @event) =>
        HandleButtonChanged(@event);

    private readonly InputContextEventHandler<KeyChangedEvent> _keyChangedEventHandler = new();
    private readonly InputContextEventHandler<KeyCharEvent> _keyCharEventHandler = new();
    private readonly InputContextEventHandler<ButtonChangedEvent<KeyName>> _buttonChangedEventHandler = new();
}
