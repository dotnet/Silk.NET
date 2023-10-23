// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.WebGPU;
using Silk.NET.Windowing;

namespace WebGPUTriangle;

public static unsafe class Program
{
    // ReSharper disable once InconsistentNaming
    private static WebGPU   wgpu = null!;
    private static IWindow _Window = null!;
    
    private static Surface*        _Surface;
    private static SurfaceConfiguration _SurfaceConfiguration;
    private static SurfaceCapabilities _SurfaceCapabilities;

    private static Instance*       _Instance;
    private static Adapter*        _Adapter;
    private static Device*         _Device;
    private static ShaderModule*   _Shader;
    private static RenderPipeline* _Pipeline;

    private const string SHADER = @"@vertex
fn vs_main(@builtin(vertex_index) in_vertex_index: u32) -> @builtin(position) vec4<f32> {
    let x = f32(i32(in_vertex_index) - 1);
    let y = f32(i32(in_vertex_index & 1u) * 2 - 1);
    return vec4<f32>(x, y, 0.0, 1.0);
}

@fragment
fn fs_main() -> @location(0) vec4<f32> {
    return vec4<f32>(1.0, 0.0, 0.0, 1.0);
}";

    public static void Main()
    {
        //Create window
        var options = WindowOptions.Default;
        options.API                      = GraphicsAPI.None;
        options.Size                     = new Vector2D<int>(800, 600);
        options.FramesPerSecond          = 60;
        options.UpdatesPerSecond         = 60;
        options.Position                 = new Vector2D<int>(0, 0);
        options.Title                    = "WebGPU Triangle";
        options.IsVisible                = true;
        options.ShouldSwapAutomatically  = false;
        options.IsContextControlDisabled = true;

        _Window = Window.Create(options);

        _Window.Load              += WindowOnLoad;
        _Window.Closing           += WindowClosing;
        _Window.Update            += WindowOnUpdate;
        _Window.Render            += WindowOnRender;
        _Window.FramebufferResize += FramebufferResize;

        _Window.Run();
    }

    private static void FramebufferResize(Vector2D<int> obj)
    {
        CreateSwapchain();
    }

    private static void WindowOnLoad()
    {
        wgpu = WebGPU.GetApi();

        InstanceDescriptor instanceDescriptor = new InstanceDescriptor();
        _Instance = wgpu.CreateInstance(&instanceDescriptor);

        _Surface = _Window.CreateWebGPUSurface(wgpu, _Instance);

        { //Get adapter
            var requestAdapterOptions = new RequestAdapterOptions
            {
                CompatibleSurface = _Surface
            };

            wgpu.InstanceRequestAdapter
            (
                _Instance,
                requestAdapterOptions,
                new PfnRequestAdapterCallback((_, adapter1, _, _) => _Adapter = adapter1),
                null
            );

            Console.WriteLine($"Got adapter {(nuint) _Adapter:X}");
        } //Get adapter

        PrintAdapterFeatures();

        { //Get device
            var deviceDescriptor = new DeviceDescriptor
            {
                DeviceLostCallback = new PfnDeviceLostCallback(DeviceLost),
            };

            wgpu.AdapterRequestDevice
            (
                _Adapter,
                in deviceDescriptor,
                new PfnRequestDeviceCallback((_, device1, _, _) => _Device = device1),
                null
            );

            Console.WriteLine($"Got device {(nuint) _Device:X}");
        } //Get device

        wgpu.DeviceSetUncapturedErrorCallback(_Device, new PfnErrorCallback(UncapturedError), null);

        { //Load shader
            var wgslDescriptor = new ShaderModuleWGSLDescriptor
            {
                Code = (byte*) SilkMarshal.StringToPtr(SHADER),
                Chain = new ChainedStruct
                {
                    SType = SType.ShaderModuleWgslDescriptor
                }
            };

            var shaderModuleDescriptor = new ShaderModuleDescriptor
            {
                NextInChain = (ChainedStruct*) (&wgslDescriptor),
            };

            _Shader = wgpu.DeviceCreateShaderModule(_Device, shaderModuleDescriptor);

            Console.WriteLine($"Created shader {(nuint) _Shader:X}");
        } //Load shader

        wgpu.SurfaceGetCapabilities(_Surface, _Adapter, ref _SurfaceCapabilities);

        { //Create pipeline
            var blendState = new BlendState
            {
                Color = new BlendComponent
                {
                    SrcFactor = BlendFactor.One,
                    DstFactor = BlendFactor.Zero,
                    Operation = BlendOperation.Add
                },
                Alpha = new BlendComponent
                {
                    SrcFactor = BlendFactor.One,
                    DstFactor = BlendFactor.Zero,
                    Operation = BlendOperation.Add
                }
            };

            var colorTargetState = new ColorTargetState
            {
                Format    = _SurfaceCapabilities.Formats[0],
                Blend     = &blendState,
                WriteMask = ColorWriteMask.All
            };

            var fragmentState = new FragmentState
            {
                Module      = _Shader,
                TargetCount = 1,
                Targets     = &colorTargetState,
                EntryPoint  = (byte*) SilkMarshal.StringToPtr("fs_main")
            };

            var renderPipelineDescriptor = new RenderPipelineDescriptor
            {
                Vertex = new VertexState
                {
                    Module     = _Shader,
                    EntryPoint = (byte*) SilkMarshal.StringToPtr("vs_main"),
                },
                Primitive = new PrimitiveState
                {
                    Topology         = PrimitiveTopology.TriangleList,
                    StripIndexFormat = IndexFormat.Undefined,
                    FrontFace        = FrontFace.Ccw,
                    CullMode         = CullMode.None
                },
                Multisample = new MultisampleState
                {
                    Count                  = 1,
                    Mask                   = ~0u,
                    AlphaToCoverageEnabled = false
                },
                Fragment     = &fragmentState,
                DepthStencil = null
            };

            _Pipeline = wgpu.DeviceCreateRenderPipeline(_Device, renderPipelineDescriptor);

            Console.WriteLine($"Created pipeline {(nuint) _Pipeline:X}");
        } //Create pipeline

        CreateSwapchain();
    }

