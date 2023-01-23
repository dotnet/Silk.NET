// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    /// <inheritdoc />
    public abstract class NativeAPI : NativeApiContainer
    {
        /// <summary>
        /// The <see cref="INativeContext"/> this instance was created with.
        /// </summary>
        public INativeContext Context { get; }

        /// <inheritdoc />
        public NativeAPI(INativeContext ctx)
            : base(ctx)
        {
            Context = ctx;
        }

        /// <summary>
        /// Whether or not an extension is present. This function might not be valid for some APIs.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>Whether or not the extension exists.</returns>
        public abstract bool IsExtensionPresent(string name);
    }
}
