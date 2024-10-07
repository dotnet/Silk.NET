using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGL;

public partial class GL
{
    public const ulong TimeoutIgnored = 0xFFFFFFFFFFFFFFFFUL;
    public const ulong TimeoutIgnoredApple = TimeoutIgnored;

    private INativeContext Context => nativeContext;

    public partial class ThisThread
    {
        public static partial void MakeCurrent(IGL ctx)
        {
            if (ctx is GL { Context: IGLContext glContext })
            {
                glContext.IsCurrent = true;
            }

            Underlying.Value = ctx;
        }
    }
}
