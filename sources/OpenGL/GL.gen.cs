using System.Runtime.CompilerServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenGL;

partial class GL(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly)
    }

    public partial class ThisThread : IGL.Static<ThisThread>
    {
        public static ThreadLocal<IGL> Underlying { get; } =
            new(static () => new StaticWrapper<DllImport>());

        public static void MakeCurrent(IGL ctx) => Underlying.Value = ctx;
    }

    public static IGL Create() => new StaticWrapper<DllImport>();

    public static IGL Create(INativeContext ctx) => new GL(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
