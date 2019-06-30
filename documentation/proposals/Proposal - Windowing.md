# Summary
- API proposal for Silk.NET.Windowing.

# Contributors
* Aaron P, Ultz
* Dylan P, Ultz
* Jarl G, Firwood Software
* Void, Silk.NET Codeowners

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

# Design Decisions
- I was dissatisfied with the windowing system I worked on, primarily because I felt it was too large and bloated. It suffered from attempting to recreate an older API, instead of being a true new beginning. With this proposal, I hope to create a new API that feels familiar, but is much cleaner and easier to work with.

- Our current mathematics library, `System.Numerics`, does not provide support for a few important types, most notably integer vectors. For now, Points and Sizes are used instead.

# Proposed API

## Interfaces

- The main interface is `IWindow`, an interface representing a window. It contains very little of its own, and mostly serves to implement the other `IWindow*` interfaces for the sake of convenience.

- Certain backends (such as GLFW) have limits as to what functions can be called on threads that the windowing system wasn't initialized. In these cases, [Ultz.Dispatcher](https://github.com/Ultz/Dispatcher) should be used as a workaround for multithreading. The `Invoke` methods provide user-access to the main UI thread.

```cs
/// <summary>
/// Base interface for a window.
/// </summary>
public interface IWindow : IWindowProperties, IWindowFunctions, IWindowEvents
{
	/// <summary>
	/// A handle to the underlying window.
	/// </summary>
	IntPtr Handle { get; }
	
	/// <summary>
        /// Invokes this delegate on the window's main thread.
        /// </summary>
        object Invoke(Delegate d);

        /// <summary>
        /// Invokes this delegate on the window's main thread, with the provided arguments.
        /// </summary>
        object Invoke(Delegate d, params object[] args);
}
```

- The first interface is `IWindowProperties`.

```cs
/// <summary>
/// Contains all window properties.
/// </summary>
public interface IWindowProperties
{
	/// <summary>
	/// If true, both updates and rendering will happen on the same thread. If false, both updating and rendering will be run on their own threads. Default is true.
	/// </summary>
	bool UseSingleThreadedWindow { get; }

	/// <summary>
	/// The position of the window. Integer vector. If set to -1, use the backend default. Default is -1 for both components.
	/// </summary>
	Point Position { get; set; }

	/// <summary>
	/// The size of the window. Integer vector. Default is 1280 x 720.
	/// </summary>
	Size Size { get; set; }

	/// <summary>
	/// The number of rendering operations to run per second. If 0, the framerate will be uncapped. Default is 0.
	/// </summary>
	double FramesPerSecond { get; }

	/// <summary>
	/// The number of update operations to run per second. If 0, the update rate will be uncapped. Default is 0.
	/// </summary>
	double UpdatesPerSecond { get; }

	/// <summary>
	/// The graphics API to use, and associated configurations. Default is OpenGL 3.3 forward-compatable core profile.
	/// </summary>
	GraphicsAPI API { get; }

	/// <summary>
	/// The title of the window. Default is "Silk.NET Window".
	/// </summary>
	string Title { get; set; }

	/// <summary>
	/// The state of the window. Default is Normal.
	/// </summary>
	WindowState WindowState { get; set; }

	/// <summary>
	/// The type of border the window has. Default is Resizable.
	/// </summary>
	WindowBorder WindowBorder { get; set; }

	/// <summary>
	/// The vertical synchronization mode to use. Default is On.
	/// </summary>
	VSyncMode VSync { get; set; }
}
```

- Next is IWindowFunctions. This is very standard for windows, since most functionality will be provided by users via callbacks.

```cs
/// <summary>
/// Contains all windowing functions.
/// </summary>
public interface IWindowFunctions
{
	/// <summary>
	/// Closes this window.
	/// </summary>
	void Close();

	/// <summary>
	/// Processes pending window events.
	/// </summary>
	void ProcessEvents();

	/// <summary>
	/// Makes the GraphicsContext current on the calling thread.
	/// </summary>
	void MakeCurrent();

	/// <summary>
	/// Transforms the specified point from screen to client coordinates.
	/// </summary>
	/// <param name="point">
	/// A <see cref="Vector2" /> to transform.
	/// </param>
	/// <returns>
	/// The point transformed to client coordinates.
	/// </returns>
	Point PointToClient(Point point);

	/// <summary>
	/// Transforms the specified point from client to screen coordinates.
	/// </summary>
	/// <param name="point">
	/// The <see cref="Vector2" /> to transform.
	/// </param>
	/// <returns>
	/// The point transformed to screen coordinates.
	/// </returns>
	Point PointToScreen(Point point);
}
```

- Next is `IWindowEvents`. Several events GLFW provides have been omitted. Everything related to input has been removed, as it would be redundant to have both input-handling here and in Silk.NET.Input. In addition, certain events (such as WindowBorderChanged) have been omitted, as those variables will only ever be updated when the user updates them manually.

```cs
/// <summary>
/// Contains all window virtual functions.
/// </summary>
public interface IWindowEvents
{
    /// <summary>
    /// Raised when the window is moved.
    /// </summary>
    event Action<Point> OnMove;

    /// <summary>
    /// Raised when the window is resized.
    /// </summary>
    event Action<Size> OnResize;

    /// <summary>
    /// Raised when the window is about to close.
    /// </summary>
    event Action OnClosing;

    /// <summary>
    /// Raised when the window state is changed.
    /// </summary>
    event Action<WindowState> OnStateChanged;

    /// <summary>
    /// Raised when the window focus changes.
    /// </summary>
    event Action<bool> OnFocusChanged;

    /// <summary>
    /// Raised when the user drops files onto the window.
    /// </summary>
    event Action<string[]> OnFileDrop;

    /// <summary>
    /// Raised when the window first begins to run.
    /// </summary>
    event Action OnLoad;

    /// <summary>
    /// Raised when an update should be run.
    /// </summary>
    event Action<double> OnUpdate;

    /// <summary>
    /// Raised when a frame should be rendered.
    /// </summary>
    event Action<double> OnRender;
}
```

