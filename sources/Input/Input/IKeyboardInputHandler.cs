namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IKeyboard"/> events.
/// </summary>
public interface IKeyboardInputHandler : IButtonInputHandler<KeyName>
{
    /// <summary>
    /// Called when a key is pressed or depressed.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleKeyChanged(KeyChangedEvent @event);

    /// <summary>
    /// Called when a character is typed.
    /// </summary>
    /// <remarks>
    /// Ensure you have called <see cref="IKeyboard.BeginInput"/> to start receiving text, after which events will be
    /// sent for each character until <see cref="IKeyboard.EndInput"/> is called.
    /// </remarks>
    /// <param name="event">The event details.</param>
    void HandleKeyChar(KeyCharEvent @event);
}