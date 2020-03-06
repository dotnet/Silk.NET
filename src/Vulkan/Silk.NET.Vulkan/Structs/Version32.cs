// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Vulkan
{
    /// <summary>
    /// A 32-bit version structure.
    /// </summary>
    public readonly struct Version32
    {
        /// <summary>
        /// The underlying Vulkan-compatible 32-bit version integer.
        /// </summary>
        public uint Value { get; }
        /// <summary>
        /// Creates a Vulkan version structure from the given major, minor, and patch values.
        /// </summary>
        /// <param name="major">The major value.</param>
        /// <param name="minor">The minor value.</param>
        /// <param name="patch">The patch value.</param>
        public Version32(uint major, uint minor, uint patch) => Value = major << 22 | minor << 12 | patch;
        /// <summary>
        /// Creates a Vulkan version structure from the given Vulkan-compatible value.
        /// </summary>
        /// <param name="value">The value.</param>
        private Version32(uint value) => Value = value;
        /// <summary>
        /// Gets the major component of this version structure.
        /// </summary>
        public uint Major => Value >> 22;
        /// <summary>
        /// Gets the minor component of this version structure.
        /// </summary>
        public uint Minor => (Value >> 12) & 0x3ff;
        /// <summary>
        /// Gets the patch component of this version structure.
        /// </summary>
        public uint Patch => (Value >> 22) & 0xfff;
        /// <summary>
        /// Creates a 32-bit version structure from the given 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The uint value.</param>
        /// <returns>The 32-bit version structure.</returns>
        public static explicit operator Version32(uint val) => new Version32(val);

        /// <summary>
        /// Creates a 32-bit version structure from the given managed version class.
        /// </summary>
        /// <param name="version">The version instance.</param>
        /// <returns>The 32-bit version structure.</returns>
        public static implicit operator Version32
            (Version version) => new Version32((uint) version.Major, (uint) version.Minor, (uint) version.Build);

        /// <summary>
        /// Gets the 32-bit unsigned integer representation for this 32-bit version structure.
        /// </summary>
        /// <param name="version">The 32-bit version structure.</param>
        /// <returns>The 32-bit unsigned integer.</returns>
        public static implicit operator uint(Version32 version) => version.Value;

        /// <summary>
        /// Converts this 32-bit version structure to a managed version class.
        /// </summary>
        /// <param name="version">The 32-bit version structure.</param>
        /// <returns>The managed representation.</returns>
        public static implicit operator Version
            (Version32 version) => new Version((int) version.Major, (int) version.Minor, (int) version.Patch);
    }
}
