/// <summary>
/// Contains properties pertaining to one or more files being dropped onto a window.
/// </summary>
/// <param name="Surface">The surface that owns the window to which the event pertains.</param>
/// <param name="Files">The paths of the files dropped onto the window.</param>
public readonly record struct WindowFileEvent(Surface Surface, IReadOnlyList<string> Files);
