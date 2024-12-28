namespace Silk.NET.Windowing;

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

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
    /// Gets a value indicating whether the surface is terminating irrevocably.
    /// </summary>
    /// <seealso cref="ISurfaceWindow.IsCloseRequested" />
    public abstract bool IsTerminating { get; }

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
    protected internal virtual void OnTick()
    {
        TimeCheck(ref _lastTick, 0, out var diff);
        Tick?.Invoke(new SurfaceTimingEvent(this, diff / (double)Stopwatch.Frequency));
        OnUpdate();
        OnRender();
    }

    /// <summary>
    /// Executes the <see cref="Render" /> event if the constraints defined in <see cref="RenderOptions" /> are met.
    /// </summary>
    protected internal virtual void OnRender()
    {
        if (
            !TimeCheck(ref _lastRender, _renderFrequency, out var diff)
            && OpenGL is not { IsEnabled: true, VSync: true }
        )
        {
            return;
        }

        Render?.Invoke(new SurfaceTimingEvent(this, diff / (double)Stopwatch.Frequency));
        if (OpenGL is { IsEnabled: true, IsCurrent: true, ShouldSwapAutomatically: true })
        {
            OpenGL.SwapBuffers();
        }
    }

    /// <summary>
    /// Executes the <see cref="Update" /> event if the constraints defined in <see cref="UpdateOptions" /> are met.
    /// </summary>
    protected internal virtual void OnUpdate()
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
