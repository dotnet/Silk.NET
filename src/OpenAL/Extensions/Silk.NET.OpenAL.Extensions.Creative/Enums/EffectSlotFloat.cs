// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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