//
// SoftStateBoolean.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="bool"/> parameters for <see cref="IStateSoft.GetBoolean"/>. These enumeration members
    /// are defined as extensions in the OpenAL Soft library.
    /// </summary>
    public enum SoftStateBoolean
    {
        /// <summary>
        /// Determines whether or not the state has a gain limit set.
        /// </summary>
        HasGainLimit = 0x200E,

        /// <summary>
        /// Determines whether or not the context has resamplers. Typically, this is always true.
        /// </summary>
        HasResamplers = 0x1210,

        /// <summary>
        /// Determines whether the default resampler is set.
        /// </summary>
        IsResamplerDefault = 0x1211,
    }
}
