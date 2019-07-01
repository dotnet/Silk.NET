//
// IEFXEffectSlots.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines the public API of the effect slot-related functions of the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFXEffectSlots
    {
        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <param name="slots">The first element of the array to place the slots into.</param>
        /// <seealso cref="DeleteAuxiliaryEffectSlots"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        unsafe void GenAuxiliaryEffectSlots(int count, uint* slots);

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to delete.</param>
        /// <param name="slots">A pointer to the array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        unsafe void DeleteAuxiliaryEffectSlots(int count, uint* slots);

        /// <summary>
        /// Determines whether or not the given handle is an auxiliary slot handle.
        /// </summary>
        /// <param name="slot">The handle.</param>
        /// <returns>true if the handle is a slot handle; otherwise, false.</returns>
        bool IsAuxiliaryEffectSlot(uint slot);

        /// <summary>
        /// Sets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("AuxiliaryEffectSloti")]
        void SetAuxiliaryEffectSlotProperty(uint slot, EffectSlotInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("AuxiliaryEffectSlotf")]
        void SetAuxiliaryEffectSlotProperty(uint slot, EffectSlotFloat param, float value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        [NativeSymbol("GetAuxiliaryEffectSloti")]
        void GetAuxiliaryEffectSlotProperty(uint slot, EffectSlotInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value.</param>
        [NativeSymbol("GetAuxiliaryEffectSlotf")]
        void GetAuxiliaryEffectSlotProperty(uint slot, EffectSlotFloat param, out float value);
    }
}
