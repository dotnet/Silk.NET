using Silk.NET.Windowing;
using Silk.NET.OpenGL;

WindowOptions windowOptions = WindowOptions.Default with {
    Title = "My Silk.NET Window"
};

using IWindow window = Window.Create(windowOptions);
GL gl = null!;

window.Load += () =>
{
    // ran on first startup - use this event to initialize stuff.
    gl = window.CreateOpenGL();
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
    gl.Viewport(newSize);
};

window.Closing += () =>
{
    // ran just before the window closes.
};

window.Run();
gl.Dispose();