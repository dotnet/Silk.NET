using System.Numerics;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.WebGPU;
using Silk.NET.WebGPU.Extensions.Disposal;
using Silk.NET.WebGPU.Extensions.WGPU;
using Silk.NET.Windowing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Buffer = Silk.NET.WebGPU.Buffer;
using Color = Silk.NET.WebGPU.Color;

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

    private static Texture*     _Texture;
    private static TextureView* _TextureView;
    private static Sampler*     _Sampler;

    private static BindGroup*       _TextureBindGroup;
    private static BindGroupLayout* _TextureSamplerBindGroupLayout;

    private static Buffer*          _ProjectionMatrixBuffer;
    private static BindGroupLayout* _ProjectionMatrixBindGroupLayout;
    private static BindGroup*       _ProjectionMatrixBindGroup;

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
                requestAdapterOptions,
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
            requiredLimits->Limits.MaxBindGroups = 2;

            var deviceDescriptor = new DeviceDescriptor
            {
                RequiredLimits = requiredLimits,
                DefaultQueue   = new QueueDescriptor()
            };

            wgpu.AdapterRequestDevice
            (
                _Adapter,
                deviceDescriptor,
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
                Code = (byte*) SilkMarshal.StringToPtr(File.ReadAllText("shader.wgsl")),
                Chain = new ChainedStruct
                {
                    SType = SType.ShaderModuleWgsldescriptor
                }
            };

            var shaderModuleDescriptor = new ShaderModuleDescriptor
            {
                NextInChain = (ChainedStruct*) (&wgslDescriptor)
            };

            _Shader = wgpu.DeviceCreateShaderModule(_Device, shaderModuleDescriptor);

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
            Format         = VertexFormat.Float32x2,
            Offset         = (ulong) sizeof(Vector2),
            ShaderLocation = 1
        };

        var vertexBufferLayout = new VertexBufferLayout
        {
            Attributes     = vertexAttributes,
            AttributeCount = 2,
            StepMode       = VertexStepMode.Vertex,
            ArrayStride    = (ulong) sizeof(Vertex)
        };
        //Create vertex buffer layout

        { //Create texture and texture view
            var image = Image.Load<Rgba32>("silk.png");

            var viewFormat = TextureFormat.Rgba8Unorm;

            var descriptor = new TextureDescriptor
            {
                Size            = new Extent3D((uint) image.Width, (uint) image.Height, 1),
                Format          = TextureFormat.Rgba8Unorm,
                Usage           = TextureUsage.CopyDst | TextureUsage.TextureBinding,
                MipLevelCount   = 1,
                SampleCount     = 1,
                Dimension       = TextureDimension.TextureDimension2D,
                ViewFormats     = &viewFormat,
                ViewFormatCount = 1
            };

            _Texture = wgpu.DeviceCreateTexture(_Device, descriptor);

            var viewDescriptor = new TextureViewDescriptor
            {
                Format          = TextureFormat.Rgba8Unorm,
                Dimension       = TextureViewDimension.TextureViewDimension2D,
                Aspect          = TextureAspect.None,
                MipLevelCount   = 1,
                ArrayLayerCount = 1,
                BaseArrayLayer  = 0,
                BaseMipLevel    = 0
            };

            _TextureView = wgpu.TextureCreateView(_Texture, viewDescriptor);

            var queue = wgpu.DeviceGetQueue(_Device);

            var commandEncoderDescriptor = new CommandEncoderDescriptor();

            var commandEncoder = wgpu.DeviceCreateCommandEncoder(_Device, commandEncoderDescriptor);

            image.ProcessPixelRows
            (
                x =>
                {
                    for (var i = 0; i < x.Height; i++)
                    {
                        var imageRow = x.GetRowSpan(i);

                        var imageCopyTexture = new ImageCopyTexture
                        {
                            Texture  = _Texture,
                            Aspect   = TextureAspect.None,
                            MipLevel = 0,
                            Origin   = new Origin3D(0, (uint) i, 0)
                        };

                        var layout = new TextureDataLayout
                        {
                            BytesPerRow  = (uint) (x.Width * sizeof(Rgba32)),
                            RowsPerImage = (uint) x.Height
                        };
                        // layout.Offset = layout.BytesPerRow * (uint) i;

                        var extent = new Extent3D
                        {
                            Width              = (uint) x.Width,
                            Height             = 1,
                            DepthOrArrayLayers = 1
                        };

                        fixed (void* dataPtr = imageRow)
                            wgpu.QueueWriteTexture(queue, imageCopyTexture, dataPtr, (nuint) (sizeof(Rgba32) * imageRow.Length), layout, extent);
                    }
                }
            );

            var commandBuffer = wgpu.CommandEncoderFinish(commandEncoder, new CommandBufferDescriptor());

            wgpu.QueueSubmit(queue, 1, &commandBuffer);
        } //Create texture and texture view

        { //Create sampler
            var descriptor = new SamplerDescriptor
            {
                Compare      = CompareFunction.Undefined,
                MipmapFilter = MipmapFilterMode.Linear,
                MagFilter    = FilterMode.Linear,
                MinFilter    = FilterMode.Linear
            };

            _Sampler = wgpu.DeviceCreateSampler(_Device, descriptor);
        } //Create sampler

        { //Create bind group for sampler and textureview
            var entries = stackalloc BindGroupLayoutEntry[2];
            entries[0] = new BindGroupLayoutEntry
            {
                Binding = 0,
                Texture = new TextureBindingLayout
                {
                    Multisampled  = false,
                    SampleType    = TextureSampleType.Float,
                    ViewDimension = TextureViewDimension.TextureViewDimension2D
                },
                Visibility = ShaderStage.Fragment
            };
            entries[1] = new BindGroupLayoutEntry
            {
                Binding = 1,
                Sampler = new SamplerBindingLayout
                {
                    Type = SamplerBindingType.Filtering
                },
                Visibility = ShaderStage.Fragment
            };

            var layoutDescriptor = new BindGroupLayoutDescriptor
            {
                Entries    = entries,
                EntryCount = 2
            };

            _TextureSamplerBindGroupLayout = wgpu.DeviceCreateBindGroupLayout(_Device, layoutDescriptor);

            var bindGroupEntries = stackalloc BindGroupEntry[2];
            bindGroupEntries[0] = new BindGroupEntry
            {
                Binding     = 0,
                TextureView = _TextureView
            };
            bindGroupEntries[1] = new BindGroupEntry
            {
                Binding = 1,
                Sampler = _Sampler
            };

            var descriptor = new BindGroupDescriptor
            {
                Entries    = bindGroupEntries,
                EntryCount = 2,
                Layout     = _TextureSamplerBindGroupLayout
            };

            _TextureBindGroup = wgpu.DeviceCreateBindGroup(_Device, descriptor);
        } //Create bind group for sampler and texture view

        { //Create buffer to store projection matrix
            var descriptor = new BufferDescriptor
            {
                Size             = (ulong) sizeof(Matrix4x4),
                Usage            = BufferUsage.Uniform | BufferUsage.CopyDst,
                MappedAtCreation = false
            };

            _ProjectionMatrixBuffer = wgpu.DeviceCreateBuffer(_Device, descriptor);

            UpdateProjectionMatrix();
        } //Create buffer to store projection matrix

        { //Create bind group for projection matrix
            var entry = new BindGroupLayoutEntry
            {
                Binding = 0,
                Buffer = new BufferBindingLayout
                {
                    Type           = BufferBindingType.Uniform,
                    MinBindingSize = (ulong) sizeof(Matrix4x4)
                },
                Visibility = ShaderStage.Vertex,
            };

            var layoutDescriptor = new BindGroupLayoutDescriptor
            {
                Entries    = &entry,
                EntryCount = 1
            };

            _ProjectionMatrixBindGroupLayout = wgpu.DeviceCreateBindGroupLayout(_Device, layoutDescriptor);

            var bindGroupEntry = new BindGroupEntry
            {
                Binding = 0,
                Buffer  = _ProjectionMatrixBuffer
            };

            var descriptor = new BindGroupDescriptor
            {
                Entries    = &bindGroupEntry,
                EntryCount = 1,
                Layout     = _ProjectionMatrixBindGroupLayout
            };

            _ProjectionMatrixBindGroup = wgpu.DeviceCreateBindGroup(_Device, descriptor);
        } //Create bind group for projection matrix

        { //Create pipeline
            var blendState = new BlendState
            {
                Color = new BlendComponent
                {
                    SrcFactor = BlendFactor.SrcAlpha,
                    DstFactor = BlendFactor.OneMinusSrcAlpha,
                    Operation = BlendOperation.None
                },
                Alpha = new BlendComponent
                {
                    SrcFactor = BlendFactor.One,
                    DstFactor = BlendFactor.OneMinusSrcAlpha,
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

            var bindGroupLayouts = stackalloc BindGroupLayout*[2];
            bindGroupLayouts[0] = _TextureSamplerBindGroupLayout;
            bindGroupLayouts[1] = _ProjectionMatrixBindGroupLayout;

            var pipelineLayoutDescriptor = new PipelineLayoutDescriptor
            {
                BindGroupLayoutCount = 2,
                BindGroupLayouts     = bindGroupLayouts
            };

            var pipelineLayout = wgpu.DeviceCreatePipelineLayout(_Device, pipelineLayoutDescriptor);

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
                Layout       = pipelineLayout
            };

            _Pipeline = wgpu.DeviceCreateRenderPipeline(_Device, renderPipelineDescriptor);

            Console.WriteLine($"Created pipeline {(nuint) _Pipeline:X}");
        } //Create pipeline

        { //Create vertex buffer
            var descriptor = new BufferDescriptor
            {
                Size  = _VertexBufferSize = (ulong) (sizeof(Vertex) * 6),
                Usage = BufferUsage.Vertex | BufferUsage.CopyDst
            };

            _VertexBuffer = wgpu.DeviceCreateBuffer(_Device, descriptor);

            //Get a queue
            var queue = wgpu.DeviceGetQueue(_Device);

            var data = stackalloc Vertex[6];

            const float xPos   = 100;
            const float yPos   = 100;
            const float width  = 271;
            const float height = 271;
            
            //Fill data with a quad with a CCW front face
            data[0] = new Vertex(new Vector2(xPos, yPos), new Vector2(0, 0)); //Top left
            data[1] = new Vertex(new Vector2(xPos + width, yPos), new Vector2(1, 0));  //Top right
            data[2] = new Vertex(new Vector2(xPos + width, yPos + height), new Vector2(1, 1));   //Bottom right
            data[3] = new Vertex(new Vector2(xPos, yPos), new Vector2(0, 0)); //Top left
            data[4] = new Vertex(new Vector2(xPos + width, yPos + height), new Vector2(1, 1));   //Bottom right
            data[5] = new Vertex(new Vector2(xPos, yPos + height), new Vector2(0, 1));  //Bottom left

            //Write the data to the buffer
            wgpu.QueueWriteBuffer(queue, _VertexBuffer, 0, data, (nuint) _VertexBufferSize);

            //Create a new command encoder
            var commandEncoder = wgpu.DeviceCreateCommandEncoder(_Device, new CommandEncoderDescriptor());

            //Finish the command encoder
            var commandBuffer = wgpu.CommandEncoderFinish(commandEncoder, new CommandBufferDescriptor());

            wgpu.QueueSubmit(queue, 1, &commandBuffer);
        } //Create vertex buffer

        CreateSwapchain();
    }

    private static void UpdateProjectionMatrix()
    {
        var queue = wgpu.DeviceGetQueue(_Device);

        var commandEncoder = wgpu.DeviceCreateCommandEncoder(_Device, new CommandEncoderDescriptor());

        var projectionMatrix = Matrix4x4.CreateOrthographicOffCenter(0, _Window.Size.X, _Window.Size.Y, 0, 0, 1);

        wgpu.QueueWriteBuffer(queue, _ProjectionMatrixBuffer, 0, &projectionMatrix, (nuint) sizeof(Matrix4x4));

        var commandBuffer = wgpu.CommandEncoderFinish(commandEncoder, new CommandBufferDescriptor());

        wgpu.QueueSubmit(queue, 1, &commandBuffer);
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

        var encoder = wgpu.DeviceCreateCommandEncoder(_Device, new CommandEncoderDescriptor());

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

        var renderPass = wgpu.CommandEncoderBeginRenderPass(encoder, renderPassDescriptor);

        wgpu.RenderPassEncoderSetPipeline(renderPass, _Pipeline);
        wgpu.RenderPassEncoderSetBindGroup(renderPass, 0, _TextureBindGroup, 0, null);
        wgpu.RenderPassEncoderSetBindGroup(renderPass, 1, _ProjectionMatrixBindGroup, 0, null);
        wgpu.RenderPassEncoderSetVertexBuffer(renderPass, 0, _VertexBuffer, 0, _VertexBufferSize);
        wgpu.RenderPassEncoderDraw(renderPass, 6, 1, 0, 0);

        wgpu.RenderPassEncoderEnd(renderPass);
        _WebGpuDisposal.Dispose(nextTexture);

        var queue = wgpu.DeviceGetQueue(_Device);

        var commandBuffer = wgpu.CommandEncoderFinish(encoder, new CommandBufferDescriptor());

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
        UpdateProjectionMatrix();
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

        _SwapChain = wgpu.DeviceCreateSwapChain(_Device, _Surface, swapChainDescriptor);
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
