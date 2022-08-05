using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.Implementations.GLFW;

public class GLFWSurface : IGLTransparentFramebuffer, IGlesDesktopSurface, IVkDesktopSurface, IGLDesktopSurface
{
    IGlesSurface? _sharedContext;
    IGLSurface? _sharedContext1;
    public WindowHandles Native { get; }
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool IsTerminating { get; }
    public bool IsPausing { get; }
    public double Time { get; }
    public Vector2D<int> FramebufferSize { get; }
    public bool IsVisible { get; set; }
    public Vector2D<int> Position { get; set; }
    public Vector2D<int> Size { get; set; }
    public string Title { get; set; }
    public WindowState WindowState { get; set; }
    public WindowBorder WindowBorder { get; set; }
    public VideoMode VideoMode { get; set; }
    public IScreen? CurrentScreen { get; set; }
    public IEnumerable<IScreen>? AvailableScreens { get; }
    public bool IsEventDriven { get; set; }
    public bool IsCloseRequested { get; set; }
    public bool IsFocused { get; }
    public Rectangle<int> BorderSize { get; }
    public event Action? CloseRequested;
    public event Vector2DAction? Move;
    public event WindowStateAction? StateChanged;
    public event FilePathsAction? FileDrop;
    public event ToggleAction? FocusChanged;
    public double FramesPerSecond { get; set; }
    public double UpdatesPerSecond { get; set; }
    public event Vector2DAction? Resize;
    public event Vector2DAction? FramebufferResize;
    public event Action? Terminating;
    public event Action? LowMemory;
    public event Action? Pausing;
    public event Action? Resuming;
    public event Action? Created;
    public event Action? PreUpdate;
    public event DeltaAction? Update;
    public event DeltaAction? Render;
    public nint Handle { get; }
    public bool IsContextCurrent { get; set; }
    public bool ShouldSwapAutomatically { get; set; }
    public int SwapInterval { get; set; }
    public int? PreferredDepthBufferBits { get; set; }
    public int? PreferredStencilBufferBits { get; set; }
    public Vector4D<int>? PreferredBitDepth { get; set; }
    public Version32? ApiVersion { get; set; }
    public nint? GetProcAddress(string proc)
    {
        throw new NotImplementedException();
    }

    public bool TransparentFramebuffer { get; set; }
    public ContextFlags ContextFlags { get; set; }
    public ContextProfile ContextProfile { get; set; }

    IGLSurface? IGLSurface.SharedContext
    {
        get => _sharedContext1;
        set => _sharedContext1 = value;
    }

    IGlesSurface? IGlesSurface.SharedContext
    {
        get => _sharedContext;
        set => _sharedContext = value;
    }

    public bool TryEnableOpenGLES()
    {
        throw new NotImplementedException();
    }

    public bool TryEnableVulkan()
    {
        throw new NotImplementedException();
    }
}