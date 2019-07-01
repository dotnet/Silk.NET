//
// Resampler.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A set of resamplers defined in OpenAL Soft.
    /// </summary>
    public enum Resampler
    {
        /// <summary>
        /// A point resampler.
        /// </summary>
        PointResampler,

        /// <summary>
        /// A linear resampler.
        /// </summary>
        LinearResampler,

        /// <summary>
        /// A FIR resampler.
        /// </summary>
        FIR4Resampler,

        /// <summary>
        /// A B-Sine resampler (12 bits).
        /// </summary>
        BSinc12Resampler,

        /// <summary>
        /// A B-Sine resampler (24 bits).
        /// </summary>
        BSinc24Resampler,
    }
}
