// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        [JsonProperty("IndirectionLevels")]
        private int _indirectionLevels;

        /// <summary>
        /// Gets or sets the amount of indirection levels (asterisks as represented in C#).
        /// </summary>
        [JsonIgnore]
        public int IndirectionLevels
        {
            get => _indirectionLevels;
            set
            {
                if (value < 0)
                {
                    Debug.WriteLine($"Negative indirection levels assigned at:\n{Environment.StackTrace}");
                }

                _indirectionLevels = value;
            }

        }

        /// <summary>
        /// Gets or sets the dimensions of the array (i.e. the amount of [] as represented in C#).
        /// </summary>
        public int ArrayDimensions { get; set; }

        /// <summary>
        /// Gets or sets the name of this type.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the group of this type.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the original name of this type, before mapping.
        /// </summary>
        public string OriginalName { get; set; }

        /// <summary>
        /// Gets or sets the original group of this type.
        /// </summary>
        public string OriginalGroup { get; set; }

        /// <summary>
        /// Gets or sets the generic types arguments for this type.
        /// </summary>
        public List<Type> GenericTypes { get; set; } = new List<Type>();

        /// <summary>
        /// Gets or sets a value indicating whether this type is by ref.
        /// </summary>
        public bool IsByRef { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this type is an out type.
        /// </summary>
        public bool IsOut { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this type is an in type.
        /// </summary>
        public bool IsIn { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return (IsIn ? "in " : string.Empty) +
                   (IsOut ? "out " : string.Empty) +
                   (IsByRef ? "ref " : string.Empty) +
                   Name +
                   (IsPointer ? new string('*', IndirectionLevels) : string.Empty) +
                   (IsArray ? Utilities.GetArrayDimensionString(ArrayDimensions) : string.Empty) +
                   (GenericTypes.Any() ? $"<{string.Join(", ", GenericTypes.Select(x => x.Name))}>" : string.Empty);
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

        /// <summary>
        /// Returns a value indicating whether this signature represents a void pointer.
        /// </summary>
        /// <returns>A value indicating whether this signature represents a void pointer.</returns>
        public bool IsSingleVoidPointer()
        {
            return ToString() == "void*";
            //return Name.Equals
            //       (
            //           typeof(void).Name.ToLowerInvariant(),
            //           StringComparison.OrdinalIgnoreCase
            //       )
            //       && IsPointer;
        }

        /// <summary>
        /// Returns a value indicating whether this signature represents an IntPtr.
        /// </summary>
        /// <returns>A value indicating whether this signature represents an IntPtr.</returns>
        public bool IsIntPtr()
        {
            return ToString() == "IntPtr" && !IsIn && !IsByRef && !IsOut;
        }

        /// <summary>
        /// Returns a value indicating whether this signature represents a UIntPtr.
        /// </summary>
        /// <returns>A value indicating whether this signature represents a UIntPtr.</returns>
        public bool IsUIntPtr()
        {
            return ToString() == "UIntPtr" && !IsIn && !IsByRef && !IsOut;
        }

        /// <inheritdoc />
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
                   IsOut == other.IsOut &&
                   IsIn == other.IsIn;
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = IndirectionLevels;
                hashCode = (hashCode * 397) ^ ArrayDimensions;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ IsByRef.GetHashCode();
                hashCode = (hashCode * 397) ^ IsOut.GetHashCode();
                hashCode = (hashCode * 397) ^ IsIn.GetHashCode();
                return hashCode;
            }
        }
    }
}
