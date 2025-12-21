using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to a key press state change.
/// </summary>
/// <param name="Keyboard">The keyboard on which the key being pressed or depressed resides.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Key">The new state of the key being pressed or depressed.</param>
/// <param name="Previous">The previous state of the key.</param>
/// <param name="IsRepeat">Whether this is an event that has been repeated at an implementation-defined rate.</param>
/// <param name="Modifiers">The active key modifiers at the time the event was raised.</param>
public readonly record struct KeyChangedEvent(IKeyboard Keyboard, long Timestamp, Button<KeyName> Key, Button<KeyName> Previous, bool IsRepeat, KeyModifiers Modifiers);