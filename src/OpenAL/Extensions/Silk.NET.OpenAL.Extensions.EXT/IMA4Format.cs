// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Attributes;
using Silk.NET.OpenAL.Extensions;
using Ultz.SuperInvoke;
namespace Silk.NET.OpenAL.Native.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_IMA4")]
    [NativeApi(Prefix = "al")]
    public abstract class IMA4Format : FormatExtensionBase<IMA4BufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected IMA4Format(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}