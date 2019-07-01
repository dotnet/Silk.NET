//
// StateInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// A list of valid Int32 AL.Get() parameters.
    /// </summary>
    public enum StateInteger
    {
        /// <summary>
        /// Gets the distance model. The return value corresponds to one of the members in
        /// <see cref="OpenAL.DistanceModel"/>.
        /// </summary>
        DistanceModel = 0xD000,
    }
}
