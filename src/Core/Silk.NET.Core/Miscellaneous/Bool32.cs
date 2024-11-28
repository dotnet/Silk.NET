// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core
{
    /// <summary>
    /// A 32-bit boolean.
    /// </summary>
    public readonly struct Bool32 : IEquatable<Bool32>, IEquatable<uint>, IEquatable<bool>
    {
        private readonly uint _value;

        /// <summary>
        /// Gets the 32-bit value for this boolean.
        /// </summary>
        public uint Value { get => _value; }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns> A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Compares the current <see cref="Bool32"/> to another <see cref="object"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if <paramref name="obj"/> is equal to the current <see cref="Bool32"/>.</returns>
        public override bool Equals(object obj) => obj switch
        {
            Bool32 val => Equals(val),
            bool val => Equals(val),
            uint val => Equals(val),
            _ => base.Equals(obj)
        };

        /// <summary>
        /// Compares the current <see cref="Bool32"/> to another <see cref="Bool32"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="other">The other value.</param>
        /// <returns>True if the current <see cref="Bool32"/> is equal to the provided <see cref="bool"/> value.</returns>
        public bool Equals(Bool32 other) => Value == other.Value;

        /// <summary>
        /// Compares the current <see cref="Bool32"/> to a <see cref="uint"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="other">The other value.</param>
        /// <returns>True if the current <see cref="Bool32"/> is equal to the provided <see cref="uint"/> value.</returns>
        public bool Equals(uint other) => Value == other;

        /// <summary>
        /// Compares the current <see cref="Bool32"/> to a <see cref="bool"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="other">The other value.</param>
        /// <returns>True if the current <see cref="Bool32"/> is equal to the provided <see cref="bool"/> value.</returns>
        public bool Equals(bool other) => Value == (other ? 1U : 0U);

        #region Cast operators
        /// <summary>
        /// Creates a 32-bit boolean from the given 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The 32-bit unsigned integer value.</param>
        public Bool32(uint val) => _value = val;

        /// <summary>
        /// Creates a 32-bit boolean from the given managed boolean.
        /// </summary>
        /// <param name="val">The boolean value.</param>
        public Bool32(bool val) => _value = val ? 1u : 0u;

        /// <summary>
        /// Converts this 32-bit boolean to a managed boolean.
        /// </summary>
        /// <param name="val">The 32-bit boolean.</param>
        /// <returns>The managed boolean.</returns>
        public static implicit operator bool(Bool32 val) => val._value == 1;

        /// <summary>
        /// Converts this 32-bit boolean to a 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The 32-bit boolean.</param>
        /// <returns>The 32-bit unsigned integer.</returns>
        public static implicit operator uint(Bool32 val) => val._value;

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
        #endregion

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
        public static bool operator ==(Bool32 left, bool right) => left.Value == (right ? 1U : 0U);

        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="bool"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="bool"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool32 left, bool right) => left.Value != (right ? 1U : 0U);

        /// <summary>
        /// Compares a <see cref="bool"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="bool"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator ==(bool left, Bool32 right) => right.Value == (left ? 1U : 0U);

        /// <summary>
        /// Compares a <see cref="bool"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="bool"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator !=(bool left, Bool32 right) => right.Value != (left ? 1U : 0U);
        #endregion

        #region Bool32 vs uint equality
        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="uint"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="uint"/>.</param>
        /// <returns></returns>
        public static bool operator ==(Bool32 left, uint right) => left.Value == right;

        /// <summary>
        /// Compares a <see cref="Bool32"/> to a <see cref="uint"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool32"/>.</param>
        /// <param name="right">The right-hand <see cref="uint"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool32 left, uint right) => left.Value != right;

        /// <summary>
        /// Compares a <see cref="uint"/> to a <see cref="Bool32"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="uint"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator ==(uint left, Bool32 right) => left == right.Value;

        /// <summary>
        /// Compares a <see cref="uint"/> to a <see cref="Bool32"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="uint"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool32"/>.</param>
        /// <returns></returns>
        public static bool operator !=(uint left, Bool32 right) => left != right.Value;
        #endregion
    }
}
