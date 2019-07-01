//
// EffectExtension.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;
using System.Numerics;

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Exposes the functions of the Effects Extension.
    /// </summary>
    [Extension("AL_EXT_EFX")]
    public abstract class EffectExtension : NativeExtension<AL>, IEFX
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected EffectExtension(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe void GenAuxiliaryEffectSlots(int count, uint* slots);

        /// <summary>
        /// Creates one or more auxiliary effect slots.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <returns>The slots.</returns>
        /// <seealso cref="DeleteAuxiliaryEffectSlots(uint[])"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public uint[] GenAuxiliaryEffectSlots(int count)
        {
            var result = new uint[count];
            unsafe
            {
                fixed (uint* ptr = result)
                {
                    GenAuxiliaryEffectSlots(count, ptr);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates an auxiliary effect slot.
        /// </summary>
        /// <returns>The slot.</returns>
        /// <seealso cref="DeleteAuxiliaryEffectSlot"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public uint GenAuxiliaryEffectSlot()
        {
            uint result = 0;
            unsafe
            {
                GenAuxiliaryEffectSlots(1, &result);
            }

            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void DeleteAuxiliaryEffectSlots(int count, uint* slots);

        /// <summary>
        /// Deletes and frees resources used for a set of auxiliary effect slots.
        /// </summary>
        /// <param name="slots">An array of slots to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlots(int)"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public void DeleteAuxiliaryEffectSlots(uint[] slots)
        {
            unsafe
            {
                fixed (uint* ptr = slots)
                {
                    DeleteAuxiliaryEffectSlots(slots.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Deletes and frees resources used an auxiliary effect slot.
        /// </summary>
        /// <param name="slot">The slot to delete.</param>
        /// <seealso cref="GenAuxiliaryEffectSlot"/>
        /// <seealso cref="IsAuxiliaryEffectSlot"/>
        public void DeleteAuxiliaryEffectSlot(uint slot)
        {
            unsafe
            {
                DeleteAuxiliaryEffectSlots(1, &slot);
            }
        }

        /// <inheritdoc />
        public abstract bool IsAuxiliaryEffectSlot(uint slot);

        /// <inheritdoc />
        public abstract void SetAuxiliaryEffectSlotProperty(uint slot, EffectSlotInteger param, int value);

        /// <inheritdoc />
        public abstract void SetAuxiliaryEffectSlotProperty(uint slot, EffectSlotFloat param, float value);

        /// <inheritdoc />
        public abstract void GetAuxiliaryEffectSlotProperty(uint slot, EffectSlotInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public int GetAuxiliaryEffectSlotProperty(uint slot, EffectSlotInteger param)
        {
            GetAuxiliaryEffectSlotProperty(slot, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract void GetAuxiliaryEffectSlotProperty(uint slot, EffectSlotFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given effect slot.
        /// </summary>
        /// <param name="slot">The slot.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public float GetAuxiliaryEffectSlotProperty(uint slot, EffectSlotFloat param)
        {
            GetAuxiliaryEffectSlotProperty(slot, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void GenEffects(int count, uint* effects);

        /// <summary>
        /// Creates one or more effects.
        /// </summary>
        /// <param name="count">The number of effects to create.</param>
        /// <returns>The effects.</returns>
        /// <seealso cref="DeleteEffects(uint[])"/>
        /// <seealso cref="IsEffect"/>
        public uint[] GenEffects(int count)
        {
            var result = new uint[count];
            unsafe
            {
                fixed (uint* ptr = result)
                {
                    GenEffects(count, ptr);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates an effect.
        /// </summary>
        /// <returns>The effect.</returns>
        /// <seealso cref="DeleteEffect"/>
        /// <seealso cref="IsEffect"/>
        public uint GenEffect()
        {
            uint result = 0;
            unsafe
            {
                GenEffects(1, &result);
            }

            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void DeleteEffects(int count, uint* effects);

        /// <summary>
        /// Deletes and frees resources used for a set of effects.
        /// </summary>
        /// <param name="effects">An array of effects to delete.</param>
        /// <seealso cref="GenEffects(int)"/>
        /// <seealso cref="IsEffect"/>
        public void DeleteEffects(uint[] effects)
        {
            unsafe
            {
                fixed (uint* ptr = effects)
                {
                    DeleteEffects(effects.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Deletes and frees resources used an effect.
        /// </summary>
        /// <param name="effect">The effect to delete.</param>
        /// <seealso cref="GenEffect()"/>
        /// <seealso cref="IsEffect"/>
        public void DeleteEffect(uint effect)
        {
            unsafe
            {
                DeleteEffects(1, &effect);
            }
        }

        /// <inheritdoc />
        public abstract bool IsEffect(uint effect);

        /// <inheritdoc />
        public abstract void SetEffectProperty(uint effect, EffectInteger param, int value);

        /// <inheritdoc />
        public abstract void SetEffectProperty(uint effect, EffectFloat param, float value);

        /// <inheritdoc />
        public abstract void SetEffectProperty(uint effect, EffectVector3 param, in Vector3 value);

        /// <inheritdoc />
        public abstract void GetEffectProperty(uint effect, EffectInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public int GetEffectProperty(uint effect, EffectInteger param)
        {
            GetEffectProperty(effect, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract void GetEffectProperty(uint effect, EffectFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public float GetEffectProperty(uint effect, EffectFloat param)
        {
            GetEffectProperty(effect, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract void GetEffectProperty(uint effect, EffectVector3 param, out Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given effect.
        /// </summary>
        /// <param name="effect">The effect.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public Vector3 GetEffectProperty(uint effect, EffectVector3 param)
        {
            GetEffectProperty(effect, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void GenFilters(int count, uint* filters);

        /// <summary>
        /// Creates one or more filters.
        /// </summary>
        /// <param name="count">The number of filters to create.</param>
        /// <returns>The filters.</returns>
        /// <seealso cref="DeleteFilters(uint[])"/>
        /// <seealso cref="IsFilter"/>
        public uint[] GenFilters(int count)
        {
            var result = new uint[count];
            unsafe
            {
                fixed (uint* ptr = result)
                {
                    GenFilters(count, ptr);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates an filter.
        /// </summary>
        /// <returns>The filter.</returns>
        /// <seealso cref="DeleteFilters(uint[])"/>
        /// <seealso cref="IsFilter"/>
        public uint GenFilter()
        {
            uint result = 0;
            unsafe
            {
                GenFilters(1, &result);
            }

            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void DeleteFilters(int count, uint* filters);

        /// <summary>
        /// Deletes and frees resources used for a set of filters.
        /// </summary>
        /// <param name="filters">An array of filters to delete.</param>
        /// <seealso cref="GenFilters(int)"/>
        /// <seealso cref="IsFilter"/>
        public void DeleteFilters(uint[] filters)
        {
            unsafe
            {
                fixed (uint* ptr = filters)
                {
                    DeleteFilters(filters.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Deletes and frees resources used an filter.
        /// </summary>
        /// <param name="filter">The filter to delete.</param>
        /// <seealso cref="GenFilter"/>
        /// <seealso cref="IsFilter"/>
        public void DeleteFilter(uint filter)
        {
            unsafe
            {
                DeleteFilters(1, &filter);
            }
        }

        /// <inheritdoc />
        public abstract bool IsFilter(uint filter);

        /// <inheritdoc />
        public abstract void SetFilterProperty(uint filter, FilterInteger param, int value);

        /// <inheritdoc />
        public abstract void SetFilterProperty(uint filter, FilterFloat param, float value);

        /// <inheritdoc />
        public abstract void GetFilterProperty(uint filter, FilterInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public int GetFilterProperty(uint filter, FilterInteger param)
        {
            GetFilterProperty(filter, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract void GetFilterProperty(uint filter, FilterFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public float GetFilterProperty(uint filter, FilterFloat param)
        {
            GetFilterProperty(filter, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, EFXSourceInteger param, int value);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, EFXSourceFloat param, float value);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, EFXSourceBoolean param, bool value);

        /// <inheritdoc/>
        public abstract void SetSourceProperty(uint source, EFXSourceInteger3 param, int value1, int value2, int value3);

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, EFXSourceInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public int GetSourceProperty(uint source, EFXSourceInteger param)
        {
            GetSourceProperty(source, param, out var result);
            return result;
        }

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, EFXSourceFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public float GetSourceProperty(uint source, EFXSourceFloat param)
        {
            GetSourceProperty(source, param, out var result);
            return result;
        }

        /// <inheritdoc/>
        public abstract void GetSourceProperty(uint source, EFXSourceBoolean param, out bool value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public bool GetSourceProperty(uint source, EFXSourceBoolean param)
        {
            GetSourceProperty(source, param, out var result);
            return result;
        }

        /// <inheritdoc/>
        public abstract void SetSourceProperty(uint source, EFXSourceInteger3 param, out int value1, out int value2, out int value3);

        /// <inheritdoc />
        public abstract void SetListenerProperty(uint listener, EFXListenerFloat param, float value);

        /// <inheritdoc />
        public abstract void GetListenerProperty(uint listener, EFXListenerFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        public float GetListenerProperty(uint listener, EFXListenerFloat param)
        {
            GetListenerProperty(listener, param, out var result);
            return result;
        }
    }
}
