// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;
using AdvancedDLSupport.Loaders;

namespace Silk.NET.Core.Native
{
    public abstract class NativeExtension<T> : NativeLibraryBase where T : NativeAPI
    {
        /// <inheritdoc />
        protected NativeExtension
        (
            string path,
            ImplementationOptions options,
            ILibraryLoader libLoader = null,
            ISymbolLoader symLoader = null
        )
            : base(path, options, libLoader, symLoader)
        {
        }
    }
}