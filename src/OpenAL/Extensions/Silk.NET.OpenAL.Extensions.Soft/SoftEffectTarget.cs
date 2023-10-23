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
    [Extension("AL_SOFT_effect_target")]
    public partial class SoftEffectTarget : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public SoftEffectTarget(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        [NativeApi(EntryPoint = "AuxiliaryEffectSloti")]
        public partial void SetAuxiliaryEffectSlotProperty(uint slot, SoftEffectSlotInteger param, int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetAuxiliaryEffectSloti")]
        public partial void GetAuxiliaryEffectSlotProperty(uint slot, SoftEffectSlotInteger param, out int value);
    }
}
