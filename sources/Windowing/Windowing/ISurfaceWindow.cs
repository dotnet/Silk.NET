namespace Silk.NET.Windowing;

using System.Numerics;
using Silk.NET.Maths;

/// <summary>
/// Represents a window in which a surface is rendering.
/// </summary>
public interface ISurfaceWindow
{
    /// <summary>
    /// Gets the window bounds including the window border.
    /// </summary>
    Rectangle<float> Bounds { get; set; }

    /// <summary>
    /// Forwards to the <see cref="System.Drawing.Size" /> component of <see cref="Bounds" />.
    /// </summary>
    // DIM is required, but this implementation is for illustrative purposes only! Exact resize semantics of silk types
    // are yet to be defined.
    Vector2 Size
    {
        get => (Vector2)Bounds.Size;
        set => Bounds = Bounds with { Size = new Vector2D<float>(value.X, value.Y) };
    }

    /// <summary>
    /// Forwards to the <see cref="Rectangle{T}.Origin" /> component of <see cref="Bounds" />.
    /// </summary>
    // DIM is required, but this implementation is for illustrative purposes only! Exact resize semantics of silk types
    // are yet to be defined.
    Vector2 Position
    {
        get => (Vector2)Bounds.Origin;
        set => Bounds = Bounds with { Size = new Vector2D<float>(value.X, value.Y) };
    }

    /// <summary>
    /// Gets only the inner client area of the window in <b>screen coordinates</b>. For <i>pixels</i>, use
    /// <see cref="Surface.DrawableSize" /> or the relevant properties of <see cref="Surface.Scale" />.
    /// </summary>
    /// <remarks>
    /// Setting this property is interpreted to mean changing <see cref="Bounds" /> by the same delta in the hopes of
    /// achieving the desired result.
    /// </remarks>
    Rectangle<float> ClientArea { get; set; }

    /// <summary>
    /// Forwards to the <see cref="Rectangle{T}.Size" /> component of <see cref="ClientArea" />.
    /// </summary>
    /// <remarks>
    /// Setting this property is interpreted to mean changing <see cref="Size" /> by the same delta in the hopes of
    /// achieving the desired result.
    /// </remarks>
    Vector2 ClientSize
    {
        get => (Vector2)ClientArea.Size;
        set => ClientArea = ClientArea with { Size = new(value.X, value.Y) };
    }

    /// <summary>
    /// Raised when <see cref="Bounds" /> and/or <see cref="ClientArea" /> changes.
    /// </summary>
    event Action<WindowCoordinatesEvent>? CoordinatesChanged;

    /// <summary>
    /// Gets or sets a value indicating whether, unless set to <c>false</c> before the next <see cref="Surface.Tick" />,
    /// the window will close resulting in the irrevocable termination of the surface.
    /// </summary>
    bool IsCloseRequested { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the window is visible.
    /// </summary>
    bool IsVisible { get; set; }

    /// <summary>
    /// Raised when <see cref="IsCloseRequested" /> is set to <c>true</c>.
    /// </summary>
    event Action<WindowToggleEvent>? CloseRequested;

    /// <summary>
    /// Gets or sets a value indicating whether the window currently has input focus. If setting to <c>true</c>, the
    /// window will likely be raised atop other windows in order to obtain input focus. Setting to <c>false</c> is not
    /// guaranteed to do anything.
    /// </summary>
    bool IsFocused { get; set; }

    /// <summary>
    /// An event raised when <see cref="IsFocused" /> changes.
    /// </summary>
    event Action<WindowToggleEvent>? FocusChanged;

    /// <summary>
    /// Gets or sets a title for the window.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Gets or sets the state of the window within the context of the window manager. This setting can be changed by
    /// the user through actions (e.g. the minimise button, maximise, etc).
    /// </summary>
    WindowState State { get; set; }

    /// <summary>
    /// An event raised when <see cref="State" /> changes.
    /// </summary>
    event Action<WindowStateEvent>? StateChanged;

    /// <summary>
    /// Gets or sets the style of the window border around the client area.
    /// </summary>
    WindowBorder Border { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this window shall be drawn atop all other windows in the window manager.
    /// </summary>
    bool IsTopMost { get; set; }

    /// <summary>
    /// An event raised when the user drops files onto the window.
    /// </summary>
    event Action<WindowFileEvent>? FileDrop;

    /// <summary>
    /// Sets the window's icon to one of the window icons provided. The icon is selected using an undefined mechanism by
    /// the underlying platform, typically taking into account the pixel size of each variant. If no icon variants are
    /// provided, then the default icon shall be restored.
    /// </summary>
    /// <param name="icon">The window icon variants to set.</param>
    /// <returns>A value indicating whether the operation was successful.</returns>
    bool TrySetIcon(WindowIconVariants icon);
}
