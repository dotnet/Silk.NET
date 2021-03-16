// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Soft
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
        BSinc24Resampler
    }
}