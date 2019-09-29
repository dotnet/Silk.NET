# Summary
Currently, there's a major flaw in the windowing API in that the user doesn't have much control over the game loop. This leads to problems on platforms such as MacOS where threading issues are more significant. This revision aims to circumvent that.

# Contributors
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- After encountering some fustrating threading issues on macOS, I've decided to split off all the main portions of the game loop to give the user more control.
- After the split, the implementation of the Run method should be as simple as this:
```cs
public void Run()
{
    Create();
    while (!IsClosing)
    {
        DoEvents();
        DoUpdate();
        DoRender();
    }
}
```

# Proposed API

## IWindowFunctions additions
```cs
public interface IWindowFunctions
{
     /// <summary>
     /// Polls the underlying backend for window events, and executes them. This does not include Render or Update.
     /// </summary>
     void DoEvents();

     /// <summary>
     /// Calls the Render event. If a multi-threaded window is used, the Render event will run on the
     /// render thread managed by the implementation.
     /// </summary>
     void DoRender();
     // IMPLEMENTATION DETAIL: Delta-time should be managed by the implementation
     // IMPLEMENTATION DETAIL: Invoke calls should be handled in this call.
     // IMPLEMENTATION DETAIL: SwapBuffers should be called here if ShouldSwapAutomatically is true.

     /// <summary>
     /// Calls the Update event. If a multi-threaded window is used, the Update event could run on any thread.
     /// </summary>
     void DoUpdate();
     // IMPLEMENTATION DETAIL: Delta-time should be managed by the implementation

     /// <summary>
     /// Makes the OpenGL context current on a given thread.
     /// </summary>
     void MakeCurrent();
     // IMPLEMENTATION DETAIL: The window must automatically ensure that the context is current
     // on the render thread if multi-threaded windows are used, so that the user doesn't have
     // to worry about setting the context current within the Render event.

     /// <summary>
     /// Calls the Update event. If a multi-threaded window is used, the Update event could run on any thread.
     /// </summary>
     void SwapBuffers();

     /// <summary>
     /// Runs the default game loop. Must be called by the program entry thread.
     /// </summary>
     void Run();

     /// <summary>
     /// Creates the window on the underlying platform.
     /// </summary>
     void Create();
}
```

## IWindowProperties additions
```cs
public interface IWindowProperties
{
    /// <summary>
    /// Whether this window has been requested to close by the underlying platform.
    /// </summary>
    bool IsClosing { get; } // GLFW: maps to glfwShouldWindowClose

    /// <summary>
    /// Whether SwapBuffers should automatically be called in the DoRender call.
    /// </summary>
    bool ShouldSwapAutomatically { get; } // Default: true
}
```
