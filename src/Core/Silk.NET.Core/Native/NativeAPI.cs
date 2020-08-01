// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;
using Silk.NET.Core.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Core.Native
{
    /// <inheritdoc />
    public abstract class NativeAPI : NativeApiContainer
    {
        /// <inheritdoc />
        protected NativeAPI(INativeContext ctx)
            : base(ctx)
        {
        }
        
        /// <summary>
        /// Whether or not an extension is present. This function might not be valid for some APIs.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>Whether or not the extension exists.</returns>
        public abstract bool IsExtensionPresent(string name);
    }
}
