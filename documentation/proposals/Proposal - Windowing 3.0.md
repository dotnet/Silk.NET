# Summary

Cross-platform windowing for Silk.NET rebuilt from the ground-up.

# Contributors
- Dylan Perks (@Perksey)
- Kai Jellinghaus (@HurricanKai)

# Current Status
- [x] Proposed
- [x] Discussed with Community
- [x] Approved
- [x] Implemented

# Dependencies

This proposal assumes knowledge of the Generic Math proposal and the previous version of this proposal.

# Background

Since its inception, Silk.NET has offered high-level windowing, input, and maths APIs to help address common pain points
when using .NET to implement a cross-platform game/engine. These are referred to collectively as the High Level
Utilities (HLU). The Windowing HLU seeks to reduce as much friction as possible in targeting the .NET platform for a
game by providing a high-level, C#-friendly API that has *getting out of the developer's way* as the top priority. That
is, we didn't want our developers to have to learn the intricacies of each target platform and write code to account for 
that, and we also didn't want to add unnecessary complexity to their applications and development process by making them
learn a cross-platform abstraction library such as SDL, increasing the amount of unfamiliar, non-C#-friendly code in
their codebase beyond the surface the developer is actually interested in: their game/engine code. The HLUs seek to
reduce boilerplate that fits this description.

This tenet of "getting out of their way" shall guide the majority of this proposal. This forms the "Usability" tenet as
defined in the Working Group approved 3.0 Software Development Plan, and shall prevail above all else for the purposes
of designing the HLUs. The other relevant tenets for the purposes of the HLU are naturally derived from this
"getting out of their way" concept.

For history, in Silk.NET 1.0 we sought to create a C#-friendly Windowing abstraction. Admittedly, we didn't think this
through beyond trying to match the feature set of OpenTK - Silk.NET's predecessor and the project for which most of
Silk.NET's founding team were originally the leading contributors. OpenTK implemented this API by having a `GameWindow`
class that would be inherited from by the user, and the user instantiating that class and calling a `Run` function
(inherited from `GameWindow`, which would do the actual platform interactions) in their `Main` function. This
separated the window interactions from the window creation. For this, and a variety of other reasons that sadly have
been lost to time (primarily because they were discussed at length in voice chat, not text chat), we were not fully
satisfied with our work at OpenTK and given that Silk.NET was a brand new project, it gave us an opportunity to
re-evaluate the needs for such an API and the design decisions therefor.

