//
// IEnumerateAllContextState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace OpenToolkit.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Defines the public API of the context-related functions of the EnumerateAll extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IEnumerateAllContextState
    {
        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        unsafe string GetString(Device* device, GetEnumerateAllContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        unsafe char* GetStringList(Device* device, GetEnumerateAllContextStringList param);
    }
}
