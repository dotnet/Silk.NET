// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Loader;
using Ultz.SuperInvoke;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.Core.Native
{
    /// <inheritdoc />
    public abstract class NativeAPI : NativeApiContainer
    {
        /// <inheritdoc />
        protected NativeAPI(ref NativeApiContext ctx)
        : base(ref ctx)
        {
            Library = ctx.Library;
        }
        
        public UnmanagedLibrary Library { get; }

        public abstract SearchPathContainer SearchPaths { get; }

        public abstract bool IsExtensionPresent(string name);
    }
}
