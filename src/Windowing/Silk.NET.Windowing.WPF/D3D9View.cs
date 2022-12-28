// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D9;
using Silk.NET.Maths;
using Silk.NET.Windowing.Internals;

namespace Silk.NET.Windowing.WPF;

internal unsafe class D3D9View : ViewImplementationBase
{
    private D3D9 _api;
    private ComPtr<IDirect3D9Ex> _d3d9;
    private ComPtr<IDirect3DDevice9Ex> _device;
    private ComPtr<IDirect3DSurface9> _surface;
    private bool _isClosing;
    private IGLContext _glContext;

    public D3D9View(ViewOptions opts) : base(opts)
    {
    }
    
    // Core APIs


    protected override Vector2D<int> CoreSize
    {
        get
        {
            SurfaceDesc desc = default;
            SilkMarshal.ThrowHResult(_surface.GetDesc(ref desc));
            return new Vector2D<int>((int)desc.Width, (int)desc.Height);
        }
    }

    protected override nint CoreHandle => (nint) _surface.Handle;
    protected override bool CoreIsClosing => _isClosing;
    protected override IGLContext CoreGLContext => _glContext;
    protected override IVkSurface CoreVkSurface => null;
    protected override void CoreInitialize(ViewOptions opts)
    {
        var rgbx = (
            opts.PreferredBitDepth?.X,
            opts.PreferredBitDepth?.Y,
            opts.PreferredBitDepth?.Z,
            opts.PreferredBitDepth?.W
        );

        var presentParameters = new PresentParameters
        {
            Windowed = 1,
            SwapEffect = Swapeffect.Discard,
            PresentationInterval = 0 /* TODO vsync */,
            BackBufferFormat = rgbx switch
            {
                (3, 3, 2, 0) => Format.R3G3B2,
                (4, 4, 4, 4) => Format.X4R4G4B4,
                (5, 6, 5, 0) => Format.R5G6B5,
                (5, 5, 5, 1) => Format.X1R5G5B5,
                (8, 8, 8, 0) => Format.R8G8B8,
                (8, 8, 8, 8) or (null, null, null, null) => Format.X8R8G8B8,
                _ => throw new NotSupportedException("Unsupported D3D pixel format. Note that only XRGB formats are used rather than ARGB.")
            },
            BackBufferWidth = 1,
            BackBufferHeight = 1,
            AutoDepthStencilFormat = Format.Unknown,
            EnableAutoDepthStencil = false,
            BackBufferCount = 1,
            Flags = 0,
            FullScreenRefreshRateInHz = 0,
            MultiSampleType = 0,
            MultiSampleQuality = 0
        };
        
        _api = D3D9.GetApi();
        SilkMarshal.ThrowHResult(_api.Direct3DCreate9Ex(32, ref _d3d9));
        SilkMarshal.ThrowHResult
        (
            _d3d9.CreateDeviceEx
            (
                0,
                Devtype.None,
                default,
                D3D9.CreateMultithreaded,
                ref presentParameters,
                null,
                ref _device
            )
        );
        
        SilkMarshal.ThrowHResult(_device.CreateRenderTarget());
    }

    private void CreateRenderTarget()
    {
        
    }

    protected override void CoreReset()
    {
        throw new NotImplementedException();
    }

    public override VideoMode VideoMode { get; }
    public override bool IsEventDriven { get; set; }
    public override Vector2D<int> FramebufferSize { get; }
    public override void DoEvents()
    {
    }

    public override void ContinueEvents()
    {
    }

    public override void Close()
    {
        throw new NotImplementedException();
    }

    protected override void RegisterCallbacks()
    {
        throw new NotImplementedException();
    }

    protected override void UnregisterCallbacks()
    {
        throw new NotImplementedException();
    }

    protected override INativeWindow GetNativeWindow()
    {
        throw new NotImplementedException();
    }

    public override event Action<Vector2D<int>> Resize;
    public override event Action<Vector2D<int>> FramebufferResize;
    public override event Action Closing;
    public override event Action<bool> FocusChanged;
    public override Vector2D<int> PointToClient(Vector2D<int> point)
    {
        throw new NotImplementedException();
    }

    public override Vector2D<int> PointToScreen(Vector2D<int> point)
    {
        throw new NotImplementedException();
    }
}
