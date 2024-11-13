// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Silk.NET.Maths;

/// <summary>
/// Represents an application running within a surface.
/// </summary>
public interface ISurfaceApplication
{
    /// <summary>
    /// An optional window class.
    /// </summary>
    static virtual string? WindowClass => null;

    /// <summary>
    /// Called upon initialization of the application.
    /// </summary>
    static abstract void Initialize<TSurface>(TSurface surface)
        where TSurface : Surface;

    /// <summary>
    /// Runs an application using the reference implementation of Silk.NET.Windowing.
    /// </summary>
    /// <typeparam name="T">The application.</typeparam>
    [UnsupportedOSPlatform("android")]
    public static sealed void Run<T>()
        where T : ISurfaceApplication => throw new NotImplementedException();
}

/// <summary>
/// Contains parameters for events executed at predictable intervals by a <see cref="Surface" />.
/// </summary>
/// <param name="Surface">The surface to which the event pertains.</param>
/// <param name="DeltaTime">The number of seconds that have elapsed since the last execution of this event.</param>
public readonly record struct SurfaceTimingEvent(Surface Surface, double DeltaTime);

/// <summary>
/// Contains parameters for events executed in response to an application lifecycle notification being issued to a
/// surface.
/// </summary>
public readonly record struct SurfaceLifecycleEvent(Surface Surface);

/// <summary>
/// Contains properties pertaining to events a surface shall raise at predictable intervals.
/// </summary>
/// <param name="TargetDelta">
/// The target number of seconds for the surface between the start of the previous execution of the event, and the start
/// of the next execution.
/// </param>
/// <remarks>
/// Note that timed events are executed in terms of the surface's tick frequency. If <see cref="Surface.TickOptions" />
/// is set to run the <see cref="Surface.Tick" /> event at a lower frequency than is targeted by this event, it is
/// impossible to meet the <paramref name="TargetDelta" />.
/// </remarks>
public readonly record struct SurfaceTimingOptions(double TargetDelta);

/// <summary>
/// Contains properties pertaining to the regular execution of the <see cref="Surface.Tick" /> event.
/// </summary>
/// <param name="IsEventDriven">
/// Whether <see cref="Surface.Tick" /> should only execute in response to an event (of any kind) and/or
/// <see cref="Surface.Continue" /> if <c>true</c>; if <c>false</c> the event shall be raised as frequently as the
/// implementation/platform can handle.
/// </param>
public readonly record struct SurfaceTickOptions(bool IsEventDriven);

/// <summary>
/// Contains properties pertaining to a resize event.
/// </summary>
/// <param name="Surface">The surface raising the resize event.</param>
/// <param name="OldSize">The previous size value.</param>
/// <param name="NewSize">The new size value.</param>
public readonly record struct SurfaceResizeEvent(Surface Surface, Vector2 OldSize, Vector2 NewSize);

/// <summary>
/// Represents a surface within which a user application can run. This class contains a modular, cross-platform
/// interface with which the platform's multimedia capabilities can be configured and the execution of the application
/// within the surface controlled.
/// </summary>
public abstract class Surface : IGLContextSource, INativeWindow
{
    /// <summary>
    /// Gets the OpenGL configuration of the surface, if supported.
    /// </summary>
    public virtual ISurfaceOpenGL? OpenGL => null;

    /// <summary>
    /// Gets the configuration for the window in which the surface is being drawn.
    /// </summary>
    public virtual ISurfaceWindow? Window => null;

    /// <summary>
    /// Gets the display configuration for the surface, if supported.
    /// </summary>
    public virtual ISurfaceDisplay? Display => null;

    /// <summary>
    /// Gets the Vulkan component of this surface.
    /// </summary>
    public virtual ISurfaceVulkan? Vulkan => null;

    /// <summary>
    /// Gets the "child surface" functionality if available.
    /// </summary>
    public virtual ISurfaceChildren? Children => null;

    /// <summary>
    /// Gets the content scale configuration within the surface.
    /// </summary>
    public virtual ISurfaceScale? Scale => null;

    IGLContext? IGLContextSource.GLContext => OpenGL;

    /// <summary>
    /// Gets the size <b>in pixels</b> of the area drawable within the surface.
    /// </summary>
    public abstract Vector2 DrawableSize { get; }

    /// <summary>
    /// An event raised as frequently as possible (or in line with <see cref="TickOptions" />).
    /// </summary>
    public event Action<SurfaceTimingEvent>? Tick;

    /// <summary>
    /// An event raised in accordance with <see cref="RenderOptions" /> with the intention of providing the application
    /// an opportunity to redraw its graphics within the surface.
    /// </summary>
    public event Action<SurfaceTimingEvent>? Render;

    /// <summary>
    /// An event raised in accordance with <see cref="UpdateOptions" /> with the intention of providing the application
    /// an opportunity to redraw its graphics within the surface.
    /// </summary>
    public event Action<SurfaceTimingEvent>? Update;

    /// <summary>
    /// Raised when <see cref="DrawableSize" /> changes.
    /// </summary>
    public abstract event Action<SurfaceResizeEvent>? DrawableSizeChanged;

