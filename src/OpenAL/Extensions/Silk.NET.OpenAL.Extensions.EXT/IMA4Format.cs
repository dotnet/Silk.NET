// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Extensions;

namespace Silk.NET.OpenAL.Native.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_IMA4")]
    [NativeApi(Prefix = "al")]
    public partial class IMA4Format : FormatExtensionBase<IMA4BufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected IMA4Format(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}