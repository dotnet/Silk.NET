//
// EFXSourceInteger3.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// A list of valid <see cref="int"/> Source/GetSource parameters.
    /// </summary>
    public enum EFXSourceInteger3
    {
        /// <summary>
        /// This Source property is used to establish connections between Sources and Auxiliary Effect
        /// Slots. For a Source to feed an Effect that has been loaded into an Auxiliary Effect Slot the application must
        /// configure one of the Source’s auxiliary sends. This process involves setting 3 variables – the destination
        /// Auxiliary Effect Slot ID, the Auxiliary Send number, and an optional Filter ID.
        /// </summary>
        AuxiliarySendFilter = 0x20006,
    }
}
