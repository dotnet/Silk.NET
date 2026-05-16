namespace Silk.NET.Input;

/// <summary>
/// An <see cref="IInputHandler"/> that also receives <see cref="IButtonDevice{T}"/> events.
/// </summary>
/// <typeparam name="T">The device's button type.</typeparam>
public interface IButtonInputHandler<T> : IInputHandler<ButtonChangedEvent<T>>
    where T : unmanaged, Enum
{
    /// <summary>
    /// Called when a button's state changes (e.g. button down, button up).
    /// </summary>
    /// <param name="event">The event details.</param>
    void HandleButtonChanged(ButtonChangedEvent<T> @event);

    void IInputHandler<ButtonChangedEvent<T>>.Handle(ButtonChangedEvent<T> @event) => HandleButtonChanged(@event);
}

public interface IInputHandler<in T> : IInputHandler where T : struct
{
    void Handle(T @event);
}
