// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    [NativeApi(Prefix = "al")]
    [Extension("AL_SOFT_gain_clamp_ex")]
    public partial class SoftGainClamp : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public SoftGainClamp(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public partial double GetDouble(SoftGainClampDouble param);

        /// <inheritdoc />
        public partial float GetFloat(SoftGainClampFloat param);
    }
}
