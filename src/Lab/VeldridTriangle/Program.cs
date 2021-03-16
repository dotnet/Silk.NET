// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using Veldrid;
using Veldrid.SPIRV;
using System.Text;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Extensions.Veldrid;

namespace VeldridTriangle
{
    class Program
    {
        private static GraphicsDevice _graphicsDevice;
        private static CommandList _commandList;
        private static DeviceBuffer _vertexBuffer;
        private static DeviceBuffer _indexBuffer;
        private static Shader[] _shaders;
        private static Pipeline _pipeline;

        private const string VertexCode = @"
#version 450

layout(location = 0) in vec2 Position;
layout(location = 1) in vec4 Color;

layout(location = 0) out vec4 fsin_Color;

void main()
{
    gl_Position = vec4(Position, 0, 1);
    fsin_Color = Color;
}";

        private const string FragmentCode = @"
#version 450

layout(location = 0) in vec4 fsin_Color;
layout(location = 0) out vec4 fsout_Color;

void main()
{
    fsout_Color = fsin_Color;
}";

        static void Main(string[] args)
        {
            const GraphicsBackend preferredBackend = GraphicsBackend.Vulkan;
            var opts = WindowOptions.Default;
            opts.Position = new(100, 100);
            opts.Size = new(960, 540);
            opts.Title = "Veldrid Tutorial";
            opts.API = preferredBackend.ToGraphicsAPI();
            opts.VSync = false;
            opts.ShouldSwapAutomatically = false;
            var window = Window.Create(opts);
            window.Load += () =>
            {
                _graphicsDevice = window.CreateGraphicsDevice
                (
                    new()
                    {
                        PreferStandardClipSpaceYDirection = true,
                        PreferDepthRangeZeroToOne = true
                    }, preferredBackend
                );
                CreateResources();
            };

            window.Render += _ => Draw();
            window.Closing += DisposeResources;
            window.Resize += size => _graphicsDevice.ResizeMainWindow((uint) size.X, (uint) size.Y);
            window.Run();
        }

        private static void CreateResources()
        {
            var factory = _graphicsDevice.ResourceFactory;

            VertexPositionColor[] quadVertices =
            {
                new(new(0, .5f), RgbaFloat.Red),
                new(new(.5f, -.5f), RgbaFloat.Green),
                new(new(-.5f, -.5f), RgbaFloat.Blue)
            };
            var vbDescription = new BufferDescription
            (
                3 * VertexPositionColor.SizeInBytes,
                BufferUsage.VertexBuffer
            );
            _vertexBuffer = factory.CreateBuffer(vbDescription);
            _graphicsDevice.UpdateBuffer(_vertexBuffer, 0, quadVertices);

            ushort[] quadIndices = {0, 1, 2};
            var ibDescription = new BufferDescription
            (
                3 * sizeof(ushort),
                BufferUsage.IndexBuffer
            );
            _indexBuffer = factory.CreateBuffer(ibDescription);
            _graphicsDevice.UpdateBuffer(_indexBuffer, 0, quadIndices);

            var vertexLayout = new VertexLayoutDescription
            (
                new VertexElementDescription
                    ("Position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float2),
                new VertexElementDescription
                    ("Color", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float4)
            );

            var vertexShaderDesc = new ShaderDescription
            (
                ShaderStages.Vertex,
                Encoding.UTF8.GetBytes(VertexCode),
                "main"
            );
            var fragmentShaderDesc = new ShaderDescription
            (
                ShaderStages.Fragment,
                Encoding.UTF8.GetBytes(FragmentCode),
                "main"
            );

            _shaders = factory.CreateFromSpirv(vertexShaderDesc, fragmentShaderDesc);

            // Create pipeline
            var pipelineDescription = new GraphicsPipelineDescription
            {
                BlendState = BlendStateDescription.SingleOverrideBlend,
                DepthStencilState = new
                (
                    true,
                    true,
                    ComparisonKind.LessEqual
                ),
                RasterizerState = new
                (
                    FaceCullMode.Back,
                    PolygonFillMode.Solid,
                    FrontFace.Clockwise,
                    true,
                    false
                ),
                PrimitiveTopology = PrimitiveTopology.TriangleStrip,
                ResourceLayouts = System.Array.Empty<ResourceLayout>(),
                ShaderSet = new
                (
                    new[] {vertexLayout},
                    _shaders
                ),
                Outputs = _graphicsDevice.SwapchainFramebuffer.OutputDescription
            };

            _pipeline = factory.CreateGraphicsPipeline(pipelineDescription);

            _commandList = factory.CreateCommandList();
        }

        private static void Draw()
        {
            // Begin() must be called before commands can be issued.
            _commandList.Begin();

            // We want to render directly to the output window.
            _commandList.SetFramebuffer(_graphicsDevice.SwapchainFramebuffer);
            _commandList.ClearColorTarget(0, RgbaFloat.Black);

            // Set all relevant state to draw our quad.
            _commandList.SetVertexBuffer(0, _vertexBuffer);
            _commandList.SetIndexBuffer(_indexBuffer, IndexFormat.UInt16);
            _commandList.SetPipeline(_pipeline);
            // Issue a Draw command for a single instance with 4 indices.
            _commandList.DrawIndexed(3, 1, 0, 0, 0);

            // End() must be called before commands can be submitted for execution.
            _commandList.End();
            _graphicsDevice.SubmitCommands(_commandList);

            // Once commands have been submitted, the rendered image can be presented to the application window.
            _graphicsDevice.SwapBuffers();
        }

        private static void DisposeResources()
        {
            _pipeline.Dispose();
            foreach (var shader in _shaders)
            {
                shader.Dispose();
            }

            _commandList.Dispose();
            _vertexBuffer.Dispose();
            _indexBuffer.Dispose();
            _graphicsDevice.Dispose();
        }
    }

    struct VertexPositionColor
    {
        public const uint SizeInBytes = 24;
        public Vector2 Position;
        public RgbaFloat Color;

        public VertexPositionColor(Vector2 position, RgbaFloat color)
        {
            Position = position;
            Color = color;
        }
    }
}
