namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IPointerDevice"/> events.
/// </summary>
public interface IPointerInputHandler : IButtonInputHandler<PointerButton>
{
    /// <summary>
    /// Called when the properties of a target at which the user can point using the pointer change. This includes the
    /// addition and removal of targets.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleTargetChanged(PointerTargetChangedEvent @event);

    /// <summary>
    /// Called when the user adds, removes, or changes a point at which they're pointing at a target.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandlePointChanged(PointChangedEvent @event);

    /// <summary>
    /// Called when the user changes the pressure with which they're gripping the pointer device.
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleGripChanged(PointerGripChangedEvent @event);
}