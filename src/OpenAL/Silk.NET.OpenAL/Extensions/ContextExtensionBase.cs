// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
        public ContextExtensionBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}