//
// IMA4Format.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using Silk.NET.Core.Attributes;
using Silk.NET.OpenAL.Extensions;

namespace Silk.NET.OpenAL.Native.Extensions.EXT.IMA4Format
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_IMA4")]
    public abstract class IMA4Format : FormatExtensionBase<IMA4BufferFormat>, IIMA4Format
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected IMA4Format(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
