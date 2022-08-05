namespace Silk.NET.Windowing
{
    public interface IGLSurface : INativeGLSurface
    {
        ContextFlags ContextFlags { get; set; }
        ContextProfile ContextProfile { get; set; }
        IGLSurface? SharedContext { get; set; }

        /// <summary>
        /// Enables OpenGL support for this surface. This will create a surface upon initialization.
        /// </summary>
        bool TryEnableOpenGL()
        {
            throw new NotImplementedException();
        }
    }
}