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
- Unlike 1.0 and 2.0, all device lists (including those on `InputContext`) will return both connected and disconnected devices when indexed or iterated.

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
- The `IInputBackend.Update` method is configured to run in the `ISurface.Update` callback.
- The `IInputBackend.Disposing` event will be bound such that the `IInputBackend.Update` method is unbound from `ISurface.Update` event callback.

The API surface for this is defined later in the Proposed API section.

One instance of an `IInputBackend` can only belong to one `InputContext` throughout the entirety of the `IInputBackend`'s lifetime. Once a `IInputBackend` is `Add`ed to an `InputContext`, the `InputContext` takes full ownership of the `IInputBackend` and, as a result, will `Dispose` the `IInputBackend` when it is `Remove`d or the context itself is `Dispose`d. If multiple `InputContext`s are in use, multiple `IInputBackend` instances must also be used. `IInputBackend` will throw an exception if its APIs are used after the backend has been disposed.

**KEY POINT FOR WORKING GROUP**: The Windowing-Input integration mandates the use of source generators. Is this ok?

# Proposed API

```diff
namespace Silk.NET.Input
{
    public interface IInputDevice
    {
-       int Index { get; }
+       /// <summary>
+       /// The backend-specific, device-type-specific identifier for this device.
+       /// </summary>
+       /// <remarks>
+       /// For example, no gamepad may share a DeviceId with another gamepad (same applies for all other device types) on that individual backend.
+       /// This property should not be used as a globally unique identifier.
+       /// </remarks>
+       int DeviceId { get; }
     }
}
```

Index has been removed in favour of DeviceId, as Index implies its globally unique and also tied to the index of the device in the list in which it's contained. The reason why this is not globally unique is primarily to allow users to do their own interop with the native backend using our high-level representations of the devices (i.e. DeviceId will be the GLFW joystick ID)

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
+       /// <remarks>
+       /// Note that because input contexts take ownership of input backends once added, this will dispose the input backend when
+       /// <see cref="Remove" /> is called or this input context is <see cref="Dispose" />d.
+       /// As such, the input backend will not be usable in subsequent contexts - you will need to instantiate a new one instead.
+       /// </remarks>
+       void Add(IInputBackend backend);
+
+       /// <summary>
+       /// Removes the given backend from the list of <see cref="Backends" />.
+       /// </summary>
+       /// <remarks>
+       /// Note that because input contexts take ownership of input backends once added, this will dispose the input backend.
+       /// As such, the input backend will not be usable in subsequent contexts - you will need to instantiate a new one instead.
+       /// </remarks>
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
+   /// <remarks>
+   /// This interface is not intended for general consumption. Consider <see cref="InputContext" /> instead.
+   /// </remarks>
+   public interface IInputBackend : IDisposable
+   {
+       /// <summary>
+       /// Gets all devices of the given type recognised by this backend.
+       /// </summary>
+       /// <remarks>
+       /// The <typeparamref name="T" /> type parameter must be the last interface in the inheritance heirarchy (the "device type")
+       /// i.e. it must be a device type like <see cref="IJoystick" /> and not something like <see cref="IInputDevice" />.
+       /// The behaviour of using a T that isn't a device type recognised by the backend is undefined.<br />
+       /// <br />
+       /// This method is not intended for general consumption. Consider <see cref="InputContext" /> instead.
+       /// </remarks>
+       IReadOnlyList<IInputDevice> GetDevices<T>() where T : IInputDevice;
+
+       /// <summary>
+       /// Raised when an input device is connected or disconnected.
+       /// </summary>
+       event Action<IInputDevice, bool>? ConnectionChanged;
+
+       /// <summary>
+       /// Occurs when the backend is disposing. This can be used as a good indicator that this backend is being removed from an input context.
+       /// </summary>
+       event Action Disposing;
+
+       /// <summary>
+       /// Updates this backend's input data.
+       /// </summary>
+       /// <remarks>
+       /// Input events and changes are permitted to occur outside of this method.
+       /// </remarks>
+       void Update();
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
+       /// the given native handle.
+       /// </summary>
+       /// <param name="handle">The native handle created/sourced from the underlying native API used by this input backend.</param>
+       /// <remarks>
+       /// This method is implicitly called by the Windowing-Input integration. <br />
+       /// On desktop, this uses GLFW. The handle refers to a <c>GLFWwindow*</c> if GLFW is in use.
+       /// </remarks>
+       public static unsafe IInputBackend Create(void* handle);
+   }
}
```
