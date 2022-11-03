// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.WebGPU;
using Silk.NET.WebGPU.Extensions.Disposal;
using Silk.NET.WebGPU.Extensions.WGPU;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Extensions.WebGPU;

namespace WebGPUTriangle;

public static unsafe class Program
{
    // ReSharper disable once InconsistentNaming
    private static WebGPU wgpu = null!;
    private static WebGPUDisposal _WebGpuDisposal = null!;
    private static IWindow? _Window;

    private static Surface* _Surface;
    private static Adapter* _Adapter;
    private static Device* _Device;
    private static ShaderModule* _Shader;
    private static RenderPipeline* _Pipeline;
    private static SwapChain* _SwapChain;
    private static TextureFormat _SwapChainFormat;

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
        options.API = GraphicsAPI.None;
        options.Size = new Vector2D<int>(800, 600);
        options.FramesPerSecond = 60;
        options.UpdatesPerSecond = 60;
        options.Position = new Vector2D<int>(0, 0);
        options.Title = "WebGPU Triangle";
        options.IsVisible = true;

        _Window = Window.Create(WindowOptions.Default);

        _Window.Load += WindowOnLoad;
        _Window.Closing += WindowClosing;
        _Window.Update += WindowOnUpdate;
        _Window.Render += WindowOnRender;
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

        _WebGpuDisposal = new WebGPUDisposal(wgpu);

        _Surface = _Window.CreateWebGPUSurface(wgpu);

        { //Get adapter
            var requestAdapterOptions = new RequestAdapterOptions
            {
                CompatibleSurface = _Surface
            };

            wgpu.InstanceRequestAdapter
            (
                null,
                ref requestAdapterOptions,
                new PfnRequestAdapterCallback((_, adapter1, _, _) => _Adapter = adapter1),
                null
            );

            Console.WriteLine($"Got adapter {(nuint) _Adapter:X}");
        } //Get adapter

        PrintAdapterFeatures();

        { //Get device
            var requiredLimits = stackalloc RequiredLimits[1];
            requiredLimits->Limits.MaxBindGroups = 1;

            var deviceDescriptor = new DeviceDescriptor
            {
                RequiredLimits = requiredLimits,
                DefaultQueue = new QueueDescriptor()
            };

            wgpu.AdapterRequestDevice
            (
                _Adapter,
                ref deviceDescriptor,
                new PfnRequestDeviceCallback((_, device1, _, _) => _Device = device1),
                null
            );

            Console.WriteLine($"Got device {(nuint) _Device:X}");
        } //Get device

        wgpu.DeviceSetUncapturedErrorCallback(_Device, new PfnErrorCallback(UncapturedError), null);
        wgpu.DeviceSetDeviceLostCallback(_Device, new PfnDeviceLostCallback(DeviceLost), null);

        { //Load shader
            var wgslDescriptor = new ShaderModuleWGSLDescriptor
            {
                Code = (byte*) SilkMarshal.StringToPtr(SHADER),
                Chain = new ChainedStruct
                {
                    SType = SType.ShaderModuleWgsldescriptor
                }
            };

            var shaderModuleDescriptor = new ShaderModuleDescriptor
            {
                NextInChain = (ChainedStruct*) (&wgslDescriptor),
            };

            _Shader = wgpu.DeviceCreateShaderModule(_Device, ref shaderModuleDescriptor);

            Console.WriteLine($"Created shader {(nuint) _Shader:X}");
        } //Load shader

