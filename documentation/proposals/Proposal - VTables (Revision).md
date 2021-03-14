# Summary
Proposal revisions to the VTable API, allowing for tolearance of non-loads in end-user code.

- Written against **Silk.NET 2.2.0**.
- Slated for **Silk.NET 2.3.0**.

# Contributors
- Dylan P, Ultz Limited
- Kai J, Team Silk.NET

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- In our Avalonia ATG experiment, it was noted that Avalonia does a lot of checking if a function is available before calling the funciton.
- There isn't much plumbing to do this in the library today, you can use the `INativeContext` but this doesn't use the `IVTable` caching mechanism.
- This proposal:
    - adds methods to IVTable to allow for tolerance of non-loads and load checking
    - modifies the internal state of IVTable implementation to use `nint?`
        - `null` will be understood to mean "I haven't tried loading this yet."
        - `0` will be understood to mean "I tried loading this, but it wasn't successful."
        - anything else will be understood to mean "I have a valid function pointer for this."
    - adds a helper function to NativeAPI
- The functionality of these APIs are as follows:
    - Load will forward to TryLoad but will throw if it returns false.
    - TryLoad will attempt to load the function and will update internal state. This function may return a cached result.
    - IsFunctionAvailable implicitly calls TryLoad.
    - Load and IsFunctionAvailable may be able to be implemented as default interface implementations.

# Proposed API
```diff
public interface IVTable
{
    void Initialize(INativeContext ctx, int maxSlots);
    nint Load(int slot, string entryPoint);
+   bool TryLoad(int slot, string entryPoint, out nint fnPtr);
+   bool IsFunctionAvailable(string entryPoint);
    void Purge();
}
```

```diff
public abstract class NativeAPI : NativeApiContainer
{
+   bool IsFunctionAvailable(string entryPoint);
}
```

# Open Questions
- Should we try to make BuildTools expose this in a nice way such that the user doesn't need to know about the native function names? If so, how should we do this? (This has a lot of concerns for overloads which share the same C# name but have a different C name such as `glGetString` and `glGetStringi`)
- Is there a way to make IsFunctionAvailable know about the slot?
- Does Load/TryLoad even work without a slot?
- Should NativeExtension also have a helper method?
    - DYLAN P: I'd argue no because IsExtensionAvailable should implicitly mean the functions are available, so it seems a bit redundant.
