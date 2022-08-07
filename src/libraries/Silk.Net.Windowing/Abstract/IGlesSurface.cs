namespace Silk.NET.Windowing
{
    public interface IGlesSurface : INativeGLSurface
    {
        IGlesSurface? SharedContext { get; set; }
        /// <summary>
        /// Enables OpenGLES support for this surface. This will create a surface upon initialization.
        /// </summary>
        bool TryEnableOpenGLES();
    }
}