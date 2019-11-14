// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Interfaces;

namespace Silk.NET.OpenAL.Extensions
{
    /// <summary>
    /// Base class for OpenAL context extensions.
    /// </summary>
    public abstract class ContextExtensionBase : NativeExtension<ALContext>
    {
        /// <inheritdoc cref="NativeLibraryBase" />
        protected ContextExtensionBase(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}