Ultimately, we knew that creating a window to draw in is something that the vast majority Silk.NET users needed to do.
Users could use libraries such as GLFW and SDL to achieve this, but we acknowledged that these require a
not-insignificant amount of code and/or API-specific knowledge. As such, we sought to write a GLFW wrapper (as we felt
this was the best stable base available at the time for our needs, and there was no appetite for maintaining
platform-specific code ourselves and the bugs thereof), and we wanted to make this as "obvious" a design as possible.
To this end, the user would create a window (as a resource that they'd own and could fit into whatever designs they
pleased, as opposed to a component/class that they'd define and use through inheritance) and have a working render loop
in as little as three lines. This wrapper did not expose any of the underlying GLFW details through its API surface as
we wanted to have maximal portability should we choose to change the underlying library in use.

This 1.0 implementation was very successful, and later in the 1.0 preview cycle we started considering how to implement
the windowing API on more platforms such as mobile and UWP. This resulted in the `IView` API being created, as `IWindow`
contained a lot of APIs that only made sense where you had the ability to create many windows within the context of a
window manager, as opposed to the mobile/UWP use case where a single window is bestowed upon the application _by_ the
window manager i.e. the application has no control over that window's attributes e.g. sizing, positioning, window modes,
etc. 

Silk.NET 1.0 shipped with this `IView`/`IWindow` split, followed by Silk.NET 2.0 which implemented only the former on
mobile platforms, as opposed to desktop platforms which implemented both (`IView` is a subset of `IWindow`). This left a
lot to be desired given that a lot of code (including our own examples) had already been written against `IWindow`
instead of `IView`, and writing for the latter is something that the developer would have to go out of their way to do.
This is contrary to 3.0's goal of promoting write-once-run-everywhere.

# Overview

In 3.0 we'd like to have an architecture that promotes write-once-run-everywhere, by encouraging our users to deal with
some feature sets not being available. With `IWindow` today, it's far too easy to assume that you're able to change the
window size for instance, and it is not immediately obvious that the user should actually create an `IView` and only use
those APIs if the user has checked `view is IWindow`. Instead, this proposal breaks the windowing API down into the
concept of having an abstract "surface" representing a draw area that has been allotted to the application by the
operating system/window manager, and splits the extant API surface up into distinct "components" that the user can
access on this "surface". For example, instead of `IWindow.Size = new(1280, 720)`, the user would use
`Surface.Window.ClientSize = new(1280, 720)` where `Bounds` is an optional component on that surface. Because that
component is optional, nullable reference types shall be used, which will encourage the user to deal with the scenario
in which that component is not present as a result of the IDE warnings that would be generated by making an assumption
of its presence. This provides the write-once-run-everywhere encouragement we're after.

The Working Group may recall that they have already approved a version of this proposal that met some of these goals,
originally designed by Dylan P and Kai J. Both of us were not fully satisfied with this proposal as this still used the
type system to expose differing feature sets rather than having a component breakdown, and we were not convinced that
this will have the encouragement of write-once-run-everywhere we wanted due to the relative uncleanliness of using the
type system in this way, with non-obvious separations of functionality within the types exposed by that proposal.
Nonetheless, this was proposed to the Working Group and approved, lacking a better alternative at the time.
We believe that the component breakdown in this proposal presents that better alternative we are looking for however,
hence the new version of the proposal.

## A Note on the Component-Based Design Regarding Implementations

During the development of this proposal, we were keen to try and find a way to not only present the high-level API in
this component-based design, but also a lower-level API upon which the high-level API would be implemented. Development
of this lower-level API was taking time however, and a concrete shape for this API couldn't be determined. Given that
this is mostly an implementation detail/nicety that would make future expansion of the API easier, we chose not to make
this a blocker for the 3.0 release and will instead propose this at a later date in a separate proposal - we do not
believe that anything in this proposal restricts the retro-fitting of such a design.

# Platforms

There shall only be one `Silk.NET.Windowing` project for the Windowing HLU that defines the abstractions and exactly one
"reference implementation". This is a departure from previous versions where the abstractions were separate from the
implementations. If the reference implementation is not needed, it is expected that the linker shall remove it from the
end assembly. Generally, Silk.NET favours embracing readily available tooling such as the linker over architectural
decisions in lieu of tooling, and given that .NET 8 makes using the linker extremely easy, this has dictated a fair few
decisions in the library's development.

The "reference implementation" shall use SDL3, but the Silk.NET team reserves the right to change this for some or all
of the target platforms. It is expected that platform differentiation is done by TFM (e.g. `net8.0`, `net8.0-windows`,
`net8.0-ios`, etc) but this could include runtime identifier based differentiation in the future. The Silk.NET team
reserves all rights to determine implementation details such as this.

Silk.NET 3.0 aims to support Windows, Linux (X/11 and Wayland), macOS, iOS, and Android. The goal of this proposal is to
do so in a way that requires no _modification_ of user code. It is highly likely that _additional_ boilerplate code will
be needed on some platforms (e.g. `MainActivity`) but this should not be variant based on the user's specific
application i.e. it should work as is when copied and pasted into the user's application.

To promote write-once-run-everywhere, in order to use Silk.NET.Windowing the user must first implement
`ISurfaceApplication` and call `ISurfaceApplication.Run`. These are defined as follows:

```cs
namespace Silk.NET.Windowing;

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
    static abstract void Initialize<TSurface>(TSurface surface) where TSurface : Surface;

    /// <summary>
    /// Runs an application using the reference implementation of Silk.NET.Windowing.
    /// </summary>
    [UnsupportedOSPlatform("android")]
    public static sealed void Run<T>() where T : ISurfaceApplication;
}

#if __ANDROID__
/// <summary>
/// Represents an Android activity that automatically runs the given application.
/// </summary>
public abstract class SilkActivity<TApplication> /* : undefined */ where TApplication : ISurfaceApplication;
#endif
```

Expected to be used as follows (e.g. in `Program.cs`):
```cs
public class Program : ISurfaceApplication
{
    public static void Initialize<TSurface>(TSurface surface) where TSurface : Surface
    {
        // Code goes here. The code must return for the render loop to begin.
    }

    public static void Main() => ISurfaceApplication.Run<Program>();
}
```

In addition to the following `Platforms/Android/MainActivity.cs` file on Android:
```cs
[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : SilkActivity<Program>;
```

The application receives an `Surface`. This will be defined partially throughout this file.

**NOTE**: The concept of the "gluer" - a source generator that generates the platform-specific classes - has been
omitted from the revised proposal due to there often being more platform-specific requirements in addition to just the
code, and given that the code-level platform-specific changes are as minimal as they are, adding one platform-specific
C# file has been deemed to be a benignant requirement.

# The Update Loop

Like 2.X, Silk.NET 3.0 takes control of the application's update loop by running user code as fast as possible. Unlike
2.X, Silk.NET 3.0 will not expose a blocking call to do this (other than the top-level `Run` call of course on the
platforms where that is used). However, we still want to empower users to implement their own loop _timing_ (i.e.
instead of using `Render` or `Update` events) and for this we require a way to run user code as fast as possible.
In 2.X this was the `onFrame` callback to `IWindow.Run(Action)`. In 3.0 this shall be the `Tick` event.

**NOTE**: This proposal originally added a `ISurfaceActor` that implemented the actor pattern as used in the
Multi-Backend Input proposal, but given that there's no benefits today for windowing specifically in doing this it was
removed. The event structs first introduced in Enhanced Input Events and retained in Multi-Backend Input has been
carried forward into this proposal to ensure that we take advantage of the same breaking change resistance benefits.

```cs
namespace Silk.NET.Windowing;

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
public abstract partial class Surface
{
    /// <summary>
    /// An event raised as frequently as possible (or in line with <see cref="TickOptions" />).
    /// </summary>
    public event Action<SurfaceTimingEvent> Tick { add; remove; }

    /// <summary>
    /// An event raised in accordance with <see cref="RenderOptions" /> with the intention of providing the application
    /// an opportunity to redraw its graphics within the surface.
    /// </summary>
    public event Action<SurfaceTimingEvent> Render { add; remove; }

    /// <summary>
    /// An event raised in accordance with <see cref="UpdateOptions" /> with the intention of providing the application
    /// an opportunity to redraw its graphics within the surface.
    /// </summary>
    public event Action<SurfaceTimingEvent> Update { add; remove; }

    /// <summary>
    /// An event executed when the surface is first loaded.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent> Created { add; remove; }

    /// <summary>
    /// An event executed when the surface and the application thereof are about to terminate irrevocably.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent> Terminating { add; remove; }

    /// <summary>
    /// An event executed when the surface and the application thereof are pausing on request of the operating system.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent> Pausing { add; remove; }

    /// <summary>
    /// An event executed when the surface and the application thereof are resuming on request of the operating system.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent> Resuming { add; remove; }

    /// <summary>
    /// An event executed when the operating system indicates the amount of memory that can be allocated for the
    /// application running the surface is low.
    /// </summary>
    public abstract event Action<SurfaceLifecycleEvent> LowMemory { add; remove; }

    /// <summary>
    /// Gets or sets additional configuration/constraints for the <see cref="Tick" /> event.
    /// </summary>
    public abstract SurfaceTickOptions TickOptions { get; set; }

    /// <summary>
    /// Gets or sets additional configuration/constraints for the <see cref="Render" /> event.
    /// </summary>
    public virtual SurfaceTimingOptions RenderOptions { get; set; }

    /// <summary>
    /// Gets or sets additional configuration/constraints for the <see cref="Update" /> event.
    /// </summary>
    public virtual SurfaceTimingOptions UpdateOptions { get; set; }

    /// <summary>
    /// Gets or sets a value representing <see cref="RenderOptions" />.<see cref="SurfaceTimingOptions.TargetDelta" />
    /// as a number of executions per second.
    /// </summary> 
    public int FramesPerSecond { get; set; }

    /// <summary>
    /// Gets or sets a value representing <see cref="UpdateOptions" />.<see cref="SurfaceTimingOptions.TargetDelta" />
    /// as a number of executions per second.
    /// </summary>
    public int UpdatesPerSecond { get; set; }

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

    /// <summary>
    /// Executes the <see cref="Tick" /> event. This will also call <see cref="OnUpdate" /> and <see cref="OnRender" />.
    /// </summary>
    protected internal virtual void OnTick();

    /// <summary>
    /// Executes the <see cref="Render" /> event if the constraints defined in <see cref="RenderOptions" /> are met.
    /// </summary>
    protected internal virtual void OnRender();

    /// <summary>
    /// Executes the <see cref="Update" /> event if the constraints defined in <see cref="UpdateOptions" /> are met.
    /// </summary>
    protected internal virtual void OnUpdate();

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
    /// Raised when <see cref="DrawableSize" /> changes.
    /// </summary>
    public abstract event Action<SurfaceResizeEvent> DrawableSizeChanged { add; remove; }

    /// <summary>
    /// Centers this window to the given monitor or, if null, the current monitor the window's on.
    /// </summary>
    /// <param name="window">The window to center.</param>
    /// <param name="display">The specific display to center the window to, if any.</param>
    public void Center(IDisplay? display = null);

    /// <summary>
    /// Converts a point that is defined in the same coordinate space as <see cref="IDisplay.Bounds" /> to instead be
    /// defined relative to <see cref="ISurfaceWindow.ClientArea" />. Requires both <see cref="Window" /> and
    /// <see cref="Display" /> components to be supported, if not <paramref name="point" /> shall be returned as is.
    /// </summary>
    /// <param name="point">The point to transform.</param>
    /// <returns>The transformed point.</returns>
    Vector2 ScreenToClient(Vector2 point);

    /// <summary>
    /// Converts a point that is defined relative to <see cref="ISurfaceWindow.ClientArea" /> to instead be defined in the
    /// same coordinate space as <see cref="IDisplay.Bounds" />. Requires both <see cref="Window" /> and
    /// <see cref="Display" /> components to be supported, if not <paramref name="point" /> shall be returned as is.
    /// </summary>
    /// <param name="point">The point to transform.</param>
    /// <returns>The transformed point.</returns>
    Vector2 ClientToScreen(Vector2 point);

    /// <summary>
    /// Converts a point that is defined relative to <see cref="ISurfaceWindow.ClientArea" /> by multiplying it with the
    /// division of <see cref="DrawableSize" /> by <see cref="ISurfaceWindow.ClientArea" />'s size.  
    /// </summary>
    /// <param name="point">The point to transform.</param>
    /// <returns>The transformed point.</returns>
    Vector2 ClientToDrawable(Vector2 point);
}
```

The implementation shall call `Surface.OnTick` as fast as possible. On platforms where the application must be started
manually (any platform other than Android), it is expected that this continuous calling of `OnTick` will be called
continuously in `ISurfaceApplication.Run` for the reference implementation, or an equivalent API in an alternative
implementation. This could be through a `while` loop or through a platform-defined mechanism (the latter most notably
being the case for iOS and Android). This shall be the case except where `TickOptions.IsEventDriven` is `true`, in which
case `OnTick` shall only be called in response to an event or in response to `Continue` being called on any thread if
the platform supports this. 

All events defined throughout this document shall be raised by the implementation if they are declared with the
`abstract` keyword or are part of an `interface`. Any events not declared with `abstract` shall be raised by the common
`Surface` code.

It is expected that the timing logic be common code i.e. all of these APIs shall be implemented in `Surface` and not a
derived type. `FramesPerSecond` and `UpdatesPerSecond` shall to forward to `RenderOptions.TargetDelta` and
`UpdateOptions.TargetDelta` respectively with the value of `1 / value`. `SurfaceTimingOptions` has been introduced for
future proofing in the event that we want to add more options such as executing one of the events on a different thread
(e.g. as in Silk.NET 1.X when the `UseSingleThreadedWindow` option was set to `false`). These settings shall default to
run as fast as possible. A `TargetDelta` value close to zero or a negative number is interpreted to mean run as fast as
possible. This shall be represented by `FramesPerSecond`/`UpdatesPerSecond` as a negative number. A `TargetDelta` value
close to `double.MaxValue` shall be interpreted to mean "never execute". This shall be represented by
`FramesPerSecond`/`UpdatesPerSecond` as zero. The `OnRender` and `OnUpdate` methods shall raise the `Render` and
`Update` events respectively, which the implementation has the opportunity to override.

# Optional vs Mandatory APIs

Mandatory APIs are denoted by the `abstract` keyword. Optional APIs are denoted by a `virtual` keyword. Generally, where
APIs are optional, they also have another mechanism to define runtime optionality e.g. gating the APIs through a
nullable property. In addition to the `abstract` members on `Surface` already defined above, the following mandatory
APIs are specified:

```cs
namespace Silk.NET.Core;

/// <summary>
/// Represents a window that possesses native handles or other platform-specific information.
/// </summary>
public interface INativeWindow
{
    /// <summary>
    /// Attempts to obtain native platform information with type <typeparamref name="TPlatformInfo" />.
    /// </summary>
    /// <param name="info">
    /// The platform-specific information, or <c>default</c> if the platform-specific information is not available for
    /// this platform.
    /// </param>
    /// <returns>True if <paramref name="info" /> contains the platform-specific information, false otherwise.</returns> 
    bool TryGetPlatformInfo<TPlatformInfo>([NotNullWhen(true)] out TPlatformInfo? info);
}

namespace Silk.NET.Windowing;

public abstract partial class Surface : INativeWindow;
```

The Silk.NET team reserve the right to define the acceptable types for `TPlatformInfo`.

The only mandatory APIs are those inherited from `INativeWindow` and the `abstract` APIs already defined above. There
are no other useful APIs that are guaranteed to be available on all platforms.

The rest of the APIs herein are optional, the conditions of their support denoted with their definition. These will be
categorised into logical subsets, or a "component" interface. These shall be accessed via nullable properties.

Herein for simplicity the expected functionality will be listed in the documentation comments except where there are
complex interactions.

# The OpenGL Component

Oftentimes the mechanism by which an OpenGL surface is created is platform-specific in nature, and our implementation
libraries often have abstractions as a result. To make this easier for the user, we shall introduce a similar
abstraction below as with all previous Silk.NET versions.

```cs
namespace Silk.NET.Core;

/// <summary>
/// Represents an OpenGL context.
/// </summary>
public interface IGLContext : INativeContext
{
    /// <summary>
    /// Whether the context is current on this thread.
    /// </summary>
    bool IsCurrent { get; set; }

    /// <summary>
    /// The number of vertical blanks to wait for before sending another frame.
    /// </summary>
    int SwapInterval { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether <see cref="SwapInterval" /> is non-zero.
    /// </summary>
    bool VSync { get => SwapInterval > 0; set => SwapInterval = value ? 1 : 0; }

    /// <summary>
    /// Swaps the backbuffer to present the contents to the window.
    /// </summary>
    void SwapBuffers();
}

/// <summary>
/// Represents a source of a <see cref="IGLContext" />
/// </summary>
// Same as in 1.X/2.X, just a different namespace.
public interface IGLContextSource
{
    /// <summary>
    /// The OpenGL context.
    /// </summary>
    IGLContext? GLContext { get; }
}

/// <summary>
/// A 32-bit version structure.
/// </summary>
public readonly struct Version32
{
    /// <summary>
    /// The underlying Vulkan-compatible 32-bit version integer.
    /// </summary>
    public uint Value { get; }
    
    /// <summary>
    /// Creates a Vulkan version structure from the given major, minor, and patch values.
    /// </summary>
    /// <param name="major">The major value.</param>
    /// <param name="minor">The minor value.</param>
    /// <param name="patch">The patch value.</param>
    public Version32(uint major, uint minor, uint patch);
    
    /// <summary>
    /// Creates a Vulkan version structure from the given Vulkan-compatible value.
    /// </summary>
    /// <param name="value">The value.</param>
    private Version32(uint value);
    
    /// <summary>
    /// Gets the major component of this version structure.
    /// </summary>
    public uint Major { get; }
    
    /// <summary>
    /// Gets the minor component of this version structure.
    /// </summary>
    public uint Minor { get; }
    
    /// <summary>
    /// Gets the patch component of this version structure.
    /// </summary>
    public uint Patch { get; }
    
    /// <summary>
    /// Creates a 32-bit version structure from the given 32-bit unsigned integer.
    /// </summary>
    /// <param name="val">The uint value.</param>
    /// <returns>The 32-bit version structure.</returns>
    public static explicit operator Version32(uint val);

    /// <summary>
    /// Creates a 32-bit version structure from the given managed version class.
    /// </summary>
    /// <param name="version">The version instance.</param>
    /// <returns>The 32-bit version structure.</returns>
    public static implicit operator Version32(Version version);

    /// <summary>
    /// Gets the 32-bit unsigned integer representation for this 32-bit version structure.
    /// </summary>
    /// <param name="version">The 32-bit version structure.</param>
    /// <returns>The 32-bit unsigned integer.</returns>
    public static implicit operator uint(Version32 version);

    /// <summary>
    /// Converts this 32-bit version structure to a managed version class.
    /// </summary>
    /// <param name="version">The 32-bit version structure.</param>
    /// <returns>The managed representation.</returns>
    public static implicit operator Version(Version32 version);
}

namespace Silk.NET.OpenGL;

/// <summary>
/// Contains extensions for creating <see cref="GL" /> instances from <see cref="IGLContext" />s and related types.
/// </summary>
public static class GLContextExtensions
{
    /// <summary>
    /// Creates a <see cref="GL" /> using function addresses sourced from the given <see cref="IGLContext" />.
    /// </summary>
    /// <param name="ctx">The context to use for function pointer loading.</param>
    /// <returns>A <see cref="GL" /> instance.</returns>
    public static GL CreateOpenGL(this IGLContext ctx);

    /// <summary>
    /// Creates a <see cref="GL" /> using function addresses sourced from the given <see cref="IGLContextSource" />.
    /// </summary>
    /// <param name="ctx">The source of the context to use for function pointer loading.</param>
    /// <returns>A <see cref="GL" /> instance.</returns>
    public static GL CreateOpenGL(this IGLContextSource ctx);
}

namespace Silk.NET.Windowing;

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
    ForwardCompatible = 1 << 1
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
    ES2
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
        set => value
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

public abstract partial class Surface : IGLContextSource
{
    /// <summary>
    /// Gets the OpenGL configuration of the surface, if supported.
    /// </summary>
    public virtual ISurfaceOpenGL? OpenGL { get; }
    IGLContext? IGLContextSource.GLContext => OpenGL;
} 
```

Expected to be used as follows:
```cs
public class Program : ISurfaceApplication
{
    public static void Initialize<TSurface>(TSurface surface) where TSurface : Surface
    {
        if (surface.OpenGL is null)
        {
            throw new NotSupportedException("OpenGL is not supported on this platform!");
        }

        // Try desktop GL (but also instead of doing this, try to use OpenGLContextProfile.Default which will
        // automatically use either desktop GL or GLES)
        surface.OpenGL.Profile = OpenGLContextProfile.Core;
        surface.OpenGL.Version = new(3, 3);
        if (!surface.OpenGL.IsSupported)
        {
            // Try GLES.
            surface.OpenGL.Profile = OpenGLContextProfile.ES2;
            surface.OpenGL.Version = new(3, 0);
            if (!surface.OpenGL.IsSupported)
            {
                throw new NotSupportedException("OpenGL driver doesn't support a high enough version!")
            }
        }

        GL gl = null!;
        surface.Created += _ =>
        {
            gl = surface.CreateOpenGL();
            gl.Enable(EnableCap.DebugOutput);
            // ...
        };

        // OpenGL context is created once this function exits.
    }

    public static void Main() => ISurfaceApplication.Run<Program>();
}
```

# The Window Component

A surface may be drawn within one window of many in a window manager. If the platform supports this, the window
component grants the user control over their presentation and behaviour within that window manager.

```cs
namespace Silk.NET.Windowing;

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
    Silk.NET.Maths.RectangleF<float> OldBounds,
    Silk.NET.Maths.RectangleF<float> NewBounds,
    Silk.NET.Maths.RectangleF<float> OldClientArea,
    Silk.NET.Maths.RectangleF<float> NewClientArea
) {
    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.Size" />.
    /// </summary>
    public Vector2 OldSize => OldBounds.Size;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.Size" />.
    /// </summary>
    public Vector2 NewSize => NewBounds.Size;

    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    public Vector2 OldClientSize => OldClientArea.Size;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    public Vector2 NewClientSize => NewClientArea.Size;

    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.Position" />.
    /// </summary>
    public Vector2 OldPosition => OldBounds.Min;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.Position" />.
    /// </summary>
    public Vector2 NewPosition => NewBounds.Min;
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
    /// The window has been fullscreened, covering the entire surface of the monitor without a border, with exclusive
    /// control over the display. Note that changing to/from this state may enact an implicit change to
    /// <see cref="ISurfaceDisplay" />'s state if supported.
    /// </summary>
    ExclusiveFullscreen,

    /// <summary>
    /// The window has been fullscreened, covering the entire surface of the monitor, but still uses window management
    /// to allow the user to interoperate with other applications easily. This setting leads the
    /// <see cref="ISurfaceWindow.Border" /> setting to be ignored, as this setting is functionally equivalent to
    /// <see cref="Maximized" /> and a <see cref="WindowBorder.Hidden" /> border.
    WindowedFullscreen
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
public readonly record struct WindowStateEvent(Surface Surface, WindowState OldState, WindowState NewState);

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

    /// <summary>
    /// Creates a window icon with just one variant.
    /// </summary>
    public WindowIconVariants(WindowIcon icon);

    /// <summary>
    /// Gets or sets the window icon variant at the given index.
    /// </summary>
    public WindowIcon this[int index] { get; set; }

    /// <summary>
    /// Gets the number of variants within this window icon.
    /// </summary>
    public int Count { get; }

    /// <summary>
    /// Adds a variant.
    /// </summary>
    /// <param name="icon">The variant to add.</param>
    public void Add(WindowIcon icon);

    /// <summary>
    /// Removes the variant at the given index.
    /// </summary>
    /// <param name="i">The index to remove at. All elements thereafter will be shifted left by one.</param>
    public void RemoveAt(int i);

    /// <summary>
    /// Converts a <see cref="WindowIcon" /> into a <see cref="WindowIconVariants" /> with one variant.
    /// </summary>
    /// <param name="icon">The icon.</param>
    /// <returns>The single-variant <see cref="WindowIconVariants" /> incorporating <paramref name="icon" /></returns>
    public static implicit operator WindowIconVariants(WindowIcon icon);

    /// <summary>
    /// Enumerates the variants contained within this <see cref="WindowIconVariants" />.
    /// </summary>
    /// <returns>An enumerator.</returns>
    public Enumerator GetEnumerator();

#if NET9_0_OR_GREATER
    // Will return byte[,] elements, this is only implemented to make collection/initializer expressions to light up.
    // Not implementing the generic interface to further discourage use.
    // Ref structs can only implement interfaces as of C# 13/.NET 9
    IEnumerator IEnumerable.GetEnumerator();
#endif

    /// <summary>
    /// An enumerator over <see cref="WindowIcon" />s contained in <see cref="WindowIconVariants" />. This can only be
    /// created using <see cref="GetEnumerator" />.
    /// </summary>
    public ref struct Enumerator
    {
        /// <summary>
        /// The output from <see cref="MoveNext" /> if that returned <c>true</c>.
        /// </summary>
        public WindowIcon Current { get; }

        /// <summary>
        /// Retrieves the next variant. This must be called before reading the first element (and every subsequent
        /// element).
        /// </summary>
        public bool MoveNext();

        /// <summary>
        /// Resets the enumerator back to its initial state. Note that <see cref="MoveNext" /> must be called before
        /// retrieving an element again.
        /// </summary>
        public void Reset();
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
    Hidden
}

public interface ISurfaceWindow
{
    /// <summary>
    /// Gets the window bounds including the window border.
    /// </summary>
    Silk.NET.Maths.RectangleF<float> Bounds { get; set; }

    /// <summary>
    /// Forwards to the <see cref="Silk.NET.Maths.RectangleF{T}.Size" /> component of <see cref="Bounds" />.
    /// </summary>
    // DIM is required, but this implementation is for illustrative purposes only! Exact resize semantics of silk types
    // are yet to be defined.
    Vector2 Size { get => Bounds.Size; set => Bounds = Bounds with { Size = value }; }

    /// <summary>
    /// Forwards to the <see cref="Silk.NET.Maths.RectangleF{T}.Min" /> component of <see cref="Bounds" />.
    /// </summary>
    // DIM is required, but this implementation is for illustrative purposes only! Exact resize semantics of silk types
    // are yet to be defined.
    Vector2 Position { get => Bounds.Min; set => Bounds = Bounds with { Min = value }; }

    /// <summary>
    /// Gets only the inner client area of the window in <b>screen coordinates</b>. For <i>pixels</i>, use
    /// <see cref="Surface.DrawableSize" /> or the relevant properties of <see cref="Surface.Scaling" />.
    /// </summary>
    /// <remarks>
    /// Setting this property is interpreted to mean changing <see cref="Bounds" /> by the same delta in the hopes of
    /// achieving the desired result.
    /// </remarks>
    Silk.NET.Maths.RectangleF<float> ClientArea { get; set; }

    /// <summary>
    /// Forwards to the <see cref="Silk.NET.Maths.RectangleF{T}.Size" /> component of <see cref="ClientArea" />.
    /// </summary>
    /// <remarks>
    /// Setting this property is interpreted to mean changing <see cref="Size" /> by the same delta in the hopes of
    /// achieving the desired result.
    /// </remarks>
    Vector2 ClientSize { get => ClientArea.Size; set => ClientArea = ClientArea with { Size = value }; }

    /// <summary>
    /// Raised when <see cref="Bounds" /> and/or <see cref="ClientArea" /> changes.
    /// </summary>
    event Action<WindowCoordinatesEvent> CoordinatesChanged { add; remove; }

    /// <summary>
    /// Gets or sets a value indicating whether, unless set to <c>false</c> before the next <see cref="Surface.Tick" />,
    /// the window will close resulting in the irrevocable termination of the surface.
    /// </summary>
    bool IsCloseRequested { get; set; }

    /// <summary>
    /// Raised when <see cref="IsCloseRequested" /> is set to <c>true</c>.
    /// </summary>
    event Action<WindowToggleEvent> CloseRequested { add; remove; }

    /// <summary>
    /// Gets or sets a value indicating whether the window is visible.
    /// </summary>
    bool IsVisible { get; set; }

    /// <summary>
    /// Raised when <see cref="IsVisible" /> changes.
    /// </summary>
    event Action<WindowToggleEvent> VisibilityChanged { add; remove; }

    /// <summary>
    /// Gets or sets a value indicating whether the window currently has input focus. If setting to <c>true</c>, the
    /// window will likely be raised atop other windows in order to obtain input focus. Setting to <c>false</c> is not
    /// guaranteed to do anything.
    /// </summary>
    bool IsFocused { get; set; }

    /// <summary>
    /// An event raised when <see cref="IsFocused" /> changes.
    /// </summary>
    event Action<WindowToggleEvent> FocusChanged { add; remove; }

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
    event Action<WindowStateEvent> StateChanged { add; remove; }

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
    event Action<WindowFileEvent> FileDrop { add; remove; }

    /// <summary>
    /// Sets the window's icon to one of the window icons provided. The icon is selected using an undefined mechanism by
    /// the underlying platform, typically taking into account the pixel size of each variant. If no icon variants are
    /// provided, then the default icon shall be restored.
    /// </summary>
    /// <param name="icon">The window icon variants to set.</param>
    /// <returns>A value indicating whether the operation was successful.</returns>
    bool TrySetIcon(WindowIconVariants icon);
}

public abstract partial class Surface
{
    /// <summary>
    /// Gets the window in which the surface is rendering.
    /// </summary>
    public virtual ISurfaceWindow? Window { get; }
}
```

Expected to be used as follows:
```cs
public class Program : ISurfaceApplication
{
    public static void Initialize<TSurface>(TSurface surface) where TSurface : Surface
    {
        if (surface.Window is not null)
        {
            // Window icon with a single variant
            surface.Window.TrySetIcon(new WindowIcon { Width = 16, Height = 16, Data = /* etc */ });
            
            // Window icon with multiple variants (pre-C# 13/.NET 9)
            WindowIconVariants variants = new WindowIcon { Width = 16, Height = 16, Data = /* etc */ };
            variants.Add(new WindowIcon { Width = 32, Height = 32, Data = /* etc */ });
            surface.Window.TrySetIcon(variants);

            // Window icon with multiple variants (post-C# 13/.NET 9)
            surface.Window.TrySetIcon([new WindowIcon { Width = 16, Height = 16, Data = /* etc */ }, new WindowIcon { Width = 32, Height = 32, Data = /* etc */ }]);

            // Request windowed fullscreen.
            surface.Window.Border = WindowBorder.Hidden;
            surface.Window.State = WindowState.Maximized;
        }
    }

    public static void Main() => ISurfaceApplication.Run<Program>();
}
```

# The Displays Component

A surface may be rendered on one of many displays. This component allows a surface to access information about the
display on which it's rendering, move to another display, and/or change the video mode of the display.

```cs
namespace Silk.NET.Windowing;

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
/// Contains properties pertaining to a surface changing to a different video mode.
/// </summary>
/// <param name="Surface">The surface changing to a different video mode.</param>
/// <param name="VideoMode">The video mode the surface has changed to.</param>
public readonly record struct VideoModeChangeEvent(Surface Surface, VideoMode VideoMode);

/// <summary>
/// Contains properties pertaining to a change in the available video modes for a display.
/// </summary>
/// <param name="Surface">The surface owning the display.</param>
/// <param name="Display">The display for which the video mode availability changed.</param>
// I don't think we need to have a diff here either, why would old video modes be relevant?
public readonly record struct DisplayVideoModeAvailabilityChangeEvent(Surface Surface, IDisplay Display);

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
    Silk.NET.Maths.RectangleF<float> OldBounds,
    Silk.NET.Maths.RectangleF<float> NewBounds,
    Silk.NET.Maths.RectangleF<float> OldWorkArea,
    Silk.NET.Maths.RectangleF<float> NewWorkArea
);

/// <summary>
/// Represents the properties of a surface whose rendering is intrinsically linked to the composition of a specific
/// display. In most cases, this translates to "the surface is rendering in exclusive fullscreen mode".
/// </summary>
/// <param name="Index">The index of the video mode in <see cref="IDisplay.KnownVideoModes" />.</param>
/// <param name="Resolution">
/// The resolution the surface is rendering on its display at, if known. If <c>null</c>, it is highly likely that the
/// surface is not rendering in exclusive fullscreen mode or otherwise has its rendering intrinsically linked to the
/// composition of a specific display.
/// </param>
/// <param name="RefreshRate">
/// The rate (per second) at which the physical display will receive new renders from the surface, if known. If
/// <c>null</c>, the platform may not expose the refresh rate to surfaces or it is highly likely that the
/// surface is not rendering in fullscreen mode or otherwise has its rendering intrinsically linked to the composition
/// of a specific display.
/// </param>
/// <remarks>
/// If a <c>default</c> video mode is encountered, it is highly likely the surface is not rendering in exclusive
/// fullscreen mode. If an individual property is <c>null</c>, it is highly likely that property is not controllable
/// programmatically.
/// </remarks>
public readonly record struct VideoMode(int Index, Vector2? Resolution, float? RefreshRate);

/// <summary>
/// Represents a display on which a surface can be rendered.
/// </summary>
/// <remarks>
/// Each surface shall get its own <see cref="IDisplay" /> object for each display. This is primarily to ensure that
/// users get events dispatched with the surface they expect depending on which <see cref="ISurfaceDisplay" /> the
/// <see cref="IDisplay" /> was sourced from. However, display objects can be somewhat shared between all surfaces that
/// share a common ancestor (the "root surface"). Specifically, an object at a given index in
/// <see cref="ISurfaceDisplay.Available" /> on one surface shall be equatable to the object sourced from the same index
/// in <see cref="ISurfaceDisplay.Available" /> on another surface with the same root surface. Furthermore,
/// <see cref="ISurfaceDisplay.Current" /> on one surface shall be assignable to an <see cref="IDisplay" /> object
/// sourced from another surface with the same root surface, where <see cref="ISurfaceDisplay.Current" /> shall lookup
/// the equivalent <see cref="IDisplay" /> object from its <see cref="ISurfaceDisplay.Available" /> displays upon
/// assignment.
/// </remarks>
public interface IDisplay : IEquatable<IDisplay>
{
    /// <summary>
    /// Gets the position and resolution of the monitor in screen space.
    /// </summary>
    Silk.NET.Maths.RectangleF<float> Bounds { get; }

    /// <summary>
    /// Gets the area within <see cref="Bounds" /> where surfaces are <i>intended</i> to be drawn.
    /// </summary>
    /// <remarks>
    /// This typically is the area left once you account for things like the menu bar and taskbar.
    /// </remarks>
    Silk.NET.Maths.RectangleF<float> WorkArea { get; }
    
    /// <summary>
    /// Gets a list of video modes known to be available when this display is <see cref="ISurfaceDisplay.Current" />.
    /// It may be the case that a list of video modes can't be determined until that's the case. Note that inclusion of
    /// a <see cref="VideoMode" /> in this list does not guarantee its presence in
    /// <see cref="ISurfaceDisplay.AvailableVideoModes" />, as this can depend on the state of other components.
    /// </summary>
    IReadOnlyList<VideoMode>? KnownVideoModes { get; }

    /// <summary>
    /// Gets a value indicating whether the user has designated this display their primary display.
    /// </summary>
    bool IsPrimary { get; }

    /// <summary>
    /// Gets a colloquial name for the display. This may change, but hopefully not to something the end user won't recognise.
    /// </summary>
    string Description { get; }

    /// <summary>
    /// An event raised when <see cref="Bounds" /> and/or <see cref="WorkArea" /> changes.
    /// </summary>
    event Action<DisplayCoordinatesEvent> CoordinatesChanged { add; remove; } 

    /// <summary>
    /// An event raised when <see cref="KnownVideoModes" /> changes.
    /// </summary>
    event Action<DisplayVideoModeAvailabilityChangeEvent> KnownVideoModesChanged { add; remove; }
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
    /// Gets a list of video modes known to be available when this display is <see cref="ISurfaceDisplay.Current" />.
    /// It may be the case that a list of video modes can't be determined until that's the case. Furthermore, if
    /// <see cref="ISurfaceWindow"/> is supported, <see cref="ISurfaceWindow.State"/> needs to be
    /// <see cref="WindowState.ExclusiveFullscreen"/> to get access to exclusive fullscreen video modes.
    /// <see cref="WindowState.WindowedFullscreen"/> may be acceptable if the backend supports implicitly switching
    /// between windowed and exclusive fullscreen states, but this is not a requirement.
    /// </summary>
    IReadOnlyList<VideoMode> AvailableVideoModes { get; }

    /// <summary>
    /// An event raised when <see cref="Current" /> changes.
    /// </summary>
    event Action<DisplayChangeEvent> CurrentDisplayChanged { add; remove; }

    /// <summary>
    /// An event raised when <see cref="Available" /> changes.
    /// </summary>
    event Action<DisplayAvailabilityChangeEvent> AvailableChanged { add; remove; }

    /// <summary>
    /// An event raised when <see cref="AvailableVideoModes" /> changes.
    /// </summary>
    event Action<DisplayVideoModeAvailabilityChangeEvent> AvailableVideoModesChanged { add; remove; }

    /// <summary>
    /// An event raised when <see cref="VideoMode" /> changes.
    /// </summary>
    event Action<VideoModeChangeEvent> VideoModeChanged { add; remove; }
}

public abstract partial class Surface
{
    /// <summary>
    /// Gets the display configuration for the surface, if supported.
    /// </summary>
    public virtual ISurfaceDisplay? Display { get; }
}
```

`Gamma` has been removed due to upstream removal citing poor support in modern operating systems.

This proposal repeals the Window Hosts (Monitors) proposal from Silk.NET 1.0 Preview 4. All child surfaces must be
hosted by another surface or be the "root surface".

Note that there are some complex interactions with the `ISurfaceWindow.State` property and `VideoMode` given that the
former allows changing to exclusive fullscreen and the latter allows changing exclusive fullscreen mode. This raised a
number of questions about whether using the latter without the former should invoke implicit changes to the former.
Ultimately, it was decided that this would be bug prone and very hard to implement, as such the following requirements
are placed on implementors of this component:
- If the Window component is supported, `AvailableVideoModes` shall return a single-element list containing `default`
  when `ISurfaceWindow.State` is not `WindowState.ExclusiveFullscreen` and not `WindowState.WindowedFullscreen`.
- If the Window component is supported, `AvailableVideoModes` shall either return a single-element list containing
  `default` or return a list containing the `default` video mode along with all exclusive video modes when
  `ISurfaceWindow.State` is `WindowState.WindowedFullscreen`.
- If the Window component is supported, `AvailableVideoModes` shall return a list of exclusive video modes when
  `ISurfaceWindow.State` is `WindowState.ExclusiveFullscreen`, except where the `AvailableVideoModes` implementation
  includes exclusive video modes when `ISurfaceWindow.State` is `WindowState.WindowedFullscreen`, in which case
  `AvailableVideoModes` shall return the same list for both `WindowState.WindowedFullscreen` and
  `WindowState.ExclusiveFullscreen`.
- If the Window component is supported and `ISurfaceWindow.State` is currently `WindowState.ExclusiveFullscreen`,
  `ISurfaceWindow.State` shall be changed to `WindowState.WindowedFullscreen` (raising the appropriate events as
  necessary) when `ISurfaceDisplay.VideoMode` is set to the `default` video mode.
- If the Window component is supported and `ISurfaceWindow.State` is currently `WindowState.WindowedFullscreen`,
  `ISurfaceWindow.State` shall be changed to `WindowState.ExclusiveFullscreen` (raising the appropriate events as
  necessary) when `ISurfaceDisplay.VideoMode` is set to a non-`default` video mode. 
- If the Window component is not supported, `AvailableVideoModes` shall return a list of video modes supported in
  exclusive fullscreen mode and may also include the `default` video mode for non-exclusive control of the underlying
  window manager. What this means is open to the backend's interpretation, as in lieu of the Window component this could
  simply mean windowed fullscreen, bordered windowed, or basically anything that isn't exclusive fullscreen. 
- `IDisplay.KnownVideoModes`, if the implementation returns a non-`null` value for this property, shall contain all
  video modes that may be included in `AvailableVideoModes` regardless of the `State` property i.e. it includes the
  `default` video mode for non-exclusive and all exclusive fullscreen video modes. This is valid as per the
  `KnownVideoModes` documentation.  

# The Vulkan Component

```cs
namespace Silk.NET.Windowing;

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

public abstract partial class Surface
{
    /// <summary>
    /// Gets the Vulkan component of this surface.
    /// </summary>
    public virtual ISurfaceVulkan? Vulkan { get; }
}
```

# The Scale Component

This component provides the user the ability to account for high pixels-per-inch (PPI, also known as DPI) displays in
their rendering code. It provides no configuration but provides extra information to the user if supported.

```cs
namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a change in a surface's scale.
/// </summary>
/// <param name="Surface">The surface to which the change in scale occurred.</param>
/// <param name="OldContent">The previous value for <see cref="ISurfaceScale.Content"/>.</param>
/// <param name="NewContent">The new value for <see cref="ISurfaceScale.Content"/>.</param>
/// <param name="OldDraw">The previous value for <see cref="ISurfaceScale.Draw"/>.</param>
/// <param name="NewDraw">The new value for <see cref="ISurfaceScale.Draw"/>.</param>
/// <param name="OldPixelDensity">The previous value for <see cref="ISurfaceScale.PixelDensity"/>.</param>
/// <param name="NewPixelDensity">The new value for <see cref="ISurfaceScale.PixelDensity"/>.</param>
public readonly record struct ScaleChangedEvent(
    Surface Surface,
    float OldContent,
    float NewContent,
    float OldDraw,
    float NewDraw,
    float OldPixelDensity,
    float NewPixelDensity
);

/// <summary>
/// Provides information pertaining to the surface's graphical scaling.
/// </summary>
/// <remarks>
/// <see cref="Content" /> is typically used to scale UI elements to the correct size for the end user.
/// <see cref="PixelDensity" /> on the other hand is used to scale the entire application to cover the entire client
/// area in cases where the window client size is smaller than the actual drawable size (i.e. it is high density).
/// If scaling content for legibility and scaling the application's rendering as a whole are not needed to be separated,
/// it is recommended to use <see cref="Draw" />. Implementations shall always request a high density surface if
/// given the choice, to account for the platforms where applications may not be able to opt-out of high density.
/// </remarks> 
public interface ISurfaceScale
{
    /// <summary>
    /// Gets the factor with which the application should scale its content to make the content more legible for the
    /// user. This has no influence on <see cref="Surface.DrawableSize" />.
    /// </summary>
    /// <seealso cref="Draw" />
    float Content { get; }

    /// <summary>
    /// Gets the suggested amplification factor when drawing in terms of <see cref="Surface.DrawableSize" />. This
    /// represents the scale from the pixel resolution to the desired content size, and is typically the multiplication
    /// of <see cref="PixelDensity" /> and <see cref="Content" />.
    /// </summary>
    /// <remarks>
    /// For example, if <see cref="PixelDensity" /> is <c>2.0</c> (i.e. there are 2 pixels per screen coordinate)
    /// <i>and</i> the window manager requests that applications scale their content up by <c>2.0</c> to meet the user's
    /// settings as per <see cref="Content" />, this would be <c>4.0</c>. This is because we're scaling once to
    /// account for the fact that the application has twice the amount of pixels available to it for the given window
    /// size, and then scaling again so that what we are drawing appears zoomed in as per the user's request. Note that
    /// it is rarely the case that an operating system employs both dense pixels <i>and</i> content scale. macOS for
    /// instance, instead of setting <see cref="Content" />, opts to scale the resolution in the cases where the
    /// user wants magnified visuals instead of having the applications scale their content; whereas Windows sets
    /// <see cref="Content" /> and instead always keeps <see cref="PixelDensity" /> as <c>1.0</c>. This is down
    /// to philosophical differences between the window coordinate systems on platforms as to whether they prefer to
    /// deal in physical device pixels or physical content sizes.
    /// </remarks>
    float Draw { get; }

    /// <summary>
    /// Gets the ratio of pixels rendered to window size. This shall be equivalent to
    /// <see cref="Surface.DrawableSize" /> divided by <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    /// <seealso cref="Draw" />
    float PixelDensity { get; }

    /// <summary>
    /// An event raised when any scale factor changes.
    /// </summary>
    event Action<ScaleChangedEvent> Changed { add; remove; }
}

public abstract partial class Surface
{
    /// <summary>
    /// Gets the content scale configuration within the surface.
    /// </summary> 
    public virtual ISurfaceScale? Scale { get; }
}
```

# The Children Component

Some platforms allow surfaces to have children. If this is the case, the children component shall expose a mechanism to
spawn a new `ISurfaceApplication` and associated surface as a child of the currently running one.

```cs
namespace Silk.NET.Windowing;

/// <summary>
/// Provides the ability to spawn children surfaces.
/// </summary>
public interface ISurfaceChildren
{
    /// <summary>
    /// Spawns an application to run within a new child surface. This call shall not block.
    /// </summary> 
    /// <typeparam name="T">The application to run within the child surface.</typeparam>
    void Spawn<T>() where T : ISurfaceApplication;
}

public abstract partial class Surface
{
    /// <summary>
    /// Gets the "child surface" functionality if available.
    /// </summary> 
    public virtual ISurfaceChildren? Children { get; }
}
```

Implementations are expected to be aware of the resource sharing/validity requirements set forth at numerous points
throughout this document - search for occurrences of ISurfaceChildren.

# Detached Surfaces

When reviewing this proposal, we noticed that we hadn't accounted for the use case wherein users may want to take
advantage of desktop features (e.g. the ability to run one's own timing/game loop logic) if they are available. Up until
now, `ISurfaceApplication.Run` (or an alternative implementation's equivalent) is the only way to obtain a `Surface`
which involves taking control of the entire application and only giving the user control through the exposed callbacks.
For most use cases, this is fine as we've exposed fundamentals like calling into user code as fast as possible (`Tick`)
or on regular intervals (`Render`/`Update`). However, there will be some power users that will want to retain the
ability to control their own timing if possible, for which we propose the concept of "detached surfaces".

"Detached surfaces" have a lifetime that is detached from that of the `ISurfaceApplication` they're associated with.
That is, the implementation's usual handling of an `ISurfaceApplication` and its lifecycle is instead user controlled.
This is notable as creation and destruction of a `Surface` is usually controlled by the implementation, whereas with
this API the destruction shall be delegated to the user. This is exposed as follows:

```cs
namespace Silk.NET.Windowing;

/// <summary>
/// Represents a surface with a user-controlled lifecycle.
/// </summary>
/// <remarks>
/// This API is <b>not guaranteed to be supported</b> on all platforms and you should only use it if you know what
/// you're doing and know you need the granular control this API provides! Please use
/// <see cref="ISurfaceApplication.Run{T}" /> instead where possible. If you insist on using this API, please fall back
/// to <see cref="ISurfaceApplication.Run{T}" /> if <see cref="TryCreate{T}" /> returns <c>false</c> indicating a lack
/// of support.
/// </remarks>
public interface IDetachedSurfaceLifecycle : IDisposable
{
    /// <summary>
    /// Gets the surface with which this lifecycle is associated. The destruction of this surface is handled by
    /// the <see cref="IDisposable.Dispose" /> method of this <see cref="IDetachedSurfaceLifecycle" /> implementation.
    /// </summary>
    Surface Surface { get; }

    /// <summary>
    /// Gets a value indicating whether the surface is indicating that its lifecycle should conclude as a result of
    /// its current configuration e.g. an entire tick passing with <see cref="ISurfaceWindow.IsCloseRequested" /> being
    /// <c>true</c>.
    /// </summary>
    /// <remarks>
    /// It is expected that <see cref="Tick" /> shall not be called if this property is <c>true</c>.
    /// </remarks>
    bool ShouldTerminate { get; }

    /// <summary>
    /// Steps the underlying implementation's surface lifecycle (i.e. event loop), running a single tick on the
    /// <see cref="Surface" />.
    /// </summary>
    /// <remarks>
    /// It is expected that implementations shall return after doing as little work as possible. For instance, if the
    /// underlying implementation exposes one-by-one event retrieval or otherwise allows customisation of the extent to
    /// which the event pump is run, it is expected that a single event shall be pumped in this case. Note that this is
    /// just an example and the exact details of this is implementation-defined.
    /// </remarks> 
    void Tick();

    /// <summary>
    /// Attempts to create a <see cref="IDetachedSurfaceLifecycle" /> using the reference implementation.
    /// </summary>
    /// <param name="lifecycle">The created surface lifecycle on success, <c>null</c> otherwise.</param>
    /// <typeparam name="T">
    /// The application that shall be associated with the surface. Note that even with this API,
    /// <see cref="ISurfaceApplication.Initialize{T}" /> shall still be called for consistency and portability. However,
    /// unlike <see cref="ISurfaceApplication.Run{T}" />, this method shall not block and will instead return an
    /// <see cref="IDetachedSurfaceLifecycle" /> on which <see cref="Tick" /> is expected to be continuously called to
    /// enact the same behaviour on the surface. The associated application is also used for any additional global
    /// configuration, such as <see cref="ISurfaceApplication.WindowClass" />.
    /// </typeparam>
    /// <returns>
    /// <c>true</c> if <paramref name="lifecycle" /> has been populated with an <see cref="IDetachedSurfaceLifecycle" />
    /// object containing a valid <see cref="Surface" />, <c>false</c> otherwise.
    /// </returns>
    /// <remarks>
    /// This is the same reference implementation that <see cref="ISurfaceApplication.Run{T}" /> would otherwise use.
    /// </remarks>
    sealed static bool TryCreate<T>([NotNullWhen(true)] out IDetachedSurfaceLifecycle? lifecycle) where T : ISurfaceApplication;
}
```

# Meeting Notes

## 26/01/2025

[Video](https://www.youtube.com/live/jNIAH2raTMY?feature=shared&t=2334)

- Approved, with changes...
- `Name` for colloquial names should be `Description` to clarify it's a non-programmatic user-facing description

## 25/02/2022

[Video](https://youtu.be/dac3t0oh3VU?t=1984)

- Approved.
- Questions around windows handles
    - What Win32 handles should be available?
        - Mostly what we have for 2.X today, but as a struct
    - StructLayout = Auto for WindowHandles so that people can't depend on the memory layout (so we can add more handles!)
- Is glue mandatory?
    - Nope, you can use GetOrCreate but SilkEntryPoint will be recommended.
