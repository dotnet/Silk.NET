using Silk.NET.Maths;

/// <summary>
/// Contains properties pertaining to a change in the location and/or size of a display.
/// </summary>
/// <param name="Surface">The surface owning the display.</param>
/// <param name="Display">The display for which the location and/or size changed.</param>
/// <param name="OldBounds">The previous value of <see cref="IDisplay.Bounds" />.</param>
/// <param name="NewBounds">The new value of <see cref="IDisplay.Bounds" />.</param>
/// <param name="OldWorkArea">The previous value of <see cref="IDisplay.WorkArea" />.</param>
/// <param name="NewWorkArea">The new value of <see cref="IDisplay.WorkArea" />.</param>
public readonly record struct DisplayCoordinatesEvent(
    Surface Surface,
    IDisplay Display,
    Rectangle<float> OldBounds,
    Rectangle<float> NewBounds,
    Rectangle<float> OldWorkArea,
    Rectangle<float> NewWorkArea
);
