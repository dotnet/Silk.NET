namespace Silk.NET.Input;

/// <summary>
/// Represents a button the user can push.
/// </summary>
/// <param name="Name">The name of the button.</param>
/// <param name="IsDown">Whether the user is pushing the button.</param>
/// <param name="Pressure">
/// The pressure with which the user is pushing the button, where <c>0.0</c> is the smallest measurable pressure and
/// <c>1.0</c> is the largest measurable pressure.
/// </param>
/// <typeparam name="T">
/// The button type (e.g. <see cref="JoystickButton"/>, <see cref="PointerButton"/>, etc).
/// </typeparam>
public readonly record struct Button<T>(T Name, bool IsDown, float Pressure)
    where T : unmanaged, Enum
{
    /// <summary>
    /// Collapses this <see cref="Button{T}"/> struct into just its <see cref="IsDown"/> value.
    /// </summary>
    /// <param name="state">The button state.</param>
    /// <returns>The <see cref="IsDown"/> value.</returns>
    public static implicit operator bool(Button<T> state) => state.IsDown;
}
