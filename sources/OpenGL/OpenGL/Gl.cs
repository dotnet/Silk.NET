using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGL;

public partial class Gl
{
    public const ulong TimeoutIgnored = 0xFFFFFFFFFFFFFFFFUL;
    public const ulong TimeoutIgnoredApple = TimeoutIgnored;

    private INativeContext Context => nativeContext;

    public partial class ThisThread
    {
        public static partial void MakeCurrent(IGl ctx)
        {
            if (ctx is Gl { Context: IGlContext glContext })
            {
                glContext.IsCurrent = true;
            }

            Underlying.Value = ctx;
        }
    }
}
