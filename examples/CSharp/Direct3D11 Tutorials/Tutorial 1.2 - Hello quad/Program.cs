// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


/////////////////////////////////////////////////////// PLEASE READ! ///////////////////////////////////////////////////
// This provides a basic example of using our Direct3D 11 bindings in their current form. These bindings are still    //
// improving over time, and as a result the content of this example may change.                                       //
// Notably:                                                                                                           //
// TODO remove Unsafe.NullRef once we've updated the bindings to not require it                                       //
// TODO investigate making the D3DPrimitiveTopology enum more user friendly                                           //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Text;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D.Compilers;
using Silk.NET.Direct3D11;
using Silk.NET.DXGI;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Windowing;

var backgroundColour = new[]{ 0.0f, 0.0f, 0.0f, 1.0f };

float[] vertices =
{
    //  X      Y      Z
     0.5f,  0.5f,  0.0f,
     0.5f, -0.5f,  0.0f,
    -0.5f, -0.5f,  0.0f,
    -0.5f,  0.5f,  0.5f,
};

uint[] indices =
{
    0, 1, 3,
    1, 2, 3,
};

var vertexStride = 3U * sizeof(float);
var vertexOffset = 0U;

const string shaderSource = @"
struct vs_in {
    float3 position_local : POS;
};

struct vs_out {
    float4 position_clip : SV_POSITION;
};

vs_out vs_main(vs_in input) {
    vs_out output = (vs_out)0;
    output.position_clip = float4(input.position_local, 1.0);
    return output;
}

float4 ps_main(vs_out input) : SV_TARGET {
    return float4( 1.0, 0.5, 0.2, 1.0 );
}
";

// Create a window.
var options = WindowOptions.Default;
options.Size = new Vector2D<int>(800, 600);
options.Title = "Learn Direct3D11 with Silk.NET";
options.API = GraphicsAPI.None; // <-- This bit is important, as your window will be configured for OpenGL by default.
var window = Window.Create(options);

// Load the DXGI and Direct3D11 libraries for later use.
// Given this is not tied to the window, this doesn't need to be done in the OnLoad event.
DXGI dxgi = null!;
D3D11 d3d11 = null!;
D3DCompiler compiler = null!;

// These variables are initialized within the Load event.
ComPtr<IDXGIFactory2> factory = default;
ComPtr<IDXGISwapChain1> swapchain = default;
ComPtr<ID3D11Device> device = default;
ComPtr<ID3D11DeviceContext> deviceContext = default;
ComPtr<ID3D11Buffer> vertexBuffer = default;
ComPtr<ID3D11Buffer> indexBuffer = default;
ComPtr<ID3D11VertexShader> vertexShader = default;
ComPtr<ID3D11PixelShader> pixelShader = default;
ComPtr<ID3D11InputLayout> inputLayout = default;

// Assign events.
window.Load += OnLoad;
window.Update += OnUpdate;
window.Render += OnRender;
window.FramebufferResize += OnFramebufferResize;

// Run the window.
window.Run();

// Clean up any resources.
factory.Dispose();
swapchain.Dispose();
device.Dispose();
deviceContext.Dispose();
vertexBuffer.Dispose();
indexBuffer.Dispose();
vertexShader.Dispose();
pixelShader.Dispose();
inputLayout.Dispose();
compiler.Dispose();
d3d11.Dispose();
dxgi.Dispose();

//dispose the window, and its internal resources
window.Dispose();

