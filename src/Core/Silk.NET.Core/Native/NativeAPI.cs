// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;
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
        /// The source paths for this library.
        /// </summary>
        public abstract SearchPathContainer SearchPaths { get; }
        
        /// <summary>
        /// Whether or not an extension is present. This function might not be valid for some APIs.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>Whether or not the extension exists.</returns>
        public abstract bool IsExtensionPresent(string name);

        protected TExt InstantiateExtension<TExt, TBase>() where TExt : NativeExtension<TBase> where TBase : NativeAPI
            => (TExt)Activator.CreateInstance(typeof(TExt), Context);
    }
}
