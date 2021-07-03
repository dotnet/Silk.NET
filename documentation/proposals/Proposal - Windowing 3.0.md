# Summary
- Summary of the thing you want this API to achieve
    
Example: Proposal API for Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks (@Perksey)
- Kai Jellinghaus (@HurricanKai)

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal builds on the foundations laid out by Silk.NET's move to source generators in 2.0, and the introduction of the SilkTouch source generator as a result of this.
- This proposal assumes no knowledge of any previous iterations of Silk.NET Windowing.
- This is a complete rethink of Silk.NET Windowing built from the ground up to account for our goal of "write once run everywhere" for .NET 6 and Silk.NET 3.0.
- In this proposal, there are three parties:
   - **User**: the person using the Silk.NET Windowing library and by extension a platform implementation.
   - **Platform Implementor**: the party providing an implementation of the Silk.NET Windowing abstractions (abstractions such as the "Surface" as defined later in this proposal). This implementation will be referred to herein as the **Platform Implementation** (or the **Platform** for short)
   - **Library Implementor**: the party providing the plubming around the surface abstraction (such as the platform selection mechanisms and accompanying source generators). This will be referred to herein as the **Library Implementation** (or the **Library** for short)


# Platforms

There will be a number of "reference" implementations for the APIs laid out in this proposal. These are:
- For `net6.0` and `net6.0-windows`: GLFW.
- For `net6.0-ios`, `net6.0-tvos` and `net6.0-maccatalyst`: UIKit. (NB: The latter two will be a target for Silk.NET 3.X) 
- For `net6.0-macos`: AppKit (NB: This will be a target for Silk.NET 3.X, it is recommended developers targeting macOS use the regular `net6.0` TFM)
- For `net6.0-android`: EGL and ANativeWindow.
- For `net6.0-tizen`: TZSH. (NB: This will be a target for Silk.NET 3.X)

The decision has been made to drop SDL due to complications and the fact that all non-desktop targets are distinctly unique in their own right. We believe that in creating platform-specific code for each of these will result in significantly more robust support for each of these platforms. 

**OPEN QUESTION:** Should we drop our SDL bindings too?

All of the above is informative text, however, and no reference implementations are required or guaranteed to use these APIs under-the-hood.

Unlike previous iterations, one reference implementation **MUST** be bundled with the main Silk.NET.Windowing assembly. Given that we can easily use platform-specific TFMs there's no reason to keep the fragmentation of different implentations across different assemblies.

# Surface

In this proposal, a plane upon which graphics can be rendered on is represented by an `ISurface`. `ISurface` defines a minimal subset of basic APIs which **MUST** all be present on an **Platform Implementation**. The idea is `ISurface` just provides the bare necessities for rendering a game or application without knowing too much about the form factor, better encouraging cross-platform/"write once run everywhere" code. Bare necessities such as:
- words
- more words
- even more words
- The quick brown fox jumps over the lazy dog.
- Fill this with words after the API is nailed out.

`ISurface` **Platform Implementations** **SHOULD** also implement any extension interfaces that it can support for a given platform. Through these extension interfaces, if user code needs to access APIs which are more specific to certain form factors or platforms, they should use casts to get a more specific surface.

# Global Platform Selection Mechanism

The static `Surface` class is the non-contextual way for getting access to a `ISurface` object you can use for your game or application. This is not a requirement, as there will be of course other ways to retrieve a surface in the case of integrations into UI frameworks, but a **Platform** **MAY** implement `ISurfaceBackend` if the surface(s) it creates aren't bound to any other particular construct (i.e. it's using an operating system's window management APIs to create brand new windows, and doesn't require a window or whatever else to already exist). This will allow it to be used by the global selection mechanism.

If it does implement `ISurfaceBackend`:
- words
- more words
- even more words
- The quick brown fox jumps over the lazy dog.
- Fill this with words after the API is nailed out.

For the reader's benefit, this `Surface` class isn't really intended for general consumption though it must be public for those applications don't fit into the model defined below, which should be preferred:

# Windowing Entry Points

Even with the platform selection mechanism, there is a lot of plumbing required to get to the stage of acquiring a surface on the various platforms. In Silk.NET 3.0, the **Library** **MAY** decide to expose a Roslyn source generator (the "**Gluer**" as used herein) to assist with this. If it doesn't, this section and its requirements can be discarded.

The **Gluer** **MUST** be distributed in package/namespace `Silk.NET.Windowing.Roslyn`.

The Gluer operates on **User** methods that:
- **MUST** be static
- **MUST** return `void`
- **MUST** have a single parameter of type `ISurface` or a type that inherits from `ISurface`. If the latter, the Glue **MUST** assert that the `ISurface` created is assignable to the parameter type or throw an exception if this is not the case. This allows applications to use `IDesktopSurface` only if that's their jam.
- **MUST** have the attribute `SilkEntryPoint`

