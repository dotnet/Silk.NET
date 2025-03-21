// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/////////////////////////////////////////////////////// PLEASE READ! ///////////////////////////////////////////////////
// This provides a basic example of using our Direct3D 11 bindings in their current form. These bindings are still    //
// improving over time, and as a result the content of this example may change.                                       //
// Notably:                                                                                                           //
// TODO remove Unsafe.NullRef once we've updated the bindings to not require it                                       //
// TODO investigate making the D3DPrimitiveTopology enum more user friendly                                           //
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Runtime.CompilerServices;
using ImGuiNET;
using Silk.NET.Core.Native;
using Silk.NET.Direct3D11;
using Silk.NET.DXGI;
using Silk.NET.Input;
using Silk.NET.Lab.Experiments.ImGuiDX11;
using Silk.NET.Maths;
using Silk.NET.Windowing;

float[] backgroundColour = [0.0f, 0.0f, 0.0f, 1.0f];

// Load the DXGI and Direct3D11 libraries for later use.
// Given this is not tied to the window, this doesn't need to be done in the OnLoad event.
DXGI dxgi = null!;
D3D11 d3d11 = null!;

// These variables are initialized within the Load event.
ComPtr<IDXGIFactory2> factory = default;
ComPtr<IDXGISwapChain1> swapchain = default;
ComPtr<ID3D11Device> device = default;
ComPtr<ID3D11DeviceContext> deviceContext = default;

ImGuiDX11Controller controller = null;

// Create a window.
WindowOptions options = WindowOptions.Default with
{
    Size = new Vector2D<int>(800, 600),
    Title = "Learn Direct3D11 with Silk.NET",
    API = GraphicsAPI.None, // <-- This bit is important, as your window will be configured for OpenGL by default.
};
var window = Window.Create(options);

// Assign events.
window.Load += OnLoad;
window.Render += OnRender;
window.FramebufferResize += OnFramebufferResize;

// Run the window.
window.Run();

// Dispose of the ImGui context.
controller?.Dispose();

// Clean up any resources.
factory.Dispose();
swapchain.Dispose();
device.Dispose();
deviceContext.Dispose();
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
    
    // Init ImGui.
    // This is where you can set a custom font for ImGui.
    //ImGuiFontConfig fontConfig = new ImGuiFontConfig("C:\\Windows\\Fonts\\arial.ttf", 16, ptr => ptr.Fonts.GetGlyphRangesDefault());
    controller = new ImGuiDX11Controller(device, deviceContext, window, input/*, fontConfig*/);
}

void OnFramebufferResize(Vector2D<int> newSize)
{
    // If the window resizes, we need to be sure to update the swapchain's back buffers.
    // Good starting point for this function:
    // https://learn.microsoft.com/en-us/windows/win32/direct3ddxgi/d3d10-graphics-programming-guide-dxgi#handling-window-resizing
    SilkMarshal.ThrowHResult
    (
        swapchain.ResizeBuffers(0, (uint) newSize.X, (uint) newSize.Y, Format.FormatB8G8R8A8Unorm, 0)
    );
}

unsafe void OnRender(double deltaSeconds)
{
    // Update the ImGui controller.
    controller.Update((float)deltaSeconds);
    
    // Obtain the framebuffer for the swapchain's backbuffer.
    using ComPtr<ID3D11Texture2D> framebuffer = swapchain.GetBuffer<ID3D11Texture2D>(0);
    
    // Create a view over the render target.
    ComPtr<ID3D11RenderTargetView> renderTargetView = default;
    SilkMarshal.ThrowHResult(device.CreateRenderTargetView(framebuffer, null, ref renderTargetView));
    
    // Clear the render target to be all black ahead of rendering.
    deviceContext.ClearRenderTargetView(renderTargetView, ref backgroundColour[0]);
    
    // Update the rasterizer state with the current viewport.
    Viewport viewport = new Viewport(0, 0, window.FramebufferSize.X, window.FramebufferSize.Y, 0, 1);
    deviceContext.RSSetViewports(1, in viewport);
    
    // Tell the output merger about our render target view.
    deviceContext.OMSetRenderTargets(1, ref renderTargetView, ref Unsafe.NullRef<ID3D11DepthStencilView>());
    
    // Show everything you want before calling ImGui.Render().
    ImGui.ShowDemoWindow();
    
    // Then render ImGui.
    controller.Render();
    
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
