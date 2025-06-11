namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IKeyboard"/>.
/// </summary>
public class KeyboardState
{
    /// <summary>
    /// Gets the text that has been typed since <see cref="IKeyboard.BeginInput"/> has been called. This will be cleared
    /// when <see cref="IKeyboard.EndInput"/> is called.
    /// </summary>
    public InputReadOnlyList<char>? Text { get; }

    /// <summary>
    /// Gets the key state, denoting which keys are pressed on the keyboard.
    /// </summary>
    public ButtonReadOnlyList<KeyName> Keys { get; }

    /// <summary>
    /// Gets the active modifier keys.
    /// </summary>
    public KeyModifiers Modifiers { get; }
}