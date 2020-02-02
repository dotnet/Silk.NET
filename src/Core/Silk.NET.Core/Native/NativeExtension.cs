// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Ultz.SuperInvoke;
namespace Silk.NET.Core.Native
{
    public abstract class NativeExtension<T> : NativeApiContainer where T : NativeAPI
    {
        /// <inheritdoc />
        protected NativeExtension
        (
            ref NativeApiContext ctx
        )
            : base(ref ctx)
        {
        }
    }
}