unsafe void OnLoad()
{
    //Whether or not to force use of DXVK on platforms where native DirectX implementations are available
    const bool forceDxvk = false;

    dxgi = DXGI.GetApi(window, forceDxvk);
    d3d11 = D3D11.GetApi(window, forceDxvk);
    compiler = D3DCompiler.GetApi();
    
    // Set-up input context.
    var input = window.CreateInput();
    foreach (var keyboard in input.Keyboards)
    {
        keyboard.KeyDown += OnKeyDown;
    }
    
    // Create our D3D11 logical device.
    SilkMarshal.ThrowHResult
    (
        d3d11.CreateDevice
        (
            default(ComPtr<IDXGIAdapter>),
            D3DDriverType.Hardware,
            Software: default,
            (uint) CreateDeviceFlag.Debug,
            null,
            0,
            D3D11.SdkVersion,
            ref device,
            null,
            ref deviceContext
        )
    );
    
    //This is not supported under DXVK 
    //TODO: PR a stub into DXVK for this maybe?
    if (OperatingSystem.IsWindows())
    {
        // Log debug messages for this device (given that we've enabled the debug flag). Don't do this in release code!
        device.SetInfoQueueCallback(msg => Console.WriteLine(SilkMarshal.PtrToString((nint) msg.PDescription)));
    }

    // Create our swapchain.
    var swapChainDesc = new SwapChainDesc1
    {
        BufferCount = 2, // double buffered
        Format = Format.FormatB8G8R8A8Unorm,
        BufferUsage = DXGI.UsageRenderTargetOutput,
        SwapEffect = SwapEffect.FlipDiscard,
        SampleDesc = new SampleDesc(1, 0)
    };
    
    // Create our DXGI factory to allow us to create a swapchain. 
    factory = dxgi.CreateDXGIFactory<IDXGIFactory2>();
    
    // Create the swapchain.
    SilkMarshal.ThrowHResult
    (
        factory.CreateSwapChainForHwnd
        (
            device,
            window.Native!.DXHandle!.Value,
            in swapChainDesc,
            null,
            ref Unsafe.NullRef<IDXGIOutput>(),
            ref swapchain
        )
    );
    
    // Create our vertex buffer.
    var bufferDesc = new BufferDesc
    {
        ByteWidth = (uint) (vertices.Length * sizeof(float)),
        Usage = Usage.Default,
        BindFlags = (uint) BindFlag.VertexBuffer
    };

    fixed (float* vertexData = vertices)
    {
        var subresourceData = new SubresourceData
        {
            PSysMem = vertexData
        };

        SilkMarshal.ThrowHResult(device.CreateBuffer(in bufferDesc, in subresourceData, ref vertexBuffer));
    }
    
    // Create our index buffer.
    bufferDesc = new BufferDesc
    {
        ByteWidth = (uint) (indices.Length * sizeof(uint)),
        Usage = Usage.Default,
        BindFlags = (uint) BindFlag.IndexBuffer
    };

    fixed (uint* indexData = indices)
    {
        var subresourceData = new SubresourceData
        {
            PSysMem = indexData
        };

        SilkMarshal.ThrowHResult(device.CreateBuffer(in bufferDesc, in subresourceData, ref indexBuffer));
    }

    var shaderBytes = Encoding.ASCII.GetBytes(shaderSource);

    // Compile vertex shader.
    ComPtr<ID3D10Blob> vertexCode = default;
    ComPtr<ID3D10Blob> vertexErrors = default;
    HResult hr = compiler.Compile
    (
        in shaderBytes[0],
        (nuint) shaderBytes.Length,
        nameof(shaderSource),
        null,
        ref Unsafe.NullRef<ID3DInclude>(),
        "vs_main",
        "vs_5_0",
        0,
        0,
        ref vertexCode,
        ref vertexErrors
    );

    // Check for compilation errors.
    if (hr.IsFailure)
    {
        if (vertexErrors.Handle is not null)
        {
            Console.WriteLine(SilkMarshal.PtrToString((nint) vertexErrors.GetBufferPointer()));
        }

        hr.Throw();
    }
    
    // Compile pixel shader.
    ComPtr<ID3D10Blob> pixelCode = default;
    ComPtr<ID3D10Blob> pixelErrors = default;
    hr = compiler.Compile
    (
        in shaderBytes[0],
        (nuint)shaderBytes.Length,
        nameof(shaderSource),
        null,
        ref Unsafe.NullRef<ID3DInclude>(),
        "ps_main",
        "ps_5_0",
        0,
        0,
        ref pixelCode,
        ref pixelErrors
    ); 

    // Check for compilation errors.
    if (hr.IsFailure)
    {
        if (pixelErrors.Handle is not null)
        {
            Console.WriteLine(SilkMarshal.PtrToString((nint) pixelErrors.GetBufferPointer()));
        }

        hr.Throw();
    }
    
    // Create vertex shader.
    SilkMarshal.ThrowHResult
    (
        device.CreateVertexShader
        (
            vertexCode.GetBufferPointer(),
            vertexCode.GetBufferSize(),
            ref Unsafe.NullRef<ID3D11ClassLinkage>(),
            ref vertexShader
        )
    );
    
    // Create pixel shader.
    SilkMarshal.ThrowHResult
    (
        device.CreatePixelShader
        (
            pixelCode.GetBufferPointer(),
            pixelCode.GetBufferSize(),
            ref Unsafe.NullRef<ID3D11ClassLinkage>(),
            ref pixelShader
        )
    );
    
    // Describe the layout of the input data for the shader.
    fixed (byte* name = SilkMarshal.StringToMemory("POS"))
    {
        var inputElement = new InputElementDesc
        {
            SemanticName = name,
            SemanticIndex = 0,
            Format = Format.FormatR32G32B32Float,
            InputSlot = 0,
            AlignedByteOffset = 0,
            InputSlotClass = InputClassification.PerVertexData,
            InstanceDataStepRate = 0
        };

        SilkMarshal.ThrowHResult
        (
            device.CreateInputLayout
            (
                in inputElement,
                1,
                vertexCode.GetBufferPointer(),
                vertexCode.GetBufferSize(),
                ref inputLayout
            )
        );
    }

    // Clean up any resources.
    vertexCode.Dispose();
    vertexErrors.Dispose();
    pixelCode.Dispose();
    pixelErrors.Dispose();
}

