// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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

        /// <summary>
        /// The base SuperInvoke library.
        /// </summary>
        public UnmanagedLibrary Library { get; }

        /// <summary>
        /// The source paths for this library.
        /// </summary>
        public abstract SearchPathContainer SearchPaths { get; }

        /// <summary>
        /// Whether or not an extension is present. This function might not be valid for some APIs.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>Whether or not the extension exists.</returns>
        public abstract bool IsExtensionPresent(string name);
    }
}
