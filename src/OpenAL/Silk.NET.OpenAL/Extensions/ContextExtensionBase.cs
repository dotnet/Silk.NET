//
// ContextExtensionBase.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using Silk.NET.OpenAL.Interfaces;

namespace Silk.NET.OpenAL.Extensions
{
    /// <summary>
    /// Base class for OpenAL context extensions.
    /// </summary>
    public abstract class ContextExtensionBase : NativeLibraryBase, IContextExtensions
    {
        /// <inheritdoc cref="NativeLibraryBase"/>
        protected ContextExtensionBase(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe bool IsExtensionPresent(Device* device, [CallerFree] string name);

        /// <inheritdoc />
        public abstract unsafe void* GetProcAddress(Device* device, [CallerFree] string name);

        /// <inheritdoc />
        public abstract unsafe int GetEnumValue(Device* device, [CallerFree] string name);
    }
}
