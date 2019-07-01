//
// SoftStateDouble.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="double"/> <see cref="IStateSoft.GetDouble"/> parameters. These enumeration members
    /// are defined as extensions in the OpenAL Soft library.
    /// </summary>
    public enum SoftStateDouble
    {
        /// <summary>
        /// Gets the gain limit of the context.
        /// </summary>
        GainLimit = 0x200E,
    }
}
