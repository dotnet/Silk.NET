//
// SoftStateInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="int"/> <see cref="IStateSoft.GetInteger"/> parameters.
    /// </summary>
    public enum SoftStateInteger
    {
        /// <summary>
        /// Gets the number of available resamplers.
        /// </summary>
        ResamplerCount = 0x1210,

        /// <summary>
        /// Gets the default resampler. The return value corresponds to one of the members in
        /// <see cref="Resampler"/>.
        /// </summary>
        DefaultResampler = 0x1211,
    }
}
