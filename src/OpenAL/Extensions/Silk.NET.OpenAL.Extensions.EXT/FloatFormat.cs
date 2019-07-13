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
    [Extension("AL_EXT_float")]
    public abstract class FloatFormat : FormatExtensionBase<FloatBufferFormat>, IFloatFormat
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected FloatFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}