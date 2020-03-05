// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Vulkan
{
    /// <summary>
    /// A 32-bit boolean.
    /// </summary>
    public readonly struct Bool32
    {
        /// <summary>
        /// Gets the 32-bit value for this boolean.
        /// </summary>
        public uint Value { get; }

        /// <summary>
        /// Creates a 32-bit boolean from the given 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The 32-bit unsigned integer value.</param>
        public Bool32(uint val) => Value = val;

        /// <summary>
        /// Creates a 32-bit boolean from the given managed boolean.
        /// </summary>
        /// <param name="val">The boolean value.</param>
        public Bool32(bool val) => Value = val ? 1u : 0u;

        /// <summary>
        /// Converts this 32-bit boolean to a managed boolean.
        /// </summary>
        /// <param name="val">The 32-bit boolean.</param>
        /// <returns>The managed boolean.</returns>
        public static implicit operator bool(Bool32 val) => val.Value == 1;

        /// <summary>
        /// Converts this 32-bit boolean to a 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The 32-bit boolean.</param>
        /// <returns>The 32-bit unsigned integer.</returns>
        public static implicit operator uint(Bool32 val) => val.Value;

        /// <summary>
        /// Creates a 32-bit boolean from the given managed boolean.
        /// </summary>
        /// <param name="val">The boolean value.</param>
        public static implicit operator Bool32(bool val) => new Bool32(val);

        /// <summary>
        /// Creates a 32-bit boolean from the given 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The 32-bit unsigned integer value.</param>
        public static implicit operator Bool32(uint val) => new Bool32(val);
    }
}
