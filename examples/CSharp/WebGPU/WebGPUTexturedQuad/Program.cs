using System.Numerics;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.WebGPU;
using Silk.NET.WebGPU.Extensions.Disposal;
using Silk.NET.WebGPU.Extensions.WGPU;
using Silk.NET.Windowing;
using Buffer = Silk.NET.WebGPU.Buffer;

namespace WebGPUTexturedQuad;

// ReSharper disable once InconsistentNaming
public static unsafe class WebGPUTexturedQuad
{
    public struct Vertex
    {
        public Vertex(Vector2 position, Vector2 texCoord)
        {
            Position = position;
            TexCoord = texCoord;
        }

        public Vector2 Position;
        public Vector2 TexCoord;
    }
    
    // ReSharper disable once InconsistentNaming
    private static WebGPU         wgpu            = null!;
    private static WebGPUDisposal _WebGpuDisposal = null!;
    private static IWindow?       _Window;

    private static Surface*        _Surface;
    private static Adapter*        _Adapter;
    private static Device*         _Device;
    private static ShaderModule*   _Shader;
    private static RenderPipeline* _Pipeline;
    private static SwapChain*      _SwapChain;
    private static TextureFormat   _SwapChainFormat;

    private static Buffer* _VertexBuffer;
    private static ulong   _VertexBufferSize;

    private const string SHADER = @"
struct VertexOutputs {
    @builtin(position) position: vec4<f32>,
    @location(0) tex_coord: vec2<f32>
}

struct FragmentInputs {
    @location(0) tex_coord: vec2<f32>
}

@vertex
fn vs_main(
    @location(0) pos: vec2<f32>,
    @location(1) tex_coord: vec2<f32>
) -> VertexOutputs {
    var output: VertexOutputs;

    output.position = vec4<f32>(pos, 0.0, 1.0);
    output.tex_coord = tex_coord;

    return output;
}

@fragment
fn fs_main(input: FragmentInputs) -> @location(0) vec4<f32> {
    return vec4<f32>(input.tex_coord.x, input.tex_coord.y, input.tex_coord.x, input.tex_coord.y);
}";

    public static void Main(string[] args)
    {
        //Create window
        var options = WindowOptions.Default;
        options.API                      = GraphicsAPI.None;
        options.Size                     = new Vector2D<int>(800, 600);
        options.FramesPerSecond          = 60;
        options.UpdatesPerSecond         = 60;
        options.Position                 = new Vector2D<int>(0, 0);
        options.Title                    = "WebGPU Textured Quad";
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

    private static void WindowOnUpdate(double delta) {}

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

            var properties = new AdapterProperties();
            wgpu.AdapterGetProperties(_Adapter, &properties);

            Console.WriteLine($"Name: {SilkMarshal.PtrToString((nint) properties.Name)}, Vendor name: {SilkMarshal.PtrToString((nint) properties.VendorName)} backend: {properties.BackendType} Arch: {SilkMarshal.PtrToString((nint) properties.Architecture)}");
        } //Get adapter

        PrintAdapterFeatures();

        { //Get device
            var requiredLimits = stackalloc RequiredLimits[1];
            requiredLimits->Limits.MaxBindGroups = 1;

            var deviceDescriptor = new DeviceDescriptor
            {
                RequiredLimits = requiredLimits,
                DefaultQueue   = new QueueDescriptor()
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

        var vertexAttributes = stackalloc VertexAttribute[2];

        vertexAttributes[0] = new VertexAttribute
        {
            Format         = VertexFormat.Float32x2,
            Offset         = 0,
            ShaderLocation = 0
        };
        vertexAttributes[1] = new VertexAttribute
        {
            Format = VertexFormat.Float32x2,
            Offset = (ulong) sizeof(Vector2),
            ShaderLocation = 1
        };

        var vertexBufferLayout = new VertexBufferLayout
        {
            Attributes     = vertexAttributes,
            AttributeCount = 2,
            StepMode       = VertexStepMode.Vertex, 
            ArrayStride = (ulong) sizeof(Vertex)
        };
        //Create vertex buffer layout

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
                Format    = _SwapChainFormat,
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
                    Module      = _Shader,
                    EntryPoint  = (byte*) SilkMarshal.StringToPtr("vs_main"),
                    Buffers     = &vertexBufferLayout,
                    BufferCount = 1
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
                DepthStencil = null,
            };

            _Pipeline = wgpu.DeviceCreateRenderPipeline(_Device, ref renderPipelineDescriptor);

            Console.WriteLine($"Created pipeline {(nuint) _Pipeline:X}");
        } //Create pipeline

