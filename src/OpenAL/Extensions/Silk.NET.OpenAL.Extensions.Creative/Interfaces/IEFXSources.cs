// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.InteropServices;
using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Defines the public API of the source-related functions of the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFXSources
    {
        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcei")]
        void SetSourceProperty(uint source, EFXSourceInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcef")]
        void SetSourceProperty(uint source, EFXSourceFloat param, float value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcei")]
        void SetSourceProperty(uint source, EFXSourceBoolean param, [MarshalAs(UnmanagedType.I4)] bool value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        void SetSourceProperty(uint source, EFXSourceInteger3 param, int value1, int value2, int value3);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetSourcei")]
        void GetSourceProperty(uint source, EFXSourceInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetSourcef")]
        void GetSourceProperty(uint source, EFXSourceFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetSourcef")]
        void GetSourceProperty(uint source, EFXSourceBoolean param, [MarshalAs(UnmanagedType.I4)] out bool value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        void SetSourceProperty(uint source, EFXSourceInteger3 param, out int value1, out int value2, out int value3);
    }
}