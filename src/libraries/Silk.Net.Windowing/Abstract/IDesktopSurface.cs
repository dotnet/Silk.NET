using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// A surface which wraps a Desktop Window.
    /// </summary>
    public interface IDesktopSurface : ISurface
    {
        /// <summary>
        /// Whether or not the window is visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// The position of the window. If set to -1, use the backend default.
        /// </summary>
        Vector2D<int> Position { get; set; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        new Vector2D<int> Size { get; set; }

        /// <summary>
        /// The window title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The window state.
        /// </summary>
        WindowState WindowState { get; set; }

        /// <summary>
        /// The window border.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// The video mode.
        /// </summary>
        VideoMode VideoMode { get; set; }
    
        /// <summary>
        /// Gets the screen on which this window is active.
        /// </summary>
        IScreen? CurrentScreen { get; set; }

        /// <summary>
        /// Gets the available screens for this surface.
        /// </summary>
        IEnumerable<IScreen>? AvailableScreens { get; }

        /// <summary>
        /// Gets or sets whether the window waits for an event to be posted before existing <see cref="DoEvents" />.
        /// </summary>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// Gets or sets whether the window has been requested to close.
        /// </summary>
        bool IsCloseRequested { get; set; }

        /// <summary>
        /// Gets whether the window is focused or not.
        /// </summary>
        bool IsFocused { get; }

        /// <summary>
        /// Gets the distances in screen coordinates from the edges of the content area to the corresponding edges of
        /// the full window.
        /// </summary>
        /// <remarks>
        /// Because these are distances and not coordinates, they are always zero or positive.
        /// </remarks>
        /// <seealso cref="WindowExtensions.GetFullSize"/>
        Rectangle<int> BorderSize { get; }
        
        /// <summary>
        /// Raised when the window has been requested to close.
        /// </summary>
        event Action CloseRequested;

        /// <summary>
        /// Raised when the window is moved.
        /// </summary>
        event Vector2DAction? Move;

        /// <summary>
        /// Raised when the window state is changed.
        /// </summary>
        event WindowStateAction? StateChanged;

        /// <summary>
        /// Raised when the user drops files onto the window.
        /// </summary>
        event FilePathsAction? FileDrop;

        /// <summary>
        /// Raised when the window focus changes.
        /// </summary>
        event ToggleAction? FocusChanged;

        /// <summary>
        /// Sets the window icons.
        /// </summary>
        /// <param name="icons">Either a collection of window icons, or null to set to the default icon.</param>
        void SetWindowIcon(ReadOnlySpan<RawImage> icons)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// When using <see cref="WindowOptions.IsEventDriven"/> = true, wakes the main thread from
        /// its blocking wait on incoming events.  Can be called from any thread.
        /// </summary>
        void ContinueEvents()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts this point to client coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects screen coordinates as input.</remarks>
        Vector2D<int> PointToClient(Vector2D<int> point)
        {
            return new Vector2D<int>(point.X - Position.X, point.Y - Position.Y);
        }

        /// <summary>
        /// Converts this point to screen coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToScreen(Vector2D<int> point)
        {
            return new Vector2D<int>(point.X + Position.X, point.Y + Position.Y);
        }
        public Vector2D<int> PointToFramebuffer(Vector2D<int> point)
        {
            throw new NotImplementedException();
        }
    }
}