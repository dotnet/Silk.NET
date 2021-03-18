// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// A list of valid <see cref="int" /> Source/GetSource parameters.
    /// </summary>
    public enum EFXSourceInteger3
    {
        /// <summary>
        /// This Source property is used to establish connections between Sources and Auxiliary Effect
        /// Slots. For a Source to feed an Effect that has been loaded into an Auxiliary Effect Slot the application must
        /// configure one of the Source’s auxiliary sends. This process involves setting 3 variables – the destination
        /// Auxiliary Effect Slot ID, the Auxiliary Send number, and an optional Filter ID.
        /// </summary>
        AuxiliarySendFilter = 0x20006
    }
}