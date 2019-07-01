//
// DeferredUpdates.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;

namespace OpenToolkit.OpenAL.Extensions.Soft.DeferredUpdates
{
    /// <summary>
    /// Exposes the public API of the OpenAL Soft Deferred Updates extension.
    /// </summary>
    public abstract class DeferredUpdates : ExtensionBase, IDeferredUpdatesState
    {
        /// <inheritdoc cref ="ExtensionBase"/>
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
    }
}
