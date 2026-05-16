using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input;

/// <summary>
/// Represents a keyboard device.
/// </summary>
public interface IKeyboard : IButtonDevice<KeyName>
{
    /// <summary>
    /// Gets the device state.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    new KeyboardState State { get; }

    ButtonReadOnlyList<KeyName> IButtonDevice<KeyName>.State => State.Keys;

    /// <summary>
    /// Gets or sets the current text on the clipboard.
    /// </summary>
    string? ClipboardText { get; set; }

    /// <summary>
    /// Attempts to get a user-displayable string in the user's locale for the key at the physical position represented
    /// by <paramref name="key"/> in the user's current keyboard layout.
    /// </summary>
    /// <param name="key">The physical key name. Consult <see cref="KeyName"/> documentation for more info.</param>
    /// <param name="name">The user-displayable name of the key.</param>
    /// <returns>Whether the name was successfully retrieved.</returns>
    bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name);

    /// <summary>
    /// Begins recording keyboard input. Without <see cref="BeginInput"/>/<see cref="EndInput"/>, there is no
    /// guarantee that <see cref="IKeyboardInputHandler.HandleKeyChar"/> will be raised as this might require displaying
    /// a concept/touchscreen keyboard on certain platforms (e.g. phones). It is recommended that you call
    /// <see cref="BeginInput"/> when you'd like to capture text input (e.g. in a text box), followed by
    /// <see cref="EndInput"/> when you have completed collecting such input.
    /// </summary>
    void BeginInput();

    /// <summary>
    /// Concludes recording keyboard input. Without <see cref="BeginInput"/>/<see cref="EndInput"/>, there is no
    /// guarantee that <see cref="IKeyboardInputHandler.HandleKeyChar"/> will be raised as this might require displaying
    /// a concept/touchscreen keyboard on certain platforms (e.g. phones). It is recommended that you call
    /// <see cref="BeginInput"/> when you'd like to capture text input (e.g. in a text box), followed by
    /// <see cref="EndInput"/> when you have completed collecting such input.
    /// </summary>
    string? EndInput();
}
