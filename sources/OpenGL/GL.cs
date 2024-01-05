using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGL;

public partial class GL
{
    private INativeContext Context => nativeContext;

    public partial class ThisThread
    {
        public static partial void MakeCurrent(IGL ctx)
        {
            if (ctx is GL { Context: IGLContext glContext })
            {
                glContext.MakeCurrent();
            }

            Underlying.Value = ctx;
        }
    }
}