- The GLFW or Native platforms can't be referenced by the main windowing package. This means that we nede to work out our own cross-platform windowing management API. We have decided to use `ISilkPlatform`, static class `Silk` for platform registration via reflection, and static class `Window` for Window creation.

```cs
/// <summary>
/// An interface that provides windowing for its respective .NET platform.
/// </summary>
public interface ISilkPlatform
{
    /// <summary>
    /// Gets a value indicating whether this <see cref="ISilkPlatform"> should be used, based on the current runtime/environment.
    /// </summary>
    bool IsApplicable { get; }
    
    /// <summary>
    /// Creates a window with the given options.
    /// </summary>
    /// <param name="opts">The initial settings this window should open with.</param>
    /// <returns>An implementation of <see cref="IWindow"/></returns>
    IWindow GetWindow(WindowOptions opts);
}
```

## Classes

```cs
/// <summary>
/// Provides methods and properties for configuring Silk.NET's Windowing system. In most cases, the end user shouldn't use this class.
/// </summary>
public static Silk
{
    /// <summary>
    /// Gets or sets the current windowing platform used by Silk.NET.
    /// </summary>
    // Implementation Detail: the setter should throw an InvalidOperationException if the platform that the user is trying to set is not applicable.
    public static ISilkPlatform CurrentPlatform { get; set; }
    
    /// <summary>
    /// Searches for Silk.NET platforms in the current AppDomain via reflection, and picks the first applicable one.
    /// </summary>
    // Discussion Point: we could have an overload taking an AppDomain as a parameter, just in case someone has an exotic use case.
    public static void Init();
}
```

- We have our GlfwWindow class. For the purposes of compatability with other backends, there should be as few extra properties that aren't in IWindow as possible.

```cs
/// <summary>
/// A Slim.NET window using the GLFW backend
/// </summary>
public class GlfwWindow : IWindow
{
	/// <summary>
	/// Convinience wrapper around creating a new WindowOptions with the default struct.
	/// </summary>
	public GlfwWindow(WindowOptions options = WindowOptions.Default);
}
```

## Structs

- To avoid having an excessive number of constructors, and to allow for multiple defaults for multiple situations, we initialize objects Vulkan-style; we fill out a struct with all the properties, and pass that to the constructor.

```cs
/// <summary>
/// Contains all window properties, used for window creation.
/// </summary>
public struct WindowOptions : IWindowProperties
{
	// Contains everything from IWindowProperties, but with setters for all functions that don't have them.

	/// <summary>
	/// Creates a new WindowOptions struct, with sensible defaults.
	/// </summary>
	public WindowOptions(/*all properties from IWindowProperties*/);

	/// <summary>
	/// Convinience wrapper around creating a new WindowProperties with the default values.
	/// </summary>
	public static WindowOptions Default => new WindowOptions(/*sensible defaults*/);
}
```

- All variables related to the graphics API are contained in the GraphicsAPI struct:

```cs
/// <summary>
/// Represents a configuration for a graphics API.
/// </summary>
public struct GraphicsAPI
{
	/// <summary>
	/// The render API to use.
	/// </summary>
	public ContextAPI API { get; set; }

	/// <summary>
	/// The profile to use.
	/// </summary>
	public ContextProfile Profile { get; set; }

	/// <summary>
	/// Context creation flags.
	/// </summary>
	public ContextFlags Flags { get; set; }

	/// <summary>
	/// The version of the API to use.
	/// </summary>
	public APIVersion Version { get; set; }

	/// <summary>
	/// Creates a new GraphicsAPI struct. Defaults to OpenGL 3.3 core profile with forward compatability.
	/// </summary>
	public GraphicsAPI(api, profile, flags, version);
	
	/// <summary>
	/// The default graphics API. This is OpenGL 3.3 core profile, with forward compatability enabled.
	/// </summary>
	public static GraphicsAPI Default => new GraphicsAPI(ContextAPI.OpenGL, ContextProfile.Core, ContextFlags.ForwardCompatible, new APIVersion(3, 3));
}
```

- Since System.Version includes more integers than is necessary for our purposes, a new APIVersion struct was created instead:

```cs
/// <summary>
/// Represents the desired version of an API.
/// </summary>
public struct APIVersion
{
    /// <summary>
    /// The major version of the API.
    /// </summary>
    public int MajorVersion;

    /// <summary>
    /// The minor version of the API.
    /// </summary>
    public int MinorVersion;

    /// <summary>
    /// Creates a new APIVersion from two integers.
    /// </summary>
    public APIVersion(int majorVersion, int minorVersion);

    /// <summary>
    /// Creates a new APIVersion from a <see cref="System.Version"/>
    /// </summary>
    public APIVersion(Version version);
}
```

## Enums

```cs
/// <summary>
/// The vertical synchronization mode to use.
/// </summary>
public enum VSyncMode
{
    /// <summary>
    /// VSync is disabled.
    /// </summary>
    Off = 0,
        
    /// <summary>
    /// VSync is enabled.
    /// </summary>
    On,

    /// <summary>
    /// Use adaptive VSync. If the window has failed to reach the target framerate for five consecutive frames,
    /// VSync will be disabled. Otherwise, it will be enabled. If the framerate is uncapped, this is the same as <see cref="On"/>. 
    /// </summary>
    Adaptive,
}
```