void OnUpdate(double deltaSeconds)
{
    // Here all of the updates to program state ahead of rendering (e.g. physics) should be done. We don't have anything
    // to do here at the moment, so we've left it blank.
}

unsafe void OnFramebufferResize(Vector2D<int> newSize)
{
    // If the window resizes, we need to be sure to update the swapchain's back buffers.
    SilkMarshal.ThrowHResult
    (
        swapchain.ResizeBuffers(0, (uint) newSize.X, (uint) newSize.Y, Format.FormatB8G8R8A8Unorm, 0)
    );
}

unsafe void OnRender(double deltaSeconds)
{
    // Obtain the framebuffer for the swapchain's backbuffer.
    using var framebuffer = swapchain.GetBuffer<ID3D11Texture2D>(0);
    
    // Create a view over the render target.
    ComPtr<ID3D11RenderTargetView> renderTargetView = default;
    SilkMarshal.ThrowHResult(device.CreateRenderTargetView(framebuffer, null, ref renderTargetView));
    
    // Clear the render target to be all black ahead of rendering.
    deviceContext.ClearRenderTargetView(renderTargetView, ref backgroundColour[0]);
    
    // Update the rasterizer state with the current viewport.
    var viewport = new Viewport(0, 0, window.FramebufferSize.X, window.FramebufferSize.Y, 0, 1);
    deviceContext.RSSetViewports(1, in viewport);
    
    // Tell the output merger about our render target view.
    deviceContext.OMSetRenderTargets(1, ref renderTargetView, ref Unsafe.NullRef<ID3D11DepthStencilView>());
    
    // Update the input assembler to use our shader input layout, and associated vertex & index buffers.
    deviceContext.IASetPrimitiveTopology(D3DPrimitiveTopology.D3DPrimitiveTopologyTrianglelist);
    deviceContext.IASetInputLayout(inputLayout);
    deviceContext.IASetVertexBuffers(0, 1, vertexBuffer, in vertexStride, in vertexOffset);
    deviceContext.IASetIndexBuffer(indexBuffer, Format.FormatR32Uint, 0);
    
    // Bind our shaders.
    deviceContext.VSSetShader(vertexShader, ref Unsafe.NullRef<ComPtr<ID3D11ClassInstance>>(), 0);
    deviceContext.PSSetShader(pixelShader, ref Unsafe.NullRef<ComPtr<ID3D11ClassInstance>>(), 0);
    
    // Draw the quad.
    deviceContext.DrawIndexed(6, 0, 0);
    
    // Present the drawn image.
    swapchain.Present(1, 0);
    
    // Clean up any resources created in this method.
    renderTargetView.Dispose();
}

void OnKeyDown(IKeyboard keyboard, Key key, int scancode)
{
    // Check to close the window on escape.
    if (key == Key.Escape)
    {
        window.Close();
    }
}