    /// <summary>
    /// An event executed when the surface is first loaded.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent>? Created;

    /// <summary>
    /// An event executed when the surface and the application thereof are about to terminate irrevocably.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent>? Terminating;

    /// <summary>
    /// An event executed when the surface and the application thereof are pausing on request of the operating system.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent>? Pausing;

    /// <summary>
    /// An event executed when the surface and the application thereof are resuming on request of the operating system.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent>? Resuming;

    /// <summary>
    /// An event executed when the operating system indicates the amount of memory that can be allocated for the
    /// application running the surface is low.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent>? LowMemory;

    /// <summary>
    /// Gets or sets additional configuration/constraints for the <see cref="Tick" /> event.
    /// </summary>
    public abstract SurfaceTickOptions TickOptions { get; set; }

    /// <summary>
    /// Gets or sets additional configuration/constraints for the <see cref="Render" /> event.
    /// </summary>
    /// <remarks>Failure to call into the base property will result in incorrect behaviour.</remarks>
    public virtual SurfaceTimingOptions RenderOptions
    {
        get => new(GetDelta(_renderFrequency));
        set => _renderFrequency = GetFrequencyValue(value.TargetDelta);
    }

    /// <summary>
    /// Gets or sets additional configuration/constraints for the <see cref="Update" /> event.
    /// </summary>
    /// <remarks>Failure to call into the base property will result in incorrect behaviour.</remarks>
    public virtual SurfaceTimingOptions UpdateOptions
    {
        get => new(GetDelta(_updateFrequency));
        set => _updateFrequency = GetFrequencyValue(value.TargetDelta);
    }

    // It is expected that the timing logic be common code i.e. all of these APIs shall be implemented in `Surface` and
    // not a derived type. `FramesPerSecond` and `UpdatesPerSecond` shall to forward to `RenderOptions.TargetDelta` and
    // `UpdateOptions.TargetDelta` respectively with the value of `1 / value`. `SurfaceTimingOptions` has been
    // introduced for future proofing in the event that we want to add more options such as executing one of the events
    // on a different thread (e.g. as in Silk.NET 1.X when the `UseSingleThreadedWindow` option was set to `false`).
    // These settings shall default to run as fast as possible. A `TargetDelta` value close to zero or a negative number
    // is interpreted to mean run as fast as possible. This shall be represented by `FramesPerSecond`/`UpdatesPerSecond`
    // as a negative number. A `TargetDelta` value close to `double.MaxValue` shall be interpreted to mean "never
    // execute". This shall be represented by `FramesPerSecond`/`UpdatesPerSecond` as zero. The `OnRender` and
    // `OnUpdate` methods shall raise the `Render` and `Update` events respectively, which the implementation has the
    // opportunity to override.
    private static int GetPerSecondValue(ulong frequency) =>
        frequency switch
        {
            0 => -1,
            ulong.MaxValue => 0,
            _ => (int)(frequency / (ulong)Stopwatch.Frequency),
        };

    private static ulong GetFrequencyValue(int perSecond) =>
        perSecond switch
        {
            < 0 => 0,
            0 => ulong.MaxValue,
            _ => (ulong)(Stopwatch.Frequency / perSecond),
        };

    private static double GetDelta(ulong frequency) =>
        frequency switch
        {
            ulong.MaxValue => double.MaxValue,
            0 => 0,
            _ => (double)frequency / Stopwatch.Frequency,
        };

    private static ulong GetFrequencyValue(double targetDelta)
    {
        if (targetDelta <= 0)
        {
            return 0;
        }

        if (Math.Abs(targetDelta - double.MaxValue) < double.Epsilon)
        {
            return ulong.MaxValue;
        }

        return (ulong)(targetDelta * Stopwatch.Frequency);
    }

    /// <summary>
    /// Gets or sets a value representing <see cref="RenderOptions" />.<see cref="SurfaceTimingOptions.TargetDelta" />
    /// as a number of executions per second.
    /// </summary>
    public int FramesPerSecond
    {
        get => GetPerSecondValue(_renderFrequency);
        set => _renderFrequency = GetFrequencyValue(value);
    }

    /// <summary>
    /// Gets or sets a value representing <see cref="UpdateOptions" />.<see cref="SurfaceTimingOptions.TargetDelta" />
    /// as a number of executions per second.
    /// </summary>
    public int UpdatesPerSecond
    {
        get => GetPerSecondValue(_updateFrequency);
        set => _updateFrequency = GetFrequencyValue(value);
    }

    /// <summary>
    /// Provides a strong hint to the underlying platform that a tick should execute. This is mainly useful for
    /// <see cref="TickOptions" />.<see cref="SurfaceTickOptions.IsEventDriven" /> where execution of this method
    /// constitutes an event.
    /// </summary>
    public abstract void Continue();

    /// <summary>
    /// Irrevocably terminates this surface and the application running within it, resulting in the immediate ceasing of
    /// <see cref="Tick" /> event execution and all derived events thereof. The surface cannot recover from this state,
    /// requiring the relaunch of the <see cref="ISurfaceApplication" /> if available on the platform.
    /// </summary>
    public abstract void Terminate();

