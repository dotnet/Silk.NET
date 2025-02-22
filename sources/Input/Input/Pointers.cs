namespace Silk.NET.Input;

/// <summary>
/// Represents a collection of <see cref="IPointerDevice"/>s from which input events can be received.
/// </summary>
public partial class Pointers : IReadOnlyList<IPointerDevice>
{
    /// <summary>
    /// Gets or sets the configuration that denotes the behaviour of <see cref="Click"/>/<see cref="DoubleClick"/>.
    /// </summary>
    public PointerClickConfiguration ClickConfiguration { get; set; }

    /// <summary>
    /// Raised when state pertaining to a pushable button on the pointer device changes (e.g. button up, button down).
    /// </summary>
    public event Action<ButtonChangedEvent<PointerButton>>? ButtonChanged;

    /// <summary>
    /// Raised when one or more <see cref="ButtonChanged"/> events indicate a single click as defined by the
    /// <see cref="ClickConfiguration"/>.
    /// </summary>
    public event Action<PointerClickEvent>? Click;

    /// <summary>
    /// Raised when one or more <see cref="ButtonChanged"/> events indicate a double click as defined by the
    /// <see cref="ClickConfiguration"/>.
    /// </summary>
    public event Action<PointerClickEvent>? DoubleClick;

    /// <summary>
    /// Raised when a <see cref="TargetPoint"/>'s state changes (e.g. mouse move).
    /// </summary>
    public event Action<PointChangedEvent>? PointChanged;

    /// <summary>
    /// Raised when a user scrolls using a pointer device's mouse wheel.
    /// </summary>
    public event Action<MouseScrollEvent>? MouseScroll;
}