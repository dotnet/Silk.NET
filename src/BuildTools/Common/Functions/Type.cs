// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Newtonsoft.Json;

namespace Generator.Common.Functions
{
    /// <summary>
    /// Represents a C# type signature.
    /// </summary>
    public class Type
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
    }
}
