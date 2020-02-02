// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;
namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_EFX")]
    [NativeApi(Prefix = "al")]
    public abstract class MultiChannelBuffers : FormatExtensionBase<MultiChannelBufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected MultiChannelBuffers(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}