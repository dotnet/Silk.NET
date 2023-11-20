# Summary
Proposal API for specifying platform-specific window creation hints.

- Written against Silk.NET **1.0.1**.
- Slated for Silk.NET **1.0.3**.

# Contributors
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
If Silk.NET's windowing API doesn't expose functionality that the underlying window backend does, we should provide way to allow the user to access this functionality in a semi-dirty if Silk.NET doesn't provide a proper, clean way.

Officially specified behaviour is as follows
- If the Hint's HintName is not supported on a given windowing platform, the Hint should be silently discarded.
- If the Hint's Value is not of the correct type or format, the Hint should be silently discarded.
- There should be no case where the platform hint API will throw an exception or abort the window creation process.

# Proposed API

```cs
public readonly struct Hint
{
    public HintName Name { get; }
    public object Value { get; }
}

public enum HintName
{
    // The format for new hints is <BackendPrefix><Type><Name> for example EglBoolFlugenschlafen
    GlfwBoolFocused = 131073,
    GlfwBoolIconified = 131074,
    GlfwBoolResizable = 131075,
    GlfwBoolVisible = 131076,
    GlfwBoolDecorated = 131077,
    GlfwBoolAutoIconify = 131078,
    GlfwBoolFloating = 131079,
    GlfwBoolMaximized = 131080,
    GlfwBoolCenterCursor = 131081,
    GlfwBoolTransparentFramebuffer = 131082,
    GlfwBoolHovered = 131083,
    GlfwBoolFocusOnShow = 131084,
    GlfwBoolStereo = 135180,
    GlfwBoolSrgbCapable = 135182,
    GlfwBoolDoubleBuffer = 135184,
    GlfwBoolOpenGLForwardCompat = 139270,
    GlfwBoolOpenGLDebugContext = 139271,
    GlfwBoolContextNoError = 139274,
    GlfwIntRedBits = 135169,
    GlfwIntGreenBits = 135170,
    GlfwIntBlueBits = 135171,
    GlfwIntAlphaBits = 135172,
    GlfwIntDepthBits = 135173,
    GlfwIntStencilBits = 135174,
    GlfwIntAccumRedBits = 135175,
    GlfwIntAccumGreenBits = 135176,
    GlfwIntAccumBlueBits = 135177,
    GlfwIntAccumAlphaBits = 135178,
    GlfwIntAuxBuffers = 135179,
    GlfwIntSamples = 135181,
    GlfwIntRefreshRate = 135183,
    GlfwIntContextVersionMajor = 139266,
    GlfwIntContextVersionMinor = 139267,
    GlfwIntContextRevision = 139268,
    GlfwRobustnessContextRobustness = 139269,
    GlfwStringCocoaFrameName = 143362,
    GlfwStringX11ClassName = 147457,
    GlfwStringX11InstanceName = 147458,
    GlfwClientApi = 139265,
    GlfwContextCreationApi = 139275,
    GlfwContextReleaseBehavior = 139273,
    GlfwOpenGlProfile = 139272
}
```

```diff
public struct WindowOptions
{
+    public Hint[] PlatformSpecificHints { get; set; } // Can be null - we haven't discussed use of ? in the codebase yet
}
```
