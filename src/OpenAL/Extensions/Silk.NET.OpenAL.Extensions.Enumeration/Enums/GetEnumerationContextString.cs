//
// GetEnumerationContextString.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Defines available parameters for <see cref="IEnumerationContextState.GetString(Device*, GetEnumerationContextString)" />.
    /// </summary>
    public enum GetEnumerationContextString
    {
        /// <summary>
        /// Gets the specifier for the default device.
        /// </summary>
        DefaultDeviceSpecifier = 0x1004,
    }
}
