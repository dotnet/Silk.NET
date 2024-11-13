/// <summary>
/// Contains properties pertaining to a boolean window property being toggled.
/// </summary>
/// <param name="Value">The new value.</param>
public readonly record struct WindowToggleEvent(Surface Surface, bool Value);
