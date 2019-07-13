// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Defines the public API of the filter-related functions of the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFXFilters
    {
        /// <summary>
        /// Creates one or more filter objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteFilters" />
        /// <seealso cref="IsFilter" />
        unsafe void GenFilters(int count, uint* filters);

        /// <summary>
        /// Deletes one or more filter objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="filters">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenFilters" />
        /// <seealso cref="IsFilter" />
        unsafe void DeleteFilters(int count, uint* filters);

        /// <summary>
        /// Determines whether or not a given handle is an filter handle.
        /// </summary>
        /// <param name="filter">The handle.</param>
        /// <returns>true if the handle is an filter handle; otherwise, false.</returns>
        /// <seealso cref="GenFilters" />
        /// <seealso cref="DeleteFilters" />
        bool IsFilter(uint filter);

        /// <summary>
        /// Sets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Filteri")]
        void SetFilterProperty(uint filter, FilterInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Filterf")]
        void SetFilterProperty(uint filter, FilterFloat param, float value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetFilteri")]
        void GetFilterProperty(uint filter, FilterInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetFilterf")]
        void GetFilterProperty(uint filter, FilterFloat param, out float value);
    }
}