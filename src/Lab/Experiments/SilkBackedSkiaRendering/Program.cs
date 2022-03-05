using Silk.NET.Maths;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;
using SkiaSharp;

var options = WindowOptions.Default;
options.Size = new Vector2D<int>(800, 600);
options.Title = "Silk.NET backed Skia rendering!";
options.PreferredStencilBufferBits = 8;
options.PreferredBitDepth = new Vector4D<int>(8, 8, 8, 8);
GlfwWindowing.Use();
var window = Window.Create(options);
window.Initialize();
using var grGlInterface = GRGlInterface.Create((name => window.GLContext!.TryGetProcAddress(name, out var addr) ? addr : (IntPtr) 0));
grGlInterface.Validate();
using var grContext = GRContext.CreateGl(grGlInterface);
var renderTarget = new GRBackendRenderTarget(800, 600, 0, 8, new GRGlFramebufferInfo(0, 0x8058)); // 0x8058 = GL_RGBA8`
using var surface = SKSurface.Create(grContext, renderTarget, GRSurfaceOrigin.BottomLeft, SKColorType.Rgba8888);
using var canvas = surface.Canvas;

window.Render += d =>
{
    grContext.ResetContext();
    canvas.Clear(SKColors.Cyan);
    using var red = new SKPaint();
    red.Color = new SKColor(255, 0, 0, 255);
    canvas.DrawCircle(150, 150, 100, red);
    canvas.Flush();
};

window.Run();

