namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IKeyboard"/>s from which input events can be received.
/// </summary>
public partial class Keyboards : IReadOnlyList<IKeyboard>
{
    /// <summary>
    /// Raised when state pertaining to a pushable key on the keyboard changes (e.g. key up, key down, key repeat).
    /// </summary>
    public event Action<KeyChangedEvent>? KeyChanged;

    /// <summary>
    /// Raised when the user types a character using the keyboard.
    /// </summary>
    public event Action<KeyCharEvent>? KeyChar;
}