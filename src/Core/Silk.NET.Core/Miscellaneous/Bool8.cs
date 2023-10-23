// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Core
{
    /// <summary>
    /// A 8-bit boolean.
    /// </summary>
    public readonly struct Bool8 : IEquatable<Bool8>, IEquatable<byte>, IEquatable<bool>
    {
        /// <summary>
        /// Gets the 8-bit value for this boolean.
        /// </summary>
        public byte Value { get; }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns> A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Compares the current <see cref="Bool8"/> to another <see cref="object"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if <paramref name="obj"/> is equal to the current <see cref="Bool8"/>.</returns>
        public override bool Equals(object obj) => obj switch
        {
            Bool8 val => Equals(val),
            bool val => Equals(val),
            byte val => Equals(val),
            _ => base.Equals(obj)
        };

        /// <summary>
        /// Compares the current <see cref="Bool8"/> to another <see cref="Bool8"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="other">The other value.</param>
        /// <returns>True if the current <see cref="Bool8"/> is equal to the provided <see cref="bool"/> value.</returns>
        public bool Equals(Bool8 other) => Value == other.Value;

        /// <summary>
        /// Compares the current <see cref="Bool8"/> to a <see cref="byte"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="other">The other value.</param>
        /// <returns>True if the current <see cref="Bool8"/> is equal to the provided <see cref="byte"/> value.</returns>
        public bool Equals(byte other) => Value == other;

        /// <summary>
        /// Compares the current <see cref="Bool8"/> to a <see cref="bool"/>. Returns true if they are equal.
        /// </summary>
        /// <param name="other">The other value.</param>
        /// <returns>True if the current <see cref="Bool8"/> is equal to the provided <see cref="bool"/> value.</returns>
        public bool Equals(bool other) => Value == (other ? 1U : 0U);

        #region Cast operators
        /// <summary>
        /// Creates a 8-bit boolean from the given byte.
        /// </summary>
        /// <param name="val">The byte value.</param>
        public Bool8(byte val) => Value = val;

        /// <summary>
        /// Creates a 8-bit boolean from the given managed boolean.
        /// </summary>
        /// <param name="val">The boolean value.</param>
        public Bool8(bool val) => Value = val ? (byte) 1 : (byte) 0;

        /// <summary>
        /// Converts this 8-bit boolean to a managed boolean.
        /// </summary>
        /// <param name="val">The 8-bit boolean.</param>
        /// <returns>The managed boolean.</returns>
        public static implicit operator bool(Bool8 val) => val.Value == 1;

        /// <summary>
        /// Converts this 8-bit boolean to a byte.
        /// </summary>
        /// <param name="val">The 8-bit boolean.</param>
        /// <returns>The byte.</returns>
        public static implicit operator byte(Bool8 val) => val.Value;

        /// <summary>
        /// Creates a 8-bit boolean from the given managed boolean.
        /// </summary>
        /// <param name="val">The boolean value.</param>
        public static implicit operator Bool8(bool val) => new Bool8(val);

        /// <summary>
        /// Creates a 8-bit boolean from the given byte.
        /// </summary>
        /// <param name="val">The byte value.</param>
        public static implicit operator Bool8(byte val) => new Bool8(val);
        #endregion

        #region Bool8 vs Bool8 equality
        /// <summary>
        /// Compares a <see cref="Bool8"/> to a <see cref="Bool8"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool8"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool8"/>.</param>
        /// <returns></returns>
        public static bool operator ==(Bool8 left, Bool8 right) => left.Value == right.Value;

        /// <summary>
        /// Compares a <see cref="Bool8"/> to a <see cref="Bool8"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool8"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool8"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool8 left, Bool8 right) => left.Value != right.Value;
        #endregion

        #region Bool8 vs bool equality
        /// <summary>
        /// Compares a <see cref="Bool8"/> to a <see cref="bool"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool8"/>.</param>
        /// <param name="right">The right-hand <see cref="bool"/>.</param>
        /// <returns></returns>
        public static bool operator ==(Bool8 left, bool right) => left.Value == (right ? 1U : 0U);

        /// <summary>
        /// Compares a <see cref="Bool8"/> to a <see cref="bool"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool8"/>.</param>
        /// <param name="right">The right-hand <see cref="bool"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool8 left, bool right) => left.Value != (right ? 1U : 0U);

        /// <summary>
        /// Compares a <see cref="bool"/> to a <see cref="Bool8"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="bool"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool8"/>.</param>
        /// <returns></returns>
        public static bool operator ==(bool left, Bool8 right) => right.Value == (left ? 1U : 0U);

        /// <summary>
        /// Compares a <see cref="bool"/> to a <see cref="Bool8"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="bool"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool8"/>.</param>
        /// <returns></returns>
        public static bool operator !=(bool left, Bool8 right) => right.Value != (left ? 1U : 0U);
        #endregion

        #region Bool8 vs byte equality
        /// <summary>
        /// Compares a <see cref="Bool8"/> to a <see cref="byte"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool8"/>.</param>
        /// <param name="right">The right-hand <see cref="byte"/>.</param>
        /// <returns></returns>
        public static bool operator ==(Bool8 left, byte right) => left.Value == right;

        /// <summary>
        /// Compares a <see cref="Bool8"/> to a <see cref="byte"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="Bool8"/>.</param>
        /// <param name="right">The right-hand <see cref="byte"/>.</param>
        /// <returns></returns>
        public static bool operator !=(Bool8 left, byte right) => left.Value != right;

        /// <summary>
        /// Compares a <see cref="byte"/> to a <see cref="Bool8"/> for equality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="byte"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool8"/>.</param>
        /// <returns></returns>
        public static bool operator ==(byte left, Bool8 right) => left == right.Value;

        /// <summary>
        /// Compares a <see cref="byte"/> to a <see cref="Bool8"/> for inequality.
        /// </summary>
        /// <param name="left">The left-hand <see cref="byte"/>.</param>
        /// <param name="right">The right-hand <see cref="Bool8"/>.</param>
        /// <returns></returns>
        public static bool operator !=(byte left, Bool8 right) => left != right.Value;
        #endregion
    }
}
