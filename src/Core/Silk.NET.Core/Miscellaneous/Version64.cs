// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core
{
    /// <summary>
    /// A 64-bit version structure.
    /// </summary>
    public readonly struct Version64
    {
        /// <summary>
        /// The underlying OpenXR-compatible 64-bit version integer.
        /// </summary>
        public ulong Value { get; }

        /// <summary>
        /// Creates a OpenXR version structure from the given major, minor, and patch values.
        /// </summary>
        /// <param name="major">The major value.</param>
        /// <param name="minor">The minor value.</param>
        /// <param name="patch">The patch value.</param>
        public Version64(uint major, uint minor, uint patch)
            => Value = ((major & 0xffffUL) << 48) | ((minor & 0xffffUL) << 32) | (patch & 0xffffffffUL);

        /// <summary>
        /// Creates a OpenXR version structure from the given OpenXR-compatible value.
        /// </summary>
        /// <param name="value">The value.</param>
        private Version64(ulong value) => Value = value;

        /// <summary>
        /// Gets the major component of this version structure.
        /// </summary>
        public uint Major => (uint) ((Value >> 48) & 0xffffUL);

        /// <summary>
        /// Gets the minor component of this version structure.
        /// </summary>
        public uint Minor => (uint) ((Value >> 32) & 0xffffUL);

        /// <summary>
        /// Gets the patch component of this version structure.
        /// </summary>
        public uint Patch => (uint) (Value & 0xffffffffUL);

        /// <summary>
        /// Creates a 64-bit version structure from the given 64-bit unsigned integer.
        /// </summary>
        /// <param name="val">The uint value.</param>
        /// <returns>The 64-bit version structure.</returns>
        public static explicit operator Version64(ulong val) => new(val);

        /// <summary>
        /// Creates a 64-bit version structure from the given managed version class.
        /// </summary>
        /// <param name="version">The version instance.</param>
        /// <returns>The 64-bit version structure.</returns>
        public static implicit operator Version64
            (Version version) => new((uint) version.Major, (uint) version.Minor, (uint) version.Build);

        /// <summary>
        /// Gets the 64-bit unsigned integer representation for this 64-bit version structure.
        /// </summary>
        /// <param name="version">The 64-bit version structure.</param>
        /// <returns>The 64-bit unsigned integer.</returns>
        public static implicit operator ulong(Version64 version) => version.Value;

        /// <summary>
        /// Converts this 64-bit version structure to a managed version class.
        /// </summary>
        /// <param name="version">The 64-bit version structure.</param>
        /// <returns>The managed representation.</returns>
        public static implicit operator Version
            (Version64 version) => new((int) version.Major, (int) version.Minor, (int) version.Patch);
    }
}
