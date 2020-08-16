// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
