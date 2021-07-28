# Summary
Proposal API for backend-agnostic, refactored Input via keyboards, mice, and controllers.

# Contributors
- Dylan Perks (@Perksey)

# Current Status
- [x] Proposed
- [ ] Discussed with Working Group
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal refactors the internals of the Input API to be less tied to a single backend, and instead allow multiple backends to be added and removed from an input context at will.
- This proposal aims to keep the look and feel of the Input APIs intended for general consumption similar to that of 2.0.
- This proposal assumes knowledge of the following proposals:
    - Windowing 3.0
    - Input
    - Enhanced Input Events
- This proposal also assumes knowledge of 2.0's Input APIs as it is only a refactor and not a complete redesign of the API as in other proposals. The most noticable differences between the design of Input 2.0 and Input 3.0 are:
    - Input no longer has a hard bond to Windowing. The integration will remain the same to the end user but will use Source Generators, more on that later. 
    - Input contexts are no longer interfaces, they are instead classes which contain input backends.

## Reference Implementation

Similar to Windowing 3.0, a reference implementation will be included in the main `Silk.NET.Input` package which uses the same API or family of APIs as Windowing. This will be exposed via the `InputBackend` class. The `InputBackend` class contains a static `Create` method which accepts the native handle for the input context on the particular underlying API i.e. on GLFW this handle represents a `GLFWwindow*`. This may be subject to change.

## Source Generator

Alongside the input package there will be a source generator (shipped in a `Silk.NET.Input.Roslyn` NuGet package, which is referenced by the main input package). This source generator will be very small, but it allows us to create a link between windowing and input at compile time without a hard reference.

If the source generator detects that both `Silk.NET.Input` and `Silk.NET.Windowing` are referenced, code with the following API surface will be injected into the assembly:
```cs
namespace Silk.NET.Input
{
    internal static class InputSurfaceExtensions // internal to avoid conflicts with other assemblies
    {
         public static InputContext CreateInput(this ISurface surface);
    }
}
```

The `CreateInput` method will use the surface, obtain its platform data (i.e. by using something like `IGlfwPlatformData`), and then feed that into `InputBackend.Create`. The returned `InputContext` will be configured to have the returned `IInputBackend` as a backend. This method will also appropriately bind the `ISurface.Update` callback:
- The delegate passed in the `onActivated` parameter of `InputBackend.Create` will bind the `IInputBackend.Update` method to run in the `ISurface.Update` callback.
- The delegate passed in the `onDeactivated` parameter of `InputBackend.Create` will unbind the `ISurface.Update` callback.
- These delegates must be called by the reference implementation in its `IInputBackend.Activate` and `IInputBackend.Deactivate` methods (respectively)
- The `IInputBackend.Activate` and `IInputBackend.Deactivate` methods must be called by the `InputContext.Add` and `InputContext.Remove` methods (respectively)

**KEY POINT FOR WORKING GROUP**: The Windowing-Input integration mandates the use of source generators. Is this ok?

# Proposed API

```diff
namespace Silk.NET.Input
{
-   public interface IInputPlatform
-   {
-       bool IsApplicable(IView view);
-       IInputContext CreateInput(IView view);
-   }
}
```

```diff
namespace Silk.NET.Input
{
+   /// <summary>
+   /// Encapsulates input devices sourced from input backends.
+   /// </summary>
-   public interface IInputContext : IDisposable
+   public sealed class InputContext : IDisposable
    {
-       nint Handle { get; }
        IReadOnlyList<IGamepad> Gamepads { get; }
        IReadOnlyList<IJoystick> Joysticks { get; }
        IReadOnlyList<IKeyboard> Keyboards { get; }
        IReadOnlyList<IMouse> Mice { get; }
        IReadOnlyList<IInputDevice> OtherDevices { get; }
+
+       /// <summary>
+       /// Gets a list of backends from which all input devices on this input context are sourced.
+       /// </summary>
+       IReadOnlyList<IInputBackend> Backends { get; }
        event Action<IInputDevice, bool>? ConnectionChanged;
+
+       /// <summary>
+       /// Adds the given backend to the list of <see cref="Backends" />.
+       /// </summary>
+       void Add(IInputBackend backend);
+
+       /// <summary>
+       /// Removes the given backend from the list of <see cref="Backends" />.
+       /// </summary>
+       void Remove(IInputBackend backend);
+
+       /// <summary>
+       /// Updates all input data on all backends.
+       /// </summary>
+       void Update();
    }
}
```

```diff
namespace Silk.NET.Input
{
+   /// <summary>
+   /// Represents an input backend from which input devices can be retrieved.
+   /// </summary>
+   public interface IInputBackend
+   {
+       /// <summary>
+       /// Gets all connected devices recognised by this backend.
+       /// </summary>
+       IReadOnlyList<IInputDevice> ConnectedDevices { get; }
+
+       /// <summary>
+       /// Raised when an input device is connected or disconnected.
+       /// </summary>
+       event Action<IInputDevice, bool>? ConnectionChanged;
+
+       /// <summary>
+       /// Updates this backend's input data.
+       /// </summary>
+       /// <remarks>
+       /// Input events and changes are permitted to occur outside of this method.
+       /// </remarks>
+       void Update();
+
+       /// <summary>
+       /// Activates this input backend and runs any necessary prerequisites.
+       /// </summary>
+       /// <remarks>
+       /// Called by <see cref="InputContext.Add" />
+       /// </remarks>
+       void Activate();
+
+       /// <summary>
+       /// Deactivates this input backend and tears down any resources created.
+       /// </summary>
+       /// <remarks>
+       /// Called by <see cref="InputContext.Remove" />
+       /// </remarks>
+       void Deactivate();
+   }
}
```

```diff
namespace Silk.NET.Input
{
-   public static class InputWindowExtensions
-   {
-       // ...
-   }
}
```

```diff
namespace Silk.NET.Input
{
+   /// <summary>
+   /// Represents the out-of-the-box input backend, which uses a native API to retrieve input backends using a native handle.
+   /// </summary>
+   /// <remarks>
+   /// On desktop, this uses GLFW.
+   /// </remarks>
+   public static class InputBackend
+   {
+       /// <summary>
+       /// Creates an instance of the out-of-the-box input backend, which uses a native API to retrieve input backends using
+       /// the given native handle, optionally calling the given delegates when the input backend is activated and deactivated.
+       /// </summary>
+       /// <param name="handle">The native handle created/sourced from the underlying native API used by this input backend.</param>
+       /// <param name="onActivate">A delegate to be called when the context is activated. May be null.</param>
+       /// <param name="onDeactivate">A delegate to be called when the context is deactivated. May be null.</param>
+       /// <remarks>
+       /// This method is implicitly called by the Windowing-Input integration. <br />
+       /// On desktop, this uses GLFW.
+       /// </remarks>
+       public static unsafe IInputBackend Create(void* handle, Action? onActivate = null, Action? onDeactivate = null);
+   }
}
```
