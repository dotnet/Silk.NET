# Silk.NET.Windowing

Silk.NET.Windowing is our cross-platform windowing abstraction. For more information about what it is, see the [proposal](../../proposals/Proposal%20-%20Windowing%203.0.md).

As per the proposal, Windowing is implemented in exactly one project/assembly containing the abstractions and one
"reference implementation" given available target information (e.g. TFM). Today, this includes:
- SDL3, used for every platform.

If the user doesn't want to use our reference implementation, it is expected that they use the trimmer to make its
presence benign.

Note that for each "reference implementation" it is expected that there shall be a matching Silk.NET.Input "reference
implementation" capable of receiving an `INativeWindow` from the Silk.NET.Windowing implementation in use. How you
interpret this requirement is up to you, e.g. we could have a Silk.NET.Input Win32-specific implementation that uses
`Win32PlatformInfo` for our SDL3 surface, likewise we could have a Silk.NET.Input SDL3 implementation that receives a
`Win32PlatformInfo` from a Silk.NET.Windowing implementation and automatically creates a wrapping window - this is up to
you (but try to keep it sane please, that last one sounded extremely cursed). Ultimately, the goal is the user being
able to pull in `Silk.NET.Windowing` and `Silk.NET.Input`, create a surface, be able to do `surface.CreateInput()` and
it all Just Work. Right now, this equates to a 1:1 match of Silk.NET.Windowing/Silk.NET.Input implementations, and is
not expected to change.

Silk.NET.Input is completely independent from Silk.NET.Windowing this time around, unlike 1.X/2.X. This is because we
believe the Input HLU can target wider applicability beyond just receiving input for a window, with VR being the
principal use case in mind when making this decision. For more information, read the [Multi-Backend Input proposal](../../proposals/Proposal%20-%20Multi-Backend%20Input.md).

Most of the files within the top-level Windowing directory are exactly as proposed. The exception is the `Surface`
class, which seeks to make as much common as humanly possible (this includes the Render/Update timing logic and some
other auxiliary functions). Beyond that, this is functionally an interface. The actual entry-points into the Windowing
API, `ISurfaceApplication.Run` and `IDetachedSurfaceLifecycle.TryCreate`, are defined `partial`ly with matching
implementation parts in the `Implementations` subdirectories.

To find out more about the implementation details, see the `Implementations` directory.
