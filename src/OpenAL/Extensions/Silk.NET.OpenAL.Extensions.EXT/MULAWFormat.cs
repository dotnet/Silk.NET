// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;
using Silk.NET.Core.Attributes;

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MULAW")]
    public abstract class MULAWFormat : FormatExtensionBase<MULAWBufferFormat>, IMULAWFormat
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected MULAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}