The idea is the Gluer will generate `Main` methods on .NET, `Activity`s on .NET for Android, etc... The **Gluer**, if generating **MUST** generate the necessary APIs to ensure that the method in question is called on application start-up (the "Glue"). If any of the above User requirements aren't met, the **Gluer** **MUST NOT** generate Glue. If a method is found with the `SilkEntryPoint` attribute but fails to meet one of the other requirements, the **Gluer** **MUST** generate a compiler error; otherwise it **MUST NOT** impact the compilation whatsoever.

If multiple methods are found with `SilkEntryPoint`, the **Gluer** **MUST** generate a compiler error. All attributes **MUST** only be name matched by the **Gluer**.

The Gluer **MUST NOT** modify the original type (i.e. all Glue must be defined in its own self-contained type)

The **User** **MUST NOT** define their own application entry point (such as a static `Main` method in the case of regular .NET) if they are using the Gluer, though the Gluer does not have to enforce this.

The method **MAY** be called multiple times throughout the lifetime of an application. This is because of operating system restrictions - the only way to definitively know whether this method is being called for the last time is the `IsTerminating` property or `Terminating` event on `ISurface`.

The Glue is purposely left undefined as this is operating system &amp; platform specific, and would not reflect any future platforms we decide to add.

A model example of what this looks like:
```cs
public class MyGame
{
    [SilkEntryPoint]
    public static void RunGame(ISurface surface)
    {
        // do things with your surface
        surface.Run();
    }
}
```

# Defined Extensions
## `IDesktopSurface`
## `IGLSurface`
## `IGlesSurface`
## `IVkSurface`
## `IGLTransparentFramebufferSurface`

NB: We've been discussing `IWebGLSurface` a lot recently, but this is left out of this proposal as this is a target for Silk.NET 3.X.

# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.

## `ISurface`
```cs
namespace Silk.NET.Windowing
{
    public interface ISurface : IGameLoopRunnable
    {
        /// <summary>
        /// Determines whether the surface is being destroyed by the platform.
        /// </summary>
        bool IsTerminating { get; }
        
        /// <summary>
        /// Determines whether the surface is being paused by the platform.
        /// </summary>
        bool IsPausing { get; }

        /// <summary>
        /// Elapsed time in seconds since the Run method last started.
        /// </summary>
        double Time { get; }

        /// <summary>
        /// The size of the surface's inner framebuffer. May differ from the surface size.
        /// </summary>
        // NB: This is not OpenGL specific and is valid in any case where there's a high DPI monitor.
        Vector2D<int> FramebufferSize { get; }

        /// <summary>
        /// The size of the surface.
        /// </summary>
        Vector2D<int> Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// Raised when the surface is resized.
        /// </summary>
        event Action<Vector2D<int>>? Resize;

        /// <summary>
        /// Raised when the surface's framebuffer is resized.
        /// </summary>
        event Action<Vector2D<int>>? FramebufferResize;

        /// <summary>
        /// Raised when the surface is being terminated.
        /// </summary>
        event Action? Terminating;

        /// <summary>
        /// Raised when the surface is running low on memory.
        /// </summary>
        event Action? LowMemory;

        /// <summary>
        /// Raised when the surface is about to pause. This is a good indicator that the Run method is about to exit, though this may not necessarily be the case, but the surface isn't terminating yet.
        /// </summary>
        event Action? Pausing;

        /// <summary>
        /// Raised when the surface is about to resume. This is a good indicator to expect the entry point to be called again, though this may not necessarily be the case. 
        /// </summary>
        event Action? Resuming;

        /// <summary>
        /// Raised when the surface is initialized for the first time.
        /// </summary>
        event Action? Created;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event Action<double>? Update;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event Action<double>? Render;

        /// <summary>
        /// Creates the surface on the underlying platform.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Calls the Render event.
        /// </summary>
        void DoRender();

        /// <summary>
        /// Calls the Update event.
        /// </summary>
        void DoUpdate();

        /// <summary>
        /// Polls the underlying platform for events.
        /// </summary>
        void DoEvents();

        /// <summary>
        /// Unloads the surface on the underlying platform.
        /// </summary>
        void Reset();

        /// <summary>
        /// Terminates this surface.
        /// </summary>
        void Terminate();

        /// <summary>
        /// Converts this point to framebuffer coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToFramebuffer(Vector2D<int> point);

        /// <summary>
        /// Initiates a render loop in which the given callback is called as fast as the underlying platform can manage.
        /// </summary>
        /// <param name="onFrame">The callback to run each frame.</param>
        void Run(Action onFrame);
    }
}
```

## CLEAN THE BELOW UP, SORT IT OUT!


        /// <summary>
        /// Converts this point to client coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects screen coordinates as input.</remarks>
        Vector2D<int> PointToClient(Vector2D<int> point);

        /// <summary>
        /// Converts this point to screen coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToScreen(Vector2D<int> point);
