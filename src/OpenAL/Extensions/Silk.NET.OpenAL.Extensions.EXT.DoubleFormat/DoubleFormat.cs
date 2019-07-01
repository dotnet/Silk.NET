//
// DoubleFormat.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.EXT.DoubleFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_double")]
    public abstract class DoubleFormat : FormatExtensionBase<DoubleBufferFormat>, IDoubleFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected DoubleFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
