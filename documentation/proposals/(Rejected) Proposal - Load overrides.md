# Summary
Load overrides mean a way to override loading native addresses.
This is useful in the following scenarios:
- P/Invoke / statically linked scenarios, mobile.
- Advanced Performance scenarios, such as pre-loading to improve AOT / linking / R2R

While this API can be used by Hand, and is available for public use it is not designed to be particularly user friendly.
It is designed with SilkTouch as the primary user. (See `PInvokeTableAttribute`)

This proposal also somewhat defines the currently loose timeline of how addresses are loaded.


# Contributors
- Kai Jellinghaus, Maintainer (at time of writing), open source community.

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
There are two separate interfaces to allow maximum flexibility, but also to define exactly at which point slot information is lost.

# Proposed API
Note that this API may be changed in the future to use function pointers directly instead of IntPtrs.
This deliberately doesn't use nint.
```cs
/// <summary>
/// Defines a Load override, capable of loading some entrypoints by name.
/// </summary>
/// <remarks>
/// Load overrides may not cache loads.
/// Load overrides have to be thread safe.
/// </remarks>
public interface INameLoadOverride
{
    /// <summary>
    /// The <see cref="INativeContext"/> used for loading
    /// </summary>
    INativeContext Context { set; }

    /// <summary>
    /// Attempt to load an entrypoint by name.
    /// </summary>
    /// <param name="entrypoint">The entrypoint name to load</param>
    /// <param name="address">The address that was loaded</param>
    /// <returns>
    /// Whether the load was successful.
    /// </returns>
    bool TryLoad(string entrypoint, out IntPtr address);
}

/// <summary>
/// Defines a Load override, capable of loading some entrypoints by slot.
/// </summary>
/// <remarks>
/// Load overrides may not cache loads.
/// Load overrides have to be thread safe.
/// </remarks>
public interface ISlotLoadOverride
{
    /// <summary>
    /// The <see cref="INativeContext"/> used for loading
    /// </summary>
    INativeContext Context { set; }
        
    /// <summary>
    /// Attempt to load an entrypoint by name.
    /// </summary>
    /// <param name="slot">The slot to load</param>
    /// <param name="address">The address that was loaded</param>
    /// <returns>
    /// Whether the load was successful.
    /// This will flush the cache / VTable.
    /// </returns>
    bool TryLoad(int slot, out IntPtr address);
}
```

Not a critical change, but would make sense to make the core easier to understand, because Context, to me, implies some kind of state, which this does not provide.
This simply provides a mecanism to load an address, not access to some kind of native state.
```diff
- public interface INativeContext
+ public interface IAddressLoader
 : IDisposable
{
-    IntPtr GetProcAddress(string proc);
+    IntPtr GetProcAddress(string entrypoint);
}
```

```cs
public abstract class NativeApiContainer
{
    /// <summary>
    /// Registers an <see cref="INameLoadOverride"/> to participate in loading.
    /// </summary>
    /// <remarks>
    /// This method is thread safe.
    /// This will flush the cache / VTable.
    /// </remarks>
    void RegisterOverride(INameLoadOverride override);
    /// <summary>
    /// Registers an <see cref="ISlotLoadOverride"/> to participate in loading.
    /// </summary>
    /// <remarks>
    /// This method is thread safe.
    /// This will flush the cache / VTable.
    /// </remarks>
    void RegisterOverride(ISlotLoadOverride override);
    /// <summary>
    /// Registers multiple <see cref="INameLoadOverride"/>s to participate in loading.
    /// </summary>
    /// <remarks>
    /// This method is thread safe.
    /// This will flush the cache / VTable.
    /// </remarks>
    void RegisterOverrides(IEnumerable<INameLoadOverride> overrides);
    /// <summary>
    /// Registers multiple <see cref="ISlotLoadOverride"/>s to participate in loading.
    /// </summary>
    /// <remarks>
    /// This method is thread safe.
    /// This will flush the cache / VTable.
    /// </remarks>
    void RegisterOverrides(IEnumerable<ISlotLoadOverride> overrides);

    // override address loader is thread safe.
    private sealed class OverrideAddressLoader
    {
        // this is loader falls back to the normal _loader, but first calls into overrides.
        // an instance is kept around, and recreated whenever a new override is registered.
        // for performance reasons it may make sense to defer the creation of this to a Lazy<OverrideAddressLoader>
    
        public IntPtr Load(int slot, string entrypoint);
    }
}
```

Load overrides MAY NOT cache addresses.

These APIs work together with the IVTable, which is the caching solution.

# Address loading timeline
- NativeApiContainer.Load(int, string)
  - VTable
    - if cached, return cached result
    - otherwise
        - OverrideAddressLoader.Load(int, string)
            - calls slot overrides in order, returning the first result.
            - if none were able to resolve the slot, calls entrypoint overrides in order, returning the first result.
            - if none were able to resolve the entrypoint, calls down to the given fallback loader.
        - result cached.

# Open Questions
- it's unclear how this would work with VTable preoloading, we don't use that in Silk.NET right now, so not a problem (for now).
- it's unclear how a user that manually swaps VTables (think Vulkan) would handle it if another user registered an override. there is no way to detect this. It's likely such a user would just not handle this.