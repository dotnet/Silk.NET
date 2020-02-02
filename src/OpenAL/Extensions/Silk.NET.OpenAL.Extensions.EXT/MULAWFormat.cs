// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;
namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MULAW")]
    [NativeApi(Prefix = "al")]
    public abstract class MULAWFormat : FormatExtensionBase<MULAWBufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected MULAWFormat(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}