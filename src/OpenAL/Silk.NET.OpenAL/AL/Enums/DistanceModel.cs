//
// DistanceModel.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Used by AL.DistanceModel(), the distance model can be retrieved by AL.Get() with
    /// ALGetInteger.DistanceModel.
    /// </summary>
    public enum DistanceModel
    {
        /// <summary>
        /// Bypasses all distance attenuation calculation for all Sources.
        /// </summary>
        None = 0,

        /// <summary>
        /// InverseDistance is equivalent to the IASIG I3DL2 model with the exception that SourceFloat.ReferenceDistance
        /// does not imply any clamping.
        /// </summary>
        InverseDistance = 0xD001,

        /// <summary>
        /// InverseDistanceClamped is the IASIG I3DL2 model, with SourceFloat.ReferenceDistance indicating both the
        /// reference distance and the distance below which gain will be clamped.
        /// </summary>
        InverseDistanceClamped = 0xD002,

        /// <summary>
        /// AL_EXT_LINEAR_DISTANCE extension.
        /// </summary>
        LinearDistance = 0xD003,

        /// <summary>
        /// AL_EXT_LINEAR_DISTANCE extension.
        /// </summary>
        LinearDistanceClamped = 0xD004,

        /// <summary>
        /// AL_EXT_EXPONENT_DISTANCE extension.
        /// </summary>
        ExponentDistance = 0xD005,

        /// <summary>
        /// AL_EXT_EXPONENT_DISTANCE extension.
        /// </summary>
        ExponentDistanceClamped = 0xD006,
    }
}
