# Summary
This proposal introduces the concept of a "window host" to Silk.NET - an object on which windows can be created.
More importantly, this proposal introduces monitor APIs (an example of a window host) and subwindows
- where all windows are also window hosts.

# Contributors
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

# Design Decisions
This proposal purposely excludes window views as described in the views proposal, as barely any of the concepts
are applicable to mobile/view-based windowing platforms.

# Proposed API

## Window hosts

### IWindowHost
```cs
public interface IWindowHost
{
    IWindow CreateWindow(WindowOptions opts);
}
```

### IWindowPlatform
```diff
-public interface IWindowPlatform
+public interface IWindowPlatform : IWindowHost
{
-    IWindow GetWindow(WindowOptions opts);
+    IWindow CreateWindow(WindowOptions opts);
+    IEnumerable<IMonitor> GetMonitors();
}
```

### IWindow
```diff
-public interface IWindow : IView, IWindowProperties, IWindowFunctions, IWindowEvents
+public interface IWindow : IView, IWindowHost, IWindowProperties, IWindowFunctions, IWindowEvents
{
     // NOTE: Purposely not included in IWindowProperties as the hosts API should be used to create a window on a monitor, not the WindowOptions API.
+    IMonitor Monitor { get; set; }
}
```

## Monitors
### IMonitor
```cs
public interface IMonitor : IWindowHost
{
    string Name { get; }
    int Index { get; }
    Rectangle Bounds { get; }
    int RefreshRate { get; }
}
```

### Monitor
```cs
public static class Monitor
{
    public static IEnumerable<IMonitor> GetMonitors();
    public static IMonitor GetMainMonitor();
}
```
