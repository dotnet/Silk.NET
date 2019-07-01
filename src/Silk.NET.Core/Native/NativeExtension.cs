using AdvancedDLSupport;

namespace Silk.NET.Core.Native
{
    public abstract class NativeExtension : NativeLibraryBase
    {
        protected NativeExtension(string path, ImplementationOptions options) : base(path, options)
        {
        }
    }
}
