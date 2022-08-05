
namespace Silk.NET.Windowing
{
    public interface IGLTransparentFramebuffer : INativeGLSurface
    {
        bool TransparentFramebuffer { get; set; }
    }
}