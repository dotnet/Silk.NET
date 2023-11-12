using System.Runtime.CompilerServices;
using Silk.NET.Core.Loader;
using System.Reflection;

namespace Silk.NET.OpenGL;

partial class GL(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : IGL.Static<ThisThread>
    {
        public static ThreadLocal<IGL> Underlying { get; } = new();

        public static void MakeCurrent(IGL ctx) => Underlying.Value = ctx;
    }

    public static IGL Create(INativeContext ctx) => new GL(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
