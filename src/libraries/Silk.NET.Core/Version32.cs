// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
namespace Silk.NET.Core
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
        /// <param name="variant">The major value. It is a 3-bit integer</param>
        /// <param name="major">The major value. It is a 7-bit integer</param>
        /// <param name="minor">The minor value. It is a 10-bit integer</param>
        /// <param name="patch">The patch value. It is a 12-bit integer</param>
        /// <exception cref="ArgumentOutOfRangeException">major, minor, or patch were out of the range of valid values</exception>
        public Version32(uint variant, uint major, uint minor, uint patch)
        {
            /*The variant is a 3-bit integer packed into bits 31-29. -Donovan/Redhacker1, Why is this not used? 
            
            The major version is a 7-bit integer packed into bits 28-22. 2^7 = 128
            
            The minor version number is a 10-bit integer packed into bits 21-12. 2^10 = 1024
            
            The patch version number is a 12-bit integer packed into bits 11-0. 2^12 = 4096
            */
            // Sanity check to ensure that the values are correct
            if ( (variant & uint.MaxValue - 7) != 0 || (major & uint.MaxValue - 127) != 0 || (minor & uint.MaxValue - 1023) != 0 || (patch & uint.MaxValue - 4095) != 0)
            {
                throw new ArgumentOutOfRangeException("variant, major, minor and/or patch were out of range, ");
            }


            Value = (variant & 7) << 29 | (major & 127) << 22 | (minor & 1023) << 12 | (patch & 4095);
        }

        /// <summary>
        /// Creates a Vulkan version structure from the given Vulkan-compatible value.
        /// </summary>
        /// <param name="value">The value.</param>
        private Version32(uint value) => Value = value;
        
        /// <summary>
        /// Gets the variant component of this version structure.
        /// </summary>
        public uint Variant => Value >> 29;
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
        public uint Patch => Value & 0xfff;
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
            (Version version) => new Version32(0, (uint) version.Major, (uint) version.Minor, (uint) version.Build);

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
