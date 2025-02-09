namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a surface changing to a different display.
/// </summary>
/// <param name="Surface">The surface changing to a different display.</param>
/// <param name="Display">The display the surface has changed to.</param>
/// <remarks>
/// It is expected that this event shall be raised for each logically substantial change to the display parameters and
/// this can be defined by each individual platform. For instance, if the underlying platform does not give the
/// application access to any displays other than the one it's currently being displayed on, then it is expected that
/// this event shall be raised if the display changed even if this is represented by the same object. Old display
/// objects are not guaranteed to be valid or relevant after this event is raised.
/// </remarks>
public readonly record struct DisplayChangeEvent(Surface Surface, IDisplay Display);
