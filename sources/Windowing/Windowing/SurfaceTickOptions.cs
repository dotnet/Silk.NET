/// <summary>
/// Contains properties pertaining to the regular execution of the <see cref="Surface.Tick" /> event.
/// </summary>
/// <param name="IsEventDriven">
/// Whether <see cref="Surface.Tick" /> should only execute in response to an event (of any kind) and/or
/// <see cref="Surface.Continue" /> if <c>true</c>; if <c>false</c> the event shall be raised as frequently as the
/// implementation/platform can handle.
/// </param>
public readonly record struct SurfaceTickOptions(bool IsEventDriven);
