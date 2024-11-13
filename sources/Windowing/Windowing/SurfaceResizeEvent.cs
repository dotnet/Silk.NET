using System.Numerics;

/// <summary>
/// Contains properties pertaining to a resize event.
/// </summary>
/// <param name="Surface">The surface raising the resize event.</param>
/// <param name="OldSize">The previous size value.</param>
/// <param name="NewSize">The new size value.</param>
public readonly record struct SurfaceResizeEvent(Surface Surface, Vector2 OldSize, Vector2 NewSize);
