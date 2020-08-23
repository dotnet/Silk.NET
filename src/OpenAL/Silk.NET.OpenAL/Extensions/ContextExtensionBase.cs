// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions
{
    /// <summary>
    /// Base class for OpenAL context extensions.
    /// </summary>
    public abstract class ContextExtensionBase : NativeExtension<ALContext>
    {
        /// <inheritdoc cref="NativeLibraryBase" />
        protected ContextExtensionBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}