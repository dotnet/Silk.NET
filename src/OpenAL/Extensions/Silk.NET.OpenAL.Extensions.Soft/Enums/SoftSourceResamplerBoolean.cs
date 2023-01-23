// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="bool" /> parameters for <see cref="IStateSoft.GetBoolean" />. These enumeration members
    /// are defined as extensions in the OpenAL Soft library.
    /// </summary>
    public enum SoftSourceResamplerBoolean
    {
        /// <summary>
        /// Determines whether or not the context has resamplers. Typically, this is always true.
        /// </summary>
        HasResamplers = 0x1210,

        /// <summary>
        /// Determines whether the default resampler is set.
        /// </summary>
        IsResamplerDefault = 0x1211
    }
}