    private ulong _lastTick;
    private ulong _lastRender;
    private ulong _renderFrequency;
    private ulong _lastUpdate;
    private ulong _updateFrequency;

    private static bool TimeCheck(ref ulong lastTimestamp, ulong frequency, out ulong diff)
    {
        diff = 0;
        if (frequency == ulong.MaxValue)
        {
            return false;
        }

        var now = (ulong)Stopwatch.GetTimestamp();
        if (now < lastTimestamp + frequency)
        {
            return false;
        }

        diff = now - lastTimestamp;
        lastTimestamp = now;
        return true;
    }

    /// <summary>
    /// Executes the <see cref="Tick" /> event. This will also call <see cref="OnUpdate" /> and <see cref="OnRender" />.
    /// </summary>
    protected virtual void OnTick()
    {
        TimeCheck(ref _lastTick, 0, out var diff);
        Tick?.Invoke(new SurfaceTimingEvent(this, diff / (double)Stopwatch.Frequency));
    }

    /// <summary>
    /// Executes the <see cref="Render" /> event if the constraints defined in <see cref="RenderOptions" /> are met.
    /// </summary>
    protected virtual void OnRender()
    {
        if (!TimeCheck(ref _lastRender, _renderFrequency, out var diff))
        {
            return;
        }

        Render?.Invoke(new SurfaceTimingEvent(this, diff / (double)Stopwatch.Frequency));
    }

    /// <summary>
    /// Executes the <see cref="Update" /> event if the constraints defined in <see cref="UpdateOptions" /> are met.
    /// </summary>
    protected virtual void OnUpdate()
    {
        if (!TimeCheck(ref _lastUpdate, _updateFrequency, out var diff))
        {
            return;
        }

        Update?.Invoke(new SurfaceTimingEvent(this, diff / (double)Stopwatch.Frequency));
    }

    /// <summary>
    /// Centers this window to the given monitor or, if null, the current monitor the window's on.
    /// </summary>
    /// <param name="display">The specific display to center the window to, if any.</param>
    public void Center(IDisplay? display = null) => throw new NotImplementedException();

    /// <summary>
    /// Converts a point that is defined in the same coordinate space as <see cref="IDisplay.Bounds" /> to instead be
    /// defined relative to <see cref="ISurfaceWindow.ClientArea" />. Requires both <see cref="Window" /> and
    /// <see cref="Display" /> components to be supported, if not <paramref name="point" /> shall be returned as is.
    /// </summary>
    /// <param name="point">The point to transform.</param>
    /// <returns>The transformed point.</returns>
    public Vector2 ScreenToClient(Vector2 point) => throw new NotImplementedException();

    /// <summary>
    /// Converts a point that is defined relative to <see cref="ISurfaceWindow.ClientArea" /> to instead be defined in the
    /// same coordinate space as <see cref="IDisplay.Bounds" />. Requires both <see cref="Window" /> and
    /// <see cref="Display" /> components to be supported, if not <paramref name="point" /> shall be returned as is.
    /// </summary>
    /// <param name="point">The point to transform.</param>
    /// <returns>The transformed point.</returns>
    public Vector2 ClientToScreen(Vector2 point) => throw new NotImplementedException();

    /// <summary>
    /// Converts a point that is defined relative to <see cref="ISurfaceWindow.ClientArea" /> by multiplying it with the
    /// division of <see cref="DrawableSize" /> by <see cref="ISurfaceWindow.ClientArea" />'s size.
    /// </summary>
    /// <param name="point">The point to transform.</param>
    /// <returns>The transformed point.</returns>
    public Vector2 ClientToDrawable(Vector2 point) => throw new NotImplementedException();

    /// <inheritdoc />
    public abstract bool TryGetPlatformInfo<TPlatformInfo>(
        [NotNullWhen(true)] out TPlatformInfo? info
    );
}

/// <summary>
/// Represents flags related to the OpenGL context.
/// </summary>
[Flags]
public enum OpenGLContextFlags
{
    /// <summary>
    /// No flags enabled.
    /// </summary>
    Default = 0,

    /// <summary>
    /// Enables debug context; debug contexts provide more debugging info, but can run slower.
    /// </summary>
    Debug = 1 << 0,

    /// <summary>
    /// Enables forward compatibility; this context won't support anything marked as deprecated in the current
    /// version.
    /// </summary>
    /// <remarks>On OpenGL contexts older than 3.0, this flag does nothing.</remarks>
    ForwardCompatible = 1 << 1,
}

/// <summary>
/// Represents the context profile OpenGL should use.
/// </summary>
public enum OpenGLContextProfile
{
    /// <summary>
    /// An OpenGL context will not be created for this surface.
    /// </summary>
    None = 0,

    /// <summary>
    /// Use the platform default context profile e.g. <see cref="ES2" /> on mobile platforms, <see cref="Core" />
    /// otherwise.
    /// </summary>
    Default,

    /// <summary>
    /// Uses a core OpenGL context, which removes some deprecated functionality.
    /// </summary>
    Core,

    /// <summary>
    /// Uses a compatibility OpenGL context, allowing for some deprecated functionality. This should only ever be
    /// used for maintaining legacy code; no newly-written software should use this.
    /// </summary>
    Compatibility,

