using AdvancedDLSupport;

namespace Silk.NET.Core.Native
{
    public abstract class NativeExtension<T> : NativeLibraryBase where T:NativeAPI
    {
        protected NativeExtension(string path, ImplementationOptions options) : base(path, options)
        {
        }
    }
}
