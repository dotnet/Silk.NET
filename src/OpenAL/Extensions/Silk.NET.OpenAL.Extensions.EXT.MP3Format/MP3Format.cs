//
// MP3Format.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.MP3Format
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MP3")]
    public abstract class MP3Format : FormatExtensionBase<MP3BufferFormat>, IMP3Format
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MP3Format(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