    /// <summary>
    /// Uses an OpenGLES 2+ profile.
    /// </summary>
    ES2,
}

/// <summary>
/// The OpenGL component of a <see cref="Surface" />. The <see cref="IGLContext" /> methods can only be executed once
/// <see cref="ISurfaceApplication.Initialize{TSurface}" /> has executed.
/// </summary>
/// <remarks>
/// These objects may be shared with child windows created using <see cref="ISurfaceChildren" /> and vice versa i.e.
/// this object can be shared between all surfaces that share a common ancestor (the "root surface"). Beyond that, these
/// objects are not guaranteed to be valid across surfaces. This allows one event handler to enact changes on multiple
/// surfaces. This is important for <see cref="SharedContext" /> purposes.
/// </remarks>
public interface ISurfaceOpenGL : IGLContext
{
    /// <summary>
    /// Gets or sets a value indicating whether OpenGL support is enabled for this surface. Setting
    /// <see cref="Profile" /> to a value other than <see cref="OpenGLContextProfile.None" /> will automatically set
    /// this property to <c>true</c>, and likewise toggling the value assigned to this property will change the value of
    /// <see cref="Profile" />.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    // Included for consistency with Vulkan.
    bool IsEnabled
    {
        get => Profile != OpenGLContextProfile.None;
        set =>
            Profile = value
                ? Profile == OpenGLContextProfile.None
                    ? OpenGLContextProfile.Default
                    : Profile
                : OpenGLContextProfile.None;
    }

    /// <summary>
    /// Preferred depth buffer bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> to use the system default.
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// Setting this property will automatically set <see cref="Profile" /> to
    /// <see cref="OpenGLContextProfile.Default" /> if it is currently <see cref="OpenGLContextProfile.None" />.
    /// </remarks>
    int? PreferredDepthBufferBits { get; set; }

    /// <summary>
    /// Preferred stencil buffer bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> to use the system default.
    /// </remarks>
    int? PreferredStencilBufferBits { get; set; }

    /// <summary>
    /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> for any of the channels to use the system default.
    /// </remarks>
    Vector4D<int>? PreferredBitDepth { get; set; }

    /// <summary>
    /// Preferred number of samples for multi-sample anti-aliasing.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    int? PreferredSampleCount { get; set; }

    /// <summary>
    /// The API version to use.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    Version32? Version { get; set; }

    /// <summary>
    /// Flags used to create the OpenGL context.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    OpenGLContextFlags Flags { get; set; }

    /// <summary>
    /// The profile the OpenGL context should use. If <see cref="OpenGLContextProfile.None" /> is used, the OpenGL
    /// component is effectively disabled, allowing for other graphics APIs/components to be used. If any of the other
    /// properties on this class are set while this property is <see cref="OpenGLContextProfile.None" />, this property
    /// shall automatically be populated with the value <see cref="OpenGLContextProfile.Default" />.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method. If the value is
    /// <see cref="OpenGLContextProfile.Default" />, this shall be replaced with the actual value upon exit from
    /// <see cref="ISurfaceApplication.Initialize{TSurface}" />.
    /// </remarks>
    OpenGLContextProfile Profile { get; set; }

    /// <summary>
    /// Gets a value indicating whether the current configuration is supported (e.g. version number). If
    /// <see cref="Profile" /> is not <see cref="OpenGLContextProfile.None" /> and this property is <c>true</c>, the
    /// OpenGL context shall be created and accessible upon exit from
    /// <see cref="ISurfaceApplication.Initialize{TSurface}" />.
    /// </summary>
    bool IsSupported { get; }

    /// <summary>
    /// Gets or sets a value indicating whether the platform should automatically <see cref="IGLContext.SwapBuffers" />
    /// after <see cref="Surface.Render" />. Defaults to <c>true</c>.
    /// </summary>
    /// <remarks>
    /// This can be set at any point throughout the surface's execution.
    /// </remarks>
    bool ShouldSwapAutomatically { get; set; }

    /// <summary>
    /// Gets or sets the context with which this context should share resources.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    IGLContext? SharedContext { get; set; }
}

/// <summary>
/// Contains properties pertaining to the window's position or size changing.
/// </summary>
/// <param name="Surface">The surface that owns the window the event pertains to.</param>
/// <param name="OldBounds">The previous value of <see cref="ISurfaceWindow.Bounds" />.</param>
/// <param name="NewBounds">The new value of <see cref="ISurfaceWindow.Bounds" />.</param>
/// <param name="OldClientArea">The previous value of <see cref="ISurfaceWindow.ClientArea" />.</param>
/// <param name="NewClientArea">The new value of <see cref="ISurfaceWindow.ClientArea" />.</param>
public readonly record struct WindowCoordinatesEvent(
    Surface Surface,
    Rectangle<float> OldBounds,
    Rectangle<float> NewBounds,
    Rectangle<float> OldClientArea,
    Rectangle<float> NewClientArea
)
{
    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.Size" />.
    /// </summary>
    public Vector2 OldSize => (Vector2)OldBounds.Size;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.Size" />.
    /// </summary>
    public Vector2 NewSize => (Vector2)NewBounds.Size;

    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    public Vector2 OldClientSize => (Vector2)OldClientArea.Size;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    public Vector2 NewClientSize => (Vector2)NewClientArea.Size;

    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.Position" />.
    /// </summary>
    public Vector2 OldPosition => (Vector2)OldBounds.Origin;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.Position" />.
    /// </summary>
    public Vector2 NewPosition => (Vector2)NewBounds.Origin;
}

