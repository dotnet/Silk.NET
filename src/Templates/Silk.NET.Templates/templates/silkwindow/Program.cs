using Silk.NET.Windowing;

WindowOptions windowOptions = WindowOptions.Default with
{
    Title = "My Silk.NET Window",
    PreferredDepthBufferBits = 24,
    PreferredStencilBufferBits = 8,
    API = new GraphicsAPI(ContextAPI.OpenGL, new APIVersion(3, 3))
};

using IWindow window = Window.Create(windowOptions);

window.Load += () =>
{
    // ran on first startup - use this event to initialize stuff.
};

window.Update += deltaSeconds => 
{
    // ran every frame but before render - use this event to update data (e.g. physics).
};

window.Render += deltaSeconds =>
{
    // ran every frame but after update - use this event to draw.
};

window.FramebufferResize += newSize =>
{
    // ran when the window framebuffer is resized - usually used to update the viewport and, in 3D apps, view matrices.
};

window.Closing += () =>
{
    // ran just before the window closes.
};

window.Run();