        { //Create vertex buffer
            var descriptor = new BufferDescriptor
            {
                Size  = _VertexBufferSize = (ulong) (sizeof(Vertex) * 6),
                Usage = BufferUsage.Vertex | BufferUsage.CopyDst
            };

            _VertexBuffer = wgpu.DeviceCreateBuffer(_Device, ref descriptor);

            //Get a queue
            var queue = wgpu.DeviceGetQueue(_Device);

            var data = stackalloc Vertex[6];

            //Fill data with a quad with a CCW front face
            data[0] = new Vertex(new Vector2(-0.5f, -0.5f), new Vector2(-1f, -1f)); //Top left
            data[1] = new Vertex(new Vector2(0.5f, -0.5f), new Vector2(1f, -1f));   //Top right
            data[2] = new Vertex(new Vector2(0.5f, 0.5f), new Vector2(1f, 1f));     //Bottom right
            data[3] = new Vertex(new Vector2(-0.5f, -0.5f), new Vector2(-1f, -1f)); //Top left
            data[4] = new Vertex(new Vector2(0.5f, 0.5f), new Vector2(1f, 1f));     //Bottom right
            data[5] = new Vertex(new Vector2(-0.5f, 0.5f), new Vector2(-1f, 1f));   //Bottom left

            //Write the data to the buffer
            wgpu.QueueWriteBuffer(queue, _VertexBuffer, 0, data, (nuint) _VertexBufferSize);

            var commandEncoderDescriptor = new CommandEncoderDescriptor();

            //Create a new command encoder
            var commandEncoder = wgpu.DeviceCreateCommandEncoder(_Device, ref commandEncoderDescriptor);

            var commandBufferDescriptor = new CommandBufferDescriptor();

            //Finish the command encoder
            var commandBuffer = wgpu.CommandEncoderFinish(commandEncoder, ref commandBufferDescriptor);

            wgpu.QueueSubmit(queue, 1, &commandBuffer);
        } //Create vertex buffer

        CreateSwapchain();
    }

    private static void WindowOnRender(double delta)
    {
        TextureView* nextTexture = null;

        for (var attempt = 0; attempt < 2; attempt++)
        {
            nextTexture = wgpu.SwapChainGetCurrentTextureView(_SwapChain);

            if (attempt == 0 && nextTexture == null)
            {
                Console.WriteLine("wgpu.SwapChainGetCurrentTextureView() failed; trying to create a new swap chain...\n");
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
            View          = nextTexture,
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

        var renderPass = wgpu.CommandEncoderBeginRenderPass(encoder, ref renderPassDescriptor);

        wgpu.RenderPassEncoderSetPipeline(renderPass, _Pipeline);
        wgpu.RenderPassEncoderSetVertexBuffer(renderPass, 0, _VertexBuffer, 0, _VertexBufferSize);
        wgpu.RenderPassEncoderDraw(renderPass, 6, 1, 0, 0);

        wgpu.RenderPassEncoderEnd(renderPass);
        _WebGpuDisposal.Dispose(nextTexture);

        var queue = wgpu.DeviceGetQueue(_Device);

        var commandBufferDescriptor = new CommandBufferDescriptor();

        var commandBuffer = wgpu.CommandEncoderFinish(encoder, ref commandBufferDescriptor);

        wgpu.QueueSubmit(queue, 1, &commandBuffer);
        wgpu.SwapChainPresent(_SwapChain);
        _Window.SwapBuffers();
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

    private static void FramebufferResize(Vector2D<int> obj)
    {
        CreateSwapchain();
    }

    private static void CreateSwapchain()
    {
        var swapChainDescriptor = new SwapChainDescriptor
        {
            Usage       = TextureUsage.RenderAttachment,
            Format      = _SwapChainFormat,
            Width       = (uint) _Window.FramebufferSize.X,
            Height      = (uint) _Window.FramebufferSize.Y,
            PresentMode = PresentMode.Fifo
        };

        _SwapChain = wgpu.DeviceCreateSwapChain(_Device, _Surface, ref swapChainDescriptor);
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
