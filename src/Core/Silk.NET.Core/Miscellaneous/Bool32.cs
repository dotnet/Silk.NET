// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core
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

        #region Bool32 vs Bool32 equality
        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator ==(Bool32 left, Bool32 right) => left.Value == right.Value;

        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="Bool32"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool32 left, Bool32 right) => left.Value != right.Value;
        #endregion

        #region Bool32 vs bool equality
        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="bool"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="bool"/>.</param>
        /// <returns></returns>
        public static bool operator ==(Bool32 left, bool right) => left.Value == (right ? 1 : 0);

        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="bool"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="bool"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool32 left, bool right) => left.Value != (right ? 1 : 0);

        /// <summary>
        /// Compares a <see cref="bool"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="bool"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator ==(bool left, Bool32 right) => right.Value == (left ? 1 : 0);

        /// <summary>
        /// Compares a <see cref="bool"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="bool"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator !=(bool left, Bool32 right) => right.Value != (left ? 1 : 0);
        #endregion

        #region Bool32 vs uint equality
        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="uint"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="uint"/>.</param>
        /// <returns></returns>
        public static bool operator == (Bool32 left, uint right) => left.Value == right;

        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="uint"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="uint"/>.</param>
        /// <returns></returns>
        public static bool operator != (Bool32 left, uint right) => left.Value != right;

        /// <summary>
        /// Compares a <see cref="uint"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="uint"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator == (uint left, Bool32 right) => left == right.Value;

        /// <summary>
        /// Compares a <see cref="uint"/> to a <see cref="Bool32"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="uint"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator != (uint left, Bool32 right) => left != right.Value;
        #endregion
    }
}
