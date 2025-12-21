using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to a character being typed on a keyboard.
/// </summary>
/// <param name="Keyboard">The keyboard with which the end user typed a character.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="Character">The character that was typed. A <c>null</c> character denotes a backspace.</param>
public readonly record struct KeyCharEvent(IKeyboard Keyboard, long Timestamp, char? Character);