// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of the OpenAL Soft Deferred Updates extension.
    /// </summary>
    public abstract class DeferredUpdates : NativeExtension<AL>, IDeferredUpdatesState
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected DeferredUpdates(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract bool GetBoolean(DeferredStateBoolean param);

        /// <inheritdoc />
        public abstract void DeferUpdates();

        /// <inheritdoc />
        public abstract void ProcessUpdates();

        public abstract SearchPathContainer NameContainer { get; }
        public abstract bool IsExtensionPresent(string name);
        public abstract IntPtr GetProcAddress(string name);
        public abstract int GetEnumValue(string name);
    }
}