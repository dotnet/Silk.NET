// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Functions
{
    /// <summary>
    /// Represents a C# type signature.
    /// </summary>
    public class Type : IEquatable<Type>
    {
        /// <summary>
        /// Gets a value indicating whether this type is a pointer.
        /// </summary>
        [JsonIgnore]
        public bool IsPointer => IndirectionLevels != 0;

        /// <summary>
        /// Gets a value indicating whether this type is an array.
        /// </summary>
        [JsonIgnore]
        public bool IsArray => ArrayDimensions != 0;

        /// <summary>
        /// Gets or sets the amount of indirection levels (asterisks as represented in C#).
        /// </summary>
        public int IndirectionLevels { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of the array (i.e. the amount of [] as represented in C#).
        /// </summary>
        public int ArrayDimensions { get; set; }

        /// <summary>
        /// Gets or sets the name of this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this type is by ref.
        /// </summary>
        public bool IsByRef { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this type is an out type.
        /// </summary>
        public bool IsOut { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return Name +
                   (IsPointer ? new string('*', IndirectionLevels) : string.Empty) +
                   (IsArray ? Utilities.GetArrayDimensionString(ArrayDimensions) : string.Empty);
        }

        /// <summary>
        /// Returns a value indicating whether this signature represents a void pointer.
        /// </summary>
        /// <returns>A value indicating whether this signature represents a void pointer.</returns>
        public bool IsVoidPointer()
        {
            return Name.Equals
                   (
                       typeof(void).Name.ToLowerInvariant(),
                       StringComparison.OrdinalIgnoreCase
                   )
                   && IsPointer;
        }

        public bool Equals(Type other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return IndirectionLevels == other.IndirectionLevels &&
                   ArrayDimensions == other.ArrayDimensions &&
                   string.Equals(Name, other.Name) &&
                   IsByRef == other.IsByRef &&
                   IsOut == other.IsOut;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is Type type && Equals(type);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = IndirectionLevels;
                hashCode = (hashCode * 397) ^ ArrayDimensions;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ IsByRef.GetHashCode();
                hashCode = (hashCode * 397) ^ IsOut.GetHashCode();
                return hashCode;
            }
        }
    }
}
