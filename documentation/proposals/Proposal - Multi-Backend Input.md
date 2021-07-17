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

Similar to Windowing 3.0, a reference implementation will be included in the main `Silk.NET.Input` package which uses the same API or family of APIs as Windowing.
**TODO:** define how this is exposed.

## Source Generator

Alongside the input package there will be a source generator (shipped in a `Silk.NET.Input.Roslyn` NuGet package, which is referenced by the main input package). This source generator will be very small, but it allows us to create a link between windowing and input at compile time without a hard reference.

If the source generator detects that both `Silk.NET.Input` and `Silk.NET.Windowing` are referenced, 
**TODO: ** carry on
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
-   public interface IInputContext : IDisposable
+   public class InputContext : IDisposable
    {
-       nint Handle { get; }
        IReadOnlyList<IGamepad> Gamepads { get; }
        IReadOnlyList<IJoystick> Joysticks { get; }
        IReadOnlyList<IKeyboard> Keyboards { get; }
        IReadOnlyList<IMouse> Mice { get; }
        IReadOnlyList<IInputDevice> OtherDevices { get; }
+       IReadOnlyList<IInputBackend> Backends { get; }
+       void AddBackend(IInputBackend backend);
+       void RemoveBackend(IInputBackend backend);
        event Action<IInputDevice, bool>? ConnectionChanged;
    }
}
```

```cs
namespace Silk.NET.Input
{
    public interface IInputBackend
    {
        IReadOnlyList<IInputDevice> ConnectedDevices { get; }
        event Action<IInputDevice, bool>? ConnectionChanged;
    }
}
```

```diff
-namespace Silk.NET.Input
-{
-    public static class InputWindowExtensions
-    {
-        // ...
-    }
-}
```
