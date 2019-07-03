// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// A list of valid Math.Vector3 Effect/GetEffect parameters.
    /// </summary>
    public enum EffectVector3
    {
        /// <summary>
        /// Reverb Pan does for the Reverb what Reflections Pan does for the Reflections. Unit: Vector3 of length 0f to 1f
        /// Default: {0.0f, 0.0f, 0.0f}
        /// </summary>
        EaxReverbLateReverbPan = 0x000E,

        /// <summary>
        /// This Vector3 controls the spatial distribution of the cluster of early reflections. The direction of this
        /// vector controls the global direction of the reflections, while its magnitude controls how focused the reflections
        /// are towards this direction. For legacy reasons this Vector3 follows a left-handed co-ordinate system! Note that
        /// OpenAL uses a right-handed coordinate system. Unit: Vector3 of length 0f to 1f Default: {0.0f, 0.0f, 0.0f}
        /// </summary>
        EaxReverbReflectionsPan = 0x000B
    }
}