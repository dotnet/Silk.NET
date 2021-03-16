// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public abstract class NativeExtension<T> : NativeApiContainer where T : NativeAPI
    {
        /// <inheritdoc />
        protected NativeExtension
        (
            INativeContext ctx
        )
            : base(ctx)
        {
        }
    }
}