/// <summary>
/// Represents the current state of the window.
/// </summary>
public enum WindowState
{
    /// <summary>
    /// The window is in its regular configuration.
    /// </summary>
    Normal = 0,

    /// <summary>
    /// The window has been minimized to the task bar.
    /// </summary>
    Minimized,

    /// <summary>
    /// The window has been maximized, covering the entire desktop, but not the taskbar.
    /// </summary>
    Maximized,

    /// <summary>
    /// The window has been fullscreened, covering the entire surface of the monitor. Note that changing to/from this
    /// state may enact an implicit change to <see cref="ISurfaceDisplay" />'s state if supported.
    /// </summary>
    Fullscreen,
}

/// <summary>
/// Contains properties pertaining to a boolean window property being toggled.
/// </summary>
/// <param name="Value">The new value.</param>
public readonly record struct WindowToggleEvent(Surface Surface, bool Value);

/// <summary>
/// Contains properties pertaining to a change in window state.
/// </summary>
/// <param name="Surface">The surface that owns the window to which the event pertains.</param>
/// <param name="OldState">The previous value of <see cref="ISurfaceWindow.State" />.</param>
/// <param name="NewState">The new value of <see cref="ISurfaceWindow.State" />.</param>
public readonly record struct WindowStateEvent(
    Surface Surface,
    WindowState OldState,
    WindowState NewState
);

/// <summary>
/// Contains properties pertaining to one or more files being dropped onto a window.
/// </summary>
/// <param name="Surface">The surface that owns the window to which the event pertains.</param>
/// <param name="Files">The paths of the files dropped onto the window.</param>
public readonly record struct WindowFileEvent(Surface Surface, IReadOnlyList<string> Files);

/// <summary>
/// Represents a single window icon.
/// </summary>
public ref struct WindowIcon
{
    /// <summary>
    /// The width of the window icon.
    /// </summary>
    public required int Width { get; init; }

    /// <summary>
    /// The height of the window icon.
    /// </summary>
    public required int Height { get; init; }

    /// <summary>
    /// The window icon's pixel data in row-major order, where 4 bytes are allocated for each pixel and 1 byte
    /// representing each of the red, green, blue, and alpha channels (in that order).
    /// </summary>
    public required ReadOnlySpan<byte> Data { get; init; }
}

/// <summary>
/// One or more <see cref="WindowIcon" />s representing multiple variants (e.g. for size/DPI differences) of the same
/// window icon.
/// </summary>
public ref struct WindowIconVariants
#if NET9_0_OR_GREATER
    : IEnumerable
#endif
{
    /// <summary>
    /// The maximum number of variants.
    /// </summary>
    public const int MaxVariants = 16;

    private int _count;
    private WindowIcon _e0;
    private WindowIcon _e1;
    private WindowIcon _e2;
    private WindowIcon _e3;
    private WindowIcon _e4;
    private WindowIcon _e5;
    private WindowIcon _e6;
    private WindowIcon _e7;
    private WindowIcon _e8;
    private WindowIcon _e9;
    private WindowIcon _e10;
    private WindowIcon _e11;
    private WindowIcon _e12;
    private WindowIcon _e13;
    private WindowIcon _e14;
    private WindowIcon _e15;

    /// <summary>
    /// Gets or sets the window icon variant at the given index.
    /// </summary>
    [UnscopedRef]
    public ref WindowIcon this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            // csharpier-ignore-start
            // ReSharper disable EnforceIfStatementBraces - for readability/editability
            // ReSharper disable ConvertIfStatementToSwitchStatement - false positive
            if (index == 0) return ref _e0;
            if (index == 1) return ref _e1;
            if (index == 2) return ref _e2;
            if (index == 3) return ref _e3;
            if (index == 4) return ref _e4;
            if (index == 5) return ref _e5;
            if (index == 6) return ref _e6;
            if (index == 7) return ref _e7;
            if (index == 8) return ref _e8;
            if (index == 9) return ref _e9;
            if (index == 10) return ref _e10;
            if (index == 11) return ref _e11;
            if (index == 12) return ref _e12;
            if (index == 13) return ref _e13;
            if (index == 14) return ref _e14;
            if (index == 15) return ref _e15;
            throw new ArgumentOutOfRangeException(nameof(index));
            // ReSharper restore ConvertIfStatementToSwitchStatement
            // ReSharper restore EnforceIfStatementBraces
            // csharpier-ignore-end
        }
    }

    /// <summary>
    /// Creates a window icon with just one variant.
    /// </summary>
    public WindowIconVariants(WindowIcon icon)
    {
        _e0 = icon;
        _count = 1;
    }

    /// <summary>
    /// Gets the number of variants within this window icon.
    /// </summary>
    public int Count => _count;

    /// <summary>
    /// Adds a variant.
    /// </summary>
    /// <param name="icon">The variant to add.</param>
    public void Add(WindowIcon icon)
    {
        if (_count == MaxVariants)
        {
            throw new InvalidOperationException(
                "The maximum number of variants have been reached."
            );
        }

        this[_count++] = icon;
    }

    /// <summary>
    /// Removes the variant at the given index.
    /// </summary>
    /// <param name="i">The index to remove at. All elements thereafter will be shifted left by one.</param>
    public void RemoveAt(int i)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(i, _count);
        for (var j = i; j < _count - 1; j++)
        {
            this[j] = this[j + 1];
        }

        _count--;
    }

    /// <summary>
    /// Converts a <see cref="WindowIcon" /> into a <see cref="WindowIconVariants" /> with one variant.
    /// </summary>
    /// <param name="icon">The icon.</param>
    /// <returns>The single-variant <see cref="WindowIconVariants" /> incorporating <paramref name="icon" /></returns>
    public static implicit operator WindowIconVariants(WindowIcon icon) => new(icon);

    /// <summary>
    /// Enumerates the variants contained within this <see cref="WindowIconVariants" />.
    /// </summary>
    /// <returns>An enumerator.</returns>
    public Enumerator GetEnumerator() => new(this);

#if NET9_0_OR_GREATER
    // Will return byte[,] elements, this is only implemented to make collection/initializer expressions to light up.
    // Not implementing the generic interface to further discourage use.
    // Ref structs can only implement interfaces as of C# 13/.NET 9
    IEnumerator IEnumerable.GetEnumerator()
    {
        // Dear god this is terrible, it's a good thing noone will ever use it.
        var array = new byte[_count][,];
        for (var i = 0; i < _count; i++)
        {
            var icon = this[i];
            array[i] = new byte[icon.Width, icon.Height];
            for (var x = 0; x < icon.Width; x++)
            {
                for (var y = 0; y < icon.Height; y++)
                {
                    array[i][x, y] = icon.Data[(y * icon.Width) + x];
                }
            }
        }

        return array.GetEnumerator();
    }
#endif

    /// <summary>
    /// An enumerator over <see cref="WindowIcon" />s contained in <see cref="WindowIconVariants" />. This can only be
    /// created using <see cref="GetEnumerator" />.
    /// </summary>
    public ref struct Enumerator
    {
        private WindowIconVariants _variants;
        private int _current;

        internal Enumerator(WindowIconVariants variants) => _variants = variants;

        /// <summary>
        /// The output from <see cref="MoveNext" /> if that returned <c>true</c>.
        /// </summary>
        // --------------------------vvvvvvvvvvvvv---------- protect against default(WindowIconVariants.Enumerator)
        public WindowIcon Current => _current == 0 ? default : _variants[_current - 1];

        /// <summary>
        /// Retrieves the next variant. This must be called before reading the first element (and every subsequent
        /// element).
        /// </summary>
        public bool MoveNext()
        {
            if (_current >= _variants.Count)
            {
                return false;
            }

            _current++;
            return true;
        }

        /// <summary>
        /// Resets the enumerator back to its initial state. Note that <see cref="MoveNext" /> must be called before
        /// retrieving an element again.
        /// </summary>
        public void Reset() => _current = 0;
    }
}

/// <summary>
/// Represents the window border.
/// </summary>
public enum WindowBorder
{
    /// <summary>
    /// The window can be resized by clicking and dragging its border.
    /// </summary>
    Resizable = 0,

    /// <summary>
    /// The window border is visible, but cannot be resized. All window-resizings must happen solely in the code.
    /// </summary>
    Fixed,

    /// <summary>
    /// The window border is hidden.
    /// </summary>
    Hidden,
}

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

/// <summary>
/// Contains properties pertaining to a display being connected or disconnected.
/// </summary>
/// <param name="Surface">The surface for which display(s) were connected.</param>
/// <remarks>
/// Old display objects are not guaranteed to be valid or relevant after this event is raised.
/// </remarks>
// Currently this event does not include the displays that were connected or disconnected. This is primarily because
// there's no clean way to expose such "diffs" from an API perspective (as disconnected IDisplay objects are likely to
// be invalid), and also why would we need to? If a use case arises and this can be implemented in a sound way, let's
// evaluate that then.
public readonly record struct DisplayAvailabilityChangeEvent(Surface Surface);

/// <summary>
/// Contains properties pertaining to a surface changing to a different display.
/// </summary>
/// <param name="Surface">The surface changing to a different display.</param>
/// <param name="Display">The display the surface has changed to.</param>
/// <remarks>
/// It is expected that this event shall be raised for each logically substantial change to the display parameters and
/// this can be defined by each individual platform. For instance, if the underlying platform does not give the
/// application access to any displays other than the one it's currently being displayed on, then it is expected that
/// this event shall be raised if the display changed even if this is represented by the same object. Old display
/// objects are not guaranteed to be valid or relevant after this event is raised.
/// </remarks>
public readonly record struct DisplayChangeEvent(Surface Surface, IDisplay Display);

