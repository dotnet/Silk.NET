namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that receives input from an <see cref="IMouse"/>.
/// </summary>
public interface IMouseInputHandler : IButtonInputHandler<PointerButton>
{
    /// <summary>
    /// Called when the user scrolls using the scroll wheel.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleScroll(MouseScrollEvent @event);
}