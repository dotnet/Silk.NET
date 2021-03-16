// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// A list of valid <see cref="float" /> AuxiliaryEffectSlot/GetAuxiliaryEffectSlot parameters.
    /// </summary>
    public enum EffectSlotFloat
    {
        /// <summary>
        /// Range [0.0f .. 1.0f]
        /// Default: 1.0f
        /// This property is used to specify an output level for the Auxiliary Effect Slot. Setting the gain to 0.0f mutes
        /// the output.
        /// </summary>
        Gain = 0x0002
    }
}