    private static void WindowClosing()
    {
        wgpu.ShaderModuleRelease(_Shader);
        wgpu.RenderPipelineRelease(_Pipeline);
        wgpu.DeviceRelease(_Device);
        wgpu.AdapterRelease(_Adapter);
        wgpu.SurfaceRelease(_Surface);
        wgpu.InstanceRelease(_Instance);

        wgpu.Dispose();
    }

    private static void CreateSwapchain()
    {
        _SurfaceConfiguration = new SurfaceConfiguration
        {
            Usage = TextureUsage.RenderAttachment, 
            Format = _SurfaceCapabilities.Formats[0], 
            PresentMode = PresentMode.Fifo, 
            Device = _Device, 
            Width = (uint)_Window.FramebufferSize.X,
            Height = (uint)_Window.FramebufferSize.Y 
        };

        wgpu.SurfaceConfigure(_Surface, _SurfaceConfiguration);
    }

    private static void WindowOnUpdate(double delta) {}

    private static void WindowOnRender(double delta)
    {
        SurfaceTexture surfaceTexture;
        wgpu.SurfaceGetCurrentTexture(_Surface, &surfaceTexture);
        switch (surfaceTexture.Status)
        {
            case SurfaceGetCurrentTextureStatus.Timeout:
            case SurfaceGetCurrentTextureStatus.Outdated:
            case SurfaceGetCurrentTextureStatus.Lost:
                // Recreate swapchain,
                wgpu.TextureRelease(surfaceTexture.Texture);
                CreateSwapchain();
                // Skip this frame
                return;
            case SurfaceGetCurrentTextureStatus.OutOfMemory:
            case SurfaceGetCurrentTextureStatus.DeviceLost:
            case SurfaceGetCurrentTextureStatus.Force32:
                throw new Exception($"What is going on bros... {surfaceTexture.Status}");
        }

        var view = wgpu.TextureCreateView(surfaceTexture.Texture, null);

        var commandEncoderDescriptor = new CommandEncoderDescriptor();

        var encoder = wgpu.DeviceCreateCommandEncoder(_Device, commandEncoderDescriptor);

        var colorAttachment = new RenderPassColorAttachment
        {
            View          = view,
            ResolveTarget = null,
            LoadOp        = LoadOp.Clear,
            StoreOp       = StoreOp.Store,
            ClearValue = new Color
            {
                R = 0,
                G = 1,
                B = 0,
                A = 1
            }
        };

        var renderPassDescriptor = new RenderPassDescriptor
        {
            ColorAttachments       = &colorAttachment,
            ColorAttachmentCount   = 1,
            DepthStencilAttachment = null
        };

        var renderPass = wgpu.CommandEncoderBeginRenderPass(encoder, renderPassDescriptor);

        wgpu.RenderPassEncoderSetPipeline(renderPass, _Pipeline);
        wgpu.RenderPassEncoderDraw(renderPass, 3, 1, 0, 0);
        wgpu.RenderPassEncoderEnd(renderPass);

        var queue = wgpu.DeviceGetQueue(_Device);

        var commandBuffer = wgpu.CommandEncoderFinish(encoder, new CommandBufferDescriptor());

        wgpu.QueueSubmit(queue, 1, &commandBuffer);
        wgpu.SurfacePresent(_Surface);
        wgpu.CommandBufferRelease(commandBuffer);
        wgpu.RenderPassEncoderRelease(renderPass);
        wgpu.CommandEncoderRelease(encoder);
        wgpu.TextureViewRelease(view);
        wgpu.TextureRelease(surfaceTexture.Texture);
    }

    private static void PrintAdapterFeatures()
    {
        var count = (int) wgpu.AdapterEnumerateFeatures(_Adapter, null);

        var features = stackalloc FeatureName[count];

        wgpu.AdapterEnumerateFeatures(_Adapter, features);

        Console.WriteLine("Adapter features:");

        for (var i = 0; i < count; i++)
        {
            Console.WriteLine($"\t{features[i]}");
        }
    }

    private static void DeviceLost(DeviceLostReason arg0, byte* arg1, void* arg2)
    {
        Console.WriteLine($"Device lost! Reason: {arg0} Message: {SilkMarshal.PtrToString((nint) arg1)}");
    }

    private static void UncapturedError(ErrorType arg0, byte* arg1, void* arg2)
    {
        Console.WriteLine($"{arg0}: {SilkMarshal.PtrToString((nint) arg1)}");
    }
}