/// <summary>
/// Contains properties pertaining to a change in the available video modes for a display.
/// </summary>
/// <param name="Surface">The surface owning the display.</param>
/// <param name="Display">The display for which the video mode availability changed.</param>
// I don't think we need to have a diff here either, why would old video modes be relevant?
public readonly record struct DisplayVideoModeAvailabilityChangeEvent(
    Surface Surface,
    IDisplay Display
);

/// <summary>
/// Contains properties pertaining to a change in the location and/or size of a display.
/// </summary>
/// <param name="Surface">The surface owning the display.</param>
/// <param name="Display">The display for which the location and/or size changed.</param>
/// <param name="OldBounds">The previous value of <see cref="IDisplay.Bounds" />.</param>
/// <param name="NewBounds">The new value of <see cref="IDisplay.Bounds" />.</param>
/// <param name="OldWorkArea">The previous value of <see cref="IDisplay.WorkArea" />.</param>
/// <param name="NewWorkArea">The new value of <see cref="IDisplay.WorkArea" />.</param>
public readonly record struct DisplayCoordinatesEvent(
    Surface Surface,
    IDisplay Display,
    Rectangle<float> OldBounds,
    Rectangle<float> NewBounds,
    Rectangle<float> OldWorkArea,
    Rectangle<float> NewWorkArea
);

/// <summary>
/// Represents the properties of a surface whose rendering is intrinsically linked to the composition of a specific
/// display. In most cases, this translates to "the surface is rendering in fullscreen mode".
/// </summary>
/// <param name="Resolution">
/// The resolution the surface is rendering on its display at, if known. If <c>null</c>, it is highly likely that the
/// surface is not rendering in fullscreen mode or otherwise has its rendering intrinsically linked to the composition
/// of a specific display.
/// </param>
/// <param name="RefreshRate">
/// The rate (per second) at which the physical display will receive new renders from the surface, if known. If
/// <c>null</c>, the platform may not expose the refresh rate to surfaces or it is highly likely that the
/// surface is not rendering in fullscreen mode or otherwise has its rendering intrinsically linked to the composition
/// of a specific display.
/// </param>
/// <remarks>
/// If a <c>default</c> video mode is encountered, it is highly likely the surface is not rendering in fullscreen mode.
/// If an individual property is <c>null</c>, it is highly likely that property is not controllable programmatically.
/// </remarks>
public readonly record struct VideoMode(Vector2? Resolution, int? RefreshRate);

/// <summary>
/// Represents a display on which a surface can be rendered.
/// </summary>
/// <remarks>
/// These objects may be shared with child windows created using <see cref="ISurfaceChildren" /> and vice versa i.e.
/// this object can be shared between all surfaces that share a common ancestor (the "root surface"). Beyond that, these
/// objects are not guaranteed to be valid across surfaces. This allows one event handler to enact changes on multiple
/// surfaces.
/// </remarks>
public interface IDisplay
{
    /// <summary>
    /// Gets the position and resolution of the monitor in screen space.
    /// </summary>
    Rectangle<float> Bounds { get; }

    /// <summary>
    /// Gets the area within <see cref="Bounds" /> where surfaces are <i>intended</i> to be drawn.
    /// </summary>
    /// <remarks>
    /// This typically is the area left once you account for things like the menu bar and taskbar.
    /// </remarks>
    Rectangle<float> WorkArea { get; }

    /// <summary>
    /// Gets a list of video modes known to be available when this display is <see cref="ISurfaceDisplay.Current" />.
    /// It may be the case that a list of video modes can't be determined until that's the case.
    /// </summary>
    IReadOnlyList<VideoMode>? KnownVideoModes { get; }

    /// <summary>
    /// Gets a value indicating whether the user has designated this display their primary display.
    /// </summary>
    bool IsPrimary { get; }

    /// <summary>
    /// Gets a colloquial name for the display. This may change, but hopefully not to something the end user won't recognise.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// An event raised when <see cref="Bounds" /> and/or <see cref="WorkArea" /> changes.
    /// </summary>
    event Action<DisplayCoordinatesEvent>? CoordinatesChanged;

    /// <summary>
    /// An event raised when <see cref="KnownVideoModes" /> changes.
    /// </summary>
    event Action<DisplayVideoModeAvailabilityChangeEvent>? KnownVideoModesChanged;
}

/// <summary>
/// Provides the ability to configure displays on which the surface can render.
/// </summary>
public interface ISurfaceDisplay
{
    /// <summary>
    /// Gets or sets display on which the surface is currently rendering. If setting, <c>value</c> must be contained in
    /// <see cref="Available" />.
    /// </summary>
    IDisplay Current { get; set; }

    /// <summary>
    /// Gets a list of other displays that this surface can be moved to. If the surface cannot be programmatically moved
    /// to another display, it is expected that this shall return a single element list containing
    /// <see cref="Current" />.
    /// </summary>
    IReadOnlyList<IDisplay> Available { get; }

    /// <summary>
    /// Gets or sets the video mode with which the surface is being rendered to the display. If setting, <c>value</c>
    /// must be contained in <see cref="AvailableVideoModes" />.
    /// </summary>
    VideoMode VideoMode { get; set; }

