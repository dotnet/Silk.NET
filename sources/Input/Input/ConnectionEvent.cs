using System.Diagnostics;

namespace Silk.NET.Input;

/// <summary>
/// Contains information pertaining to a device connection or disconnection event.
/// </summary>
/// <param name="Device">The device that has disconnected or connected.</param>
/// <param name="Timestamp">
/// The timestamp (as retrieved from <see cref="Stopwatch.GetTimestamp"/>) at which the event occurred.
/// </param>
/// <param name="IsConnected">Whether the device has connected (<c>true</c>) or disconnected (<c>false</c>).</param>
public readonly record struct ConnectionEvent(IInputDevice Device, long Timestamp, bool IsConnected);