// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
