namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a display being connected or disconnected.
/// </summary>
/// <param name="Surface">The surface for which display(s) were connected.</param>
/// <remarks>
/// Old display objects are not guaranteed to be valid or relevant after this event is raised.
/// </remarks>
// Currently this event does not include the displays that were connected or disconnected. This is primarily because
// there's no clean way to expose such "diffs" from an API perspective (as disconnected IDisplay objects are likely to
// be invalid), and also why would we need to? If a use case arises and this can be implemented in a sound way, let's
// evaluate that then.
public readonly record struct DisplayAvailabilityChangeEvent(Surface Surface);