        _SwapChainFormat = wgpu.SurfaceGetPreferredFormat(_Surface, _Adapter);

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
                Format = _SwapChainFormat,
                Blend = &blendState,
                WriteMask = ColorWriteMask.All
            };

            var fragmentState = new FragmentState
            {
                Module = _Shader,
                TargetCount = 1,
                Targets = &colorTargetState,
                EntryPoint = (byte*) SilkMarshal.StringToPtr("fs_main")
            };

            var renderPipelineDescriptor = new RenderPipelineDescriptor
            {
                Vertex = new VertexState
                {
                    Module = _Shader,
                    EntryPoint = (byte*) SilkMarshal.StringToPtr("vs_main"),
                },
                Primitive = new PrimitiveState
                {
                    Topology = PrimitiveTopology.TriangleList,
                    StripIndexFormat = IndexFormat.Undefined,
                    FrontFace = FrontFace.Ccw,
                    CullMode = CullMode.None
                },
                Multisample = new MultisampleState
                {
                    Count = 1,
                    Mask = ~0u,
                    AlphaToCoverageEnabled = false
                },
                Fragment = &fragmentState,
                DepthStencil = null
            };

            _Pipeline = wgpu.DeviceCreateRenderPipeline(_Device, ref renderPipelineDescriptor);

            Console.WriteLine($"Created pipeline {(nuint) _Pipeline:X}");
        } //Create pipeline

        CreateSwapchain();
    }

    private static void WindowClosing()
    {
        _WebGpuDisposal.Dispose(_Shader);
        _WebGpuDisposal.Dispose(_Pipeline);
        _WebGpuDisposal.Dispose(_Device);
        _WebGpuDisposal.Dispose(_Adapter);
        _WebGpuDisposal.Dispose(_Surface);

        wgpu.Dispose();
    }

    private static void CreateSwapchain()
    {
        var swapChainDescriptor = new SwapChainDescriptor
        {
            Usage = TextureUsage.RenderAttachment,
            Format = _SwapChainFormat,
            Width = (uint) _Window.FramebufferSize.X,
            Height = (uint) _Window.FramebufferSize.Y,
            PresentMode = PresentMode.Fifo
        };

        _SwapChain = wgpu.DeviceCreateSwapChain(_Device, _Surface, ref swapChainDescriptor);
    }

    private static void WindowOnUpdate(double delta) { }

    private static void WindowOnRender(double delta)
    {
        TextureView* nextTexture = null;

        for (var attempt = 0; attempt < 2; attempt++)
        {
            nextTexture = wgpu.SwapChainGetCurrentTextureView(_SwapChain);

            if (attempt == 0 && nextTexture == null)
            {
                Console.WriteLine("wgpu.SwapChainGetCurrentTextureView() failed; trying to create " + "a new swap chain...\n");
                CreateSwapchain();
                continue;
            }

            break;
        }

        if (nextTexture == null)
        {
            Console.WriteLine("wgpu.SwapChainGetCurrentTextureView() failed after multiple attempts; giving up.\n");
            return;
        }

        var commandEncoderDescriptor = new CommandEncoderDescriptor();

        var encoder = wgpu.DeviceCreateCommandEncoder(_Device, ref commandEncoderDescriptor);

        var colorAttachment = new RenderPassColorAttachment
        {
            View = nextTexture,
            ResolveTarget = null,
            LoadOp = LoadOp.Clear,
            StoreOp = StoreOp.Store,
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
            ColorAttachments = &colorAttachment,
            ColorAttachmentCount = 1,
            DepthStencilAttachment = null
        };

        var renderPass = wgpu.CommandEncoderBeginRenderPass(encoder, ref renderPassDescriptor);

        wgpu.RenderPassEncoderSetPipeline(renderPass, _Pipeline);
        wgpu.RenderPassEncoderDraw(renderPass, 3, 1, 0, 0);
        wgpu.RenderPassEncoderEnd(renderPass);
        _WebGpuDisposal.Dispose(nextTexture);

        var queue = wgpu.DeviceGetQueue(_Device);

        var commandBufferDescriptor = new CommandBufferDescriptor();

        var commandBuffer = wgpu.CommandEncoderFinish(encoder, ref commandBufferDescriptor);

        wgpu.QueueSubmit(queue, 1, &commandBuffer);
        wgpu.SwapChainPresent(_SwapChain);
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
