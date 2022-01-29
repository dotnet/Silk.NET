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
- This proposal, while aiming to keep the same look and feel as the 2.0 API, is a complete redesign of the Input API with the following goals:
    - Input backends can be added and removed at will to a central input context object.
    - All input devices, regardless of what backends they come from, can be accessed from a central input context object.
    - Should the Silk.NET team design more APIs for more devices (for example VR hands using OpenXR) in the future, this can be added in a non-breaking way.
    - All input devices instead of exposing properties only expose a single `State` property, with additional properties and/or methods for writable state (i.e. vibration motors, mouse position). This also addresses comments from the Working Group on previous iterations of this proposal, where the Working Group expressed interest in the state being immutable and trivially capturable.
    - Ensuring the input API is accessible and easy to use (e.g. this is why later in the proposal we have made properties on the state structures that just forward to the underlying device object)
    - Addressing APIs that the userbase frequently had issues/distaste with. For example, events are no longer on each individual 
- This proposal aims to keep the look and feel of the Input APIs intended for general consumption similar to that of 2.0.
- This proposal incorporates/supersedes the Enhanced Input Events proposal.
- This proposal assumes knowledge of the Windowing 3.0 proposal.
- This proposal assumes knowledge of Silk.NET.Core 2.0.

# Reference Implementation

Similar to Windowing 3.0, a reference implementation will be included in the main `Silk.NET.Input` package which uses the same API or family of APIs as Windowing's reference implementation. This will be exposed by the `InputWindowExtensions` class.

```cs
public static class InputWindowExtensions
{
    public static IInputBackend CreateInputBackend(this NativeWindow window);
    public static IInputBackend CreateInputBackend(this INativeWindowSource window);
    public static InputContext CreateInput(this NativeWindow window);
    public static InputContext CreateInput(this INativeWindowSource window);
}
```

The `CreateInputBackend` will create an instance of the reference implementation for the given `NativeWindow`. The `INativeWindowSource` overloads just forward to the `NativeWindow` overload. This is because `ISurface` will implement `INativeWindowSource`, so the extension methods will be usable on an `ISurface` without having a hard reference between Windowing and Input.

The `CreateInput` methods simply return an `InputContext` preconfigured with the backend created by `CreateInputBackend` for ease of use.

**NOTE:** As part of this proposal, `INativeWindow` is renamed to `NativeWindow` and changed from an `interface` to a `readonly record struct`. The API is otherwise exactly the same.

# Devices, Backends, and Contexts

Input devices all inherit from a root interface.

```cs
public interface IInputDevice
{
    nint BackendId { get; }
    string Name { get; }
}
```

`BackendId` is an integral identifier for this device unique to this backend **only** - i.e. it is not globally unique, and if you have an input context with multiple backends there may be multiple devices with a particular `BackendId`. It may be a handle to memory, or it may be a generic integral index - this is implementation-defined.

`Name` is a rough description of the input device. Its value is not intrinsically meaningful.

All devices originate from a context.

```cs
public interface IInputBackend
{
    string Name { get; }
    nint Handle { get; }
    IReadOnlyList<IInputDevice> Devices { get; }
    void Update();
}
```

`Name` is a rough description of the input backend. Its value is not intrinsically meaningful.

`Handle` is a globally-unique handle to memory for this input backend. The memory this handle actually points to is implementation-defined.

`Devices` enumerates all of the **connected** devices available from this input backend. When a device is disconnected, its `IInputDevice` object should be discarded by all that consumed it, as it can not be relied upon for being reused by the input backend. An implementation is welcome to reuse old objects, but this is strictly implementation-defined. A device not being present in the `Devices` list is sufficient evidence that a device has been disconnected.

`Update` **TODO**

# Proposed API
