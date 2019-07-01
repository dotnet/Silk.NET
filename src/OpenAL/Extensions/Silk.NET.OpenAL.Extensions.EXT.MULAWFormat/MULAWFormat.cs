//
// MULAWFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.MULAWFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MULAW")]
    public abstract class MULAWFormat : FormatExtensionBase<MULAWBufferFormat>, IMULAWFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MULAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