    /// <summary>
    /// Gets a list of video modes with which the surface can be rendered. If the surface cannot programmatically change
    /// its video mode, it is expected that this shall return a single element list containing <see cref="VideoMode" />.
    /// </summary>
    IReadOnlyList<VideoMode> AvailableVideoModes { get; }

    /// <summary>
    /// An event raised when <see cref="Current" /> changes.
    /// </summary>
    event Action<DisplayChangeEvent>? CurrentDisplayChanged;

    /// <summary>
    /// An event raised when <see cref="Available" /> changes.
    /// </summary>
    event Action<DisplayAvailabilityChangeEvent>? AvailableChanged;

    /// <summary>
    /// An event raised when <see cref="AvailableVideoModes" /> changes.
    /// </summary>
    event Action<DisplayVideoModeAvailabilityChangeEvent>? AvailableVideoModesChanged;
}

/// <summary>
/// The Vulkan component of a <see cref="Surface" />.
/// </summary>
public interface ISurfaceVulkan
{
    /// <summary>
    /// Gets or sets a value indicating whether the Vulkan component is enabled for this surface.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    bool IsEnabled { get; set; }

    /// <summary>
    /// Creates a <c>VkSurface</c> for this surface.
    /// </summary>
    /// <param name="instance">
    /// The <c>VkInstance</c> to use. Must have extensions specified in <see cref="GetRequiredExtensions" /> enabled.
    /// </param>
    /// <param name="allocator">The <c>VkAllocationCallbacks*</c> to use.</param>
    /// <remarks>
    /// This can only be executed once the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method has returned.
    /// </remarks>
    /// <returns>The <c>VkSurface</c>.</returns>
    ulong CreateSurface(nint instance, Ptr allocator);

    /// <summary>
    /// Gets the instance extensions that are required to be enabled on instances used for <see cref="CreateSurface" />.
    /// </summary>
    /// <param name="count">The number of pointers in the return value.</param>
    /// <returns>
    /// The required extensions as a native pointer. The pointer is guaranteed to share the lifetime of the surface.
    /// </returns>
    Ptr2D<sbyte> GetRequiredExtensions(out uint count);
}

/// <summary>
/// Provides information pertaining to the surface's graphical scaling.
/// </summary>
/// <remarks>
/// <see cref="ContentScale" /> is typically used to scale UI elements to the correct size for the end user.
/// <see cref="PixelDensity" /> on the other hand is used to scale the entire application to cover the entire client
/// area in cases where the window client size is smaller than the actual drawable size (i.e. it is high density).
/// If scaling content for legibility and scaling the application's rendering as a whole are not needed to be separated,
/// it is recommended to use <see cref="DrawScale" />. Implementations shall always request a high density surface if
/// given the choice, to account for the platforms where applications may not be able to opt-out of high density.
/// </remarks>
public interface ISurfaceScale
{
    /// <summary>
    /// Gets the factor with which the application should scale its content to make the content more legible for the
    /// user. This has no influence on <see cref="Surface.DrawableSize" />.
    /// </summary>
    /// <seealso cref="DrawScale" />
    float ContentScale { get; }

    /// <summary>
    /// Gets the suggested amplification factor when drawing in terms of <see cref="Surface.DrawableSize" />. This
    /// represents the scale from the pixel resolution to the desired content size, and is typically the multiplication
    /// of <see cref="PixelDensity" /> and <see cref="ContentScale" />.
    /// </summary>
    /// <remarks>
    /// For example, if <see cref="PixelDensity" /> is <c>2.0</c> (i.e. there are 2 pixels per screen coordinate)
    /// <i>and</i> the window manager requests that applications scale their content up by <c>2.0</c> to meet the user's
    /// settings as per <see cref="ContentScale" />, this would be <c>4.0</c>. This is because we're scaling once to
    /// account for the fact that the application has twice the amount of pixels available to it for the given window
    /// size, and then scaling again so that what we are drawing appears zoomed in as per the user's request. Note that
    /// it is rarely the case that an operating system employs both dense pixels <i>and</i> content scale. macOS for
    /// instance, instead of setting <see cref="ContentScale" />, opts to scale the resolution in the cases where the
    /// user wants magnified visuals instead of having the applications scale their content; whereas Windows sets
    /// <see cref="ContentScale" /> and instead always keeps <see cref="PixelDensity" /> as <c>1.0</c>. This is down
    /// to philosophical differences between the window coordinate systems on platforms as to whether they prefer to
    /// deal in physical device pixels or physical content sizes.
    /// </remarks>
    float DrawScale { get; }

    /// <summary>
    /// Gets the ratio of pixels rendered to window size. This shall be equivalent to
    /// <see cref="Surface.DrawableSize" /> divided by <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    /// <seealso cref="DrawScale" />
    float PixelDensity { get; }
}

/// <summary>
/// Provides the ability to spawn children surfaces.
/// </summary>
public interface ISurfaceChildren
{
    /// <summary>
    /// Spawns an application to run within a new child surface. This call shall not block.
    /// </summary>
    /// <typeparam name="T">The application to run within the child surface.</typeparam>
    void Spawn<T>()
        where T : ISurfaceApplication;
}
