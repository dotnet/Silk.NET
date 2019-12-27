# Summary
A proposal for the division of core windowing APIs into a new, stripped-down interface for mobile windowing platforms.

# Contributors
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- An Explanation of any notable design decisions you went with (i.e. why you designed the API like this)
This section is optional

# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.
## IViewEvents
```cs
internal interface IViewEvents
{
        /// <summary>
        /// Raised when the view is resized.
        /// </summary>
        event Action<Size> Resize;

        /// <summary>
        /// Raised when the view is about to close.
        /// </summary>
        event Action Closing;

        /// <summary>
        /// Raised when the view's state is changed.
        /// </summary>
        event Action<WindowState> StateChanged;

        /// <summary>
        /// Raised when the view focus changes.
        /// </summary>
        event Action<bool> FocusChanged;

        /// <summary>
        /// Raised when the view first begins to run.
        /// </summary>
        event Action Load;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event Action<double> Update;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event Action<double> Render;
}
```

## IWindowEvents
```diff
-    interface IWindowEvents
+    interface IWindowEvents : IViewEvents
```

## IViewFunctions
```diff
-    interface IWindowFunctions
+    interface IViewFunctions
```

## IViewProperties
```cs
    interface IViewProperties
    {
        /// <summary>
        /// If true, both updates and rendering will happen on the same thread. If false, both updating and rendering
        /// will be run on their own threads.
        /// </summary>
        bool UseSingleThreadedWindow { get; }

        /// <summary>
        /// If true, SwapBuffers will be called automatically at the end of each Render event.
        /// </summary>
        bool ShouldSwapAutomatically { get; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Size Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// The graphics API to use, and associated configurations.
        /// </summary>
        GraphicsAPI API { get; }

        /// <summary>
        /// The window state.
        /// </summary>
        WindowState WindowState { get; }

        /// <summary>
        /// The VSync mode.
        /// </summary>
        VSyncMode VSync { get; set; }
        
        /// <summary>
        /// The number of frames the window needs to be running slowly for before <see cref="IWindow.IsRunningSlowly"/>
        /// is set to true.
        /// </summary>
        int RunningSlowTolerance { get; set; }
    }
```

## IWindowProperties
```diff
-    interface IWindowProperties
+    interface IWindowProperties : IViewProperties
```

## IWindowPlatform
```diff
+    IView GetView(ViewOptions opts);
```

## Window
```diff
+    public static IView GetView(ViewOptions opts);
```

## ViewOptions
```cs
public struct ViewOptions : IViewProperties
{
    // etc
}
```

## InputWindowExtensions
```diff
-    public static IInputContext CreateInput(this IWindow window);
+    public static IInputContext CreateInput(this IView view);
```
