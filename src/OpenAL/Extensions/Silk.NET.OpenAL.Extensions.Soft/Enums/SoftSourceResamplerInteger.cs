// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="int" /> <see cref="IStateSoft.GetInteger" /> parameters.
    /// </summary>
    public enum SoftSourceResamplerInteger
    {
        /// <summary>
        /// Gets the number of available resamplers.
        /// </summary>
        ResamplerCount = 0x1210,

        /// <summary>
        /// Gets the default resampler. The return value corresponds to one of the members in
        /// <see cref="Resampler" />.
        /// </summary>
        DefaultResampler = 0x1211
    }
}