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
    - Input contexts and the devices therein are no longer interfaces. They are instead structures containing a handle and a backend object. See the proposed API for details.
    - They may now only be one mouse and one keyboard. This is because no supported operating system actually allows multiple mice or keyboards to be reported individually.
    - There is now another layer to input: the LLAPI.

## Input Low-Level API (LLAPI)

In order to faciliate the goal of allowing multiple backends, we needed to remove the close tie between the platform and the high-level input API. To do this, this proposal adds a low-level API to be stored in the `Silk.NET.Input.Internals` namespace.

**OPEN QUESTION:** what should we call this namespace? `Silk.NET.Input.Internals` is used as a placeholder.

### Device Handles

Each kind of device which allows multiple instances (i.e. everything but keyboard and mouse as discussed earlier) will have a handle specific to that backend. For example, there will be:
- `JoystickHandle`
- `GamepadHandle`

Both of which containing a `ulong` handle allocated by the backend.


# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.

```cs
namespace Silk.NET.Inout.Internals
{
    public interface IInputBackend
    {
        void QueryDevices<TDeviceHandle>(out int numDevices) where TDeviceHandle : unmanaged;
        void QueryDevices<TDeviceHandle>(Span<TDeviceHandle> deviceHandles) where TDeviceHandle : unmanaged;
        void QueryDevice<TDeviceHandle, TDataType>(TDeviceHandle device, DeviceDataKind key, out TDataType value) where TDeviceHandle : unmanaged where TDataType : unmanaged;
        void QueryGlobal<TDataType>(GlobalDataKind key, out TDataType value) where TDataType : unmanaged;
        void Update();
    }
}
```

```cs
/// <summary>
/// Represents a grenade.
/// </summary>
public class SilkGrenade
{
    /// <summary>
    /// What does this do?!?
    /// </summary>
    public void RedButton();
    /// <summary>
    /// Detonates the grenade.
    /// </summary>
    protected void Kaboom();
    /// <summary>
    /// Gets or sets whether this grenade is disarmed or not.
    /// </summary>
    public bool Disarmed { get; set; }
}
```
