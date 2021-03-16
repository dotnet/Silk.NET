// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    [NativeApi(Prefix = "al")]
    public partial class Soft : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected Soft(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public partial bool GetBoolean(SoftStateBoolean param);

        /// <inheritdoc />
        public partial double GetDouble(SoftStateDouble param);

        /// <inheritdoc />
        public partial float GetFloat(SoftStateFloat param);

        /// <inheritdoc />
        public partial int GetInteger(SoftStateInteger param);

        /// <inheritdoc />
        public partial nint GetPointer(StatePointer param);
    }
}
