using AdvancedDLSupport;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Native
{
    /// <inheritdoc />
    public abstract class NativeAPI : NativeLibraryBase
    {
        /// <inheritdoc />
        protected NativeAPI(string path, ImplementationOptions options) : base(path, options)
        {
        }
        
        public abstract SearchPathContainer SearchPaths { get; }

        public abstract bool IsExtensionPresent(string name);
    }
}
