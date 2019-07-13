// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Numerics;
using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Defines the public API of the effect-related functions of the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFXEffects
    {
        /// <summary>
        /// Creates one or more effect objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteEffects" />
        /// <seealso cref="IsEffect" />
        unsafe void GenEffects(int count, uint* effects);

        /// <summary>
        /// Deletes one or more effect objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="effects">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenEffects" />
        /// <seealso cref="IsEffect" />
        unsafe void DeleteEffects(int count, uint* effects);

        /// <summary>
        /// Determines whether or not a given handle is an effect handle.
        /// </summary>
        /// <param name="effect">The handle.</param>
        /// <returns>true if the handle is an effect handle; otherwise, false.</returns>
        /// <seealso cref="GenEffects" />
        /// <seealso cref="DeleteEffects" />
        bool IsEffect(uint effect);

        /// <summary>
        /// Sets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Effecti")]
        void SetEffectProperty(uint effect, EffectInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Effectf")]
        void SetEffectProperty(uint effect, EffectFloat param, float value);

        /// <summary>
        /// Sets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Effectfv")]
        void SetEffectProperty(uint effect, EffectVector3 param, in Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetEffecti")]
        void GetEffectProperty(uint effect, EffectInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetEffectf")]
        void GetEffectProperty(uint effect, EffectFloat param, out float value);

        /// <summary>
        /// Gets the vector value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetEffectfv")]
        void GetEffectProperty(uint effect, EffectVector3 param, out Vector3 value);
    }
}