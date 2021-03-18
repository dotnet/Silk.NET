// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// May be passed at context construction time to indicate the number of desired auxiliary effect slot sends per
    /// source.
    /// </summary>
    public enum MaxAuxiliarySends
    {
        /// <summary>
        /// Will chose a reliably working parameter.
        /// </summary>
        UseDriverDefault = 0,

        /// <summary>
        /// One send per source.
        /// </summary>
        One = 1,

        /// <summary>
        /// Two sends per source.
        /// </summary>
        Two = 2,

        /// <summary>
        /// Three sends per source.
        /// </summary>
        Three = 3,

        /// <summary>
        /// Four sends per source.
        /// </summary>
        Four = 4
    }
}