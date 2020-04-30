# Summary
Currently, in Silk.NET you must have an `IWindow` or `IView` in order to use `Silk.NET.OpenGL`
and if you want to evade our windowing system, a lot of dirty hacks are required in order to
get access to `GL`. 

This proposal, along with others that are along the way, are part of an effort to remove
`SilkManager` in 2.0, which is a really poorly implemented injection system which didn't
really make sense anyway, as API instances would depend on a static state.

- Written against Silk.NET 1.1
- Slated for Silk.NET 1.X

# Contributors
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Points to discuss
- In 2.0 we could completely remove the GL constructors that use SilkManager (after obsoleting them in the next update), so that each GL instance is tied to an OpenGL context. 

# Proposed API
```cs
// Silk.NET.Core
public interface IGLContext : IDisposable
{
    IntPtr Handle { get; }
    bool IsCurrent { get; }
    void SwapInterval(int interval);
    void SwapBuffers();
    void MakeCurrent();
    void Clear();
    IntPtr GetProcAddress(string proc);
}
```

```diff
public interface IView
{
     // NOTE: Still need to discuss nullability attributes
+    IGLContext? Context { get; }
}
```

```diff
// Silk.NET.OpenGL
public abstract class GL
{
     // This overload evades the SilkManager entirely, getting all the data it needs from the context.
+    public static GL GetApi(IGLContext ctx);
}
```
