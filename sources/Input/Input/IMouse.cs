using System.Numerics;

namespace Silk.NET.Input;

/// <summary>
/// Represents a mouse - a type of pointer device.
/// </summary>
public interface IMouse : IPointerDevice
{
    /// <summary>
    /// Gets the device state.
    /// </summary>
    /// <remarks>
    /// Only updated when <see cref="IInputBackend.Update"/> is called.
    /// </remarks>
    new MouseState State { get; }

    PointerState IPointerDevice.State => State;

    /// <summary>
    /// Gets the cursor configuration of the mouse.
    /// </summary>
    /// <remarks>
    /// This will determine which <see cref="IPointerTarget"/> points shall lie on.
    /// </remarks>
    ICursorConfiguration Cursor { get; }

    /// <summary>
    /// Attempts to set the position of the mouse.
    /// </summary>
    /// <param name="position">The position of the mouse in window coordinates.</param>
    /// <returns>Whether the requested position has been applied.</returns>
    bool TrySetPosition(Vector2 position);
}