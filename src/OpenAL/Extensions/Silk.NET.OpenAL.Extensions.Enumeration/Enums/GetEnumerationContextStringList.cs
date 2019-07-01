//
// GetEnumerationContextStringList.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Defines available parameters for <see cref="IEnumerationContextState.GetStringList(Device*, GetEnumerationContextStringList)" />.
    /// </summary>
    public enum GetEnumerationContextStringList
    {
        /// <summary>
        /// The specifier strings for all available devices. ALC_ENUMERATION_EXT
        /// </summary>
        DeviceSpecifiers = 0x1005,
    }
}
