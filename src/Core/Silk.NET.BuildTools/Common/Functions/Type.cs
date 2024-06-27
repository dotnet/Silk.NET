// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    public class Type
    {
        /// <summary>
        /// Gets a value indicating whether this type is a pointer.
        /// </summary>
        [JsonIgnore]
        public bool IsPointer => IndirectionLevels != 0;

        /// <summary>
        /// Gets a value indicating whether this type is a function pointer.
        /// </summary>
        [JsonIgnore]
        public bool IsFunctionPointer => !(FunctionPointerSignature is null) && IsPointer;

        /// <summary>
        /// Gets a value indicating whether this type is an array.
        /// </summary>
        [JsonIgnore]
        public bool IsArray => ArrayDimensions != 0;

        [JsonProperty("IndirectionLevels")] private int _indirectionLevels;

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
                    Console.WriteLine($"Negative indirection levels assigned at:\n{Environment.StackTrace}");
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
        /// Gets or sets the original name of this type, before mapping.
        /// </summary>
        public string OriginalName { get; set; }

        /// <summary>
        /// Gets or sets the original group of this type.
        /// </summary>
        public string OriginalGroup { get; set; }

        /// <summary>
        /// Gets or sets the original class of this type.
        /// </summary>
        public string OriginalClass { get; set; }

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

        /// <summary>
        /// Gets or sets a value indicating whether this type is a "this" type (i.e. an extension method type reference)
        /// </summary>
        public bool IsThis { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a pointer that is actually an integer and not a pointer to a
        /// memory location.
        /// </summary>
        public bool IsIntAsPtr { get; set; }

        /// <summary>
        /// Gets or sets the function pointer signature if this type is a function pointer. May be null.
        /// </summary>
        public Function FunctionPointerSignature { get; set; }

        /// <summary>
        /// Gets or sets whether this type references a generic type parameter defined in the function.
        /// </summary>
        public bool IsGenericTypeParameterReference { get; set; }

        /// <inheritdoc />
        public override string ToString() => ToString(false);

        public string ToString(bool allowFunctionPointers)
        {
            return (IsThis ? "this " : string.Empty) +
                   (IsIn ? "[RequiresLocation] in " : string.Empty) +
                   (IsOut ? "out " : string.Empty) +
                   (IsByRef ? "ref " : string.Empty) +
                   (IsFunctionPointer && allowFunctionPointers && Name == "void"
                       ? FunctionPointerSignature.GetFunctionPointerSignature()
                       : Name) +
                   (IsPointer ? new string('*', IndirectionLevels) : string.Empty) +
                   (IsArray ? Utilities.GetArrayDimensionString(ArrayDimensions) : string.Empty) +
                   (GenericTypes.Any() ? $"<{string.Join(", ", GenericTypes.Select(x => x.Name))}>" : string.Empty);
        }

        /// <summary>
        /// Determines whether this type represents a single-level pointer to the given type name.
        /// </summary>
        /// <param name="name">The type name.</param>
        /// <returns>Whether it's a single-level pointer.</returns>
        public bool IsSinglePointerTo(string name)
            => Name == name && IndirectionLevels == 1 && !IsIn && !IsOut && !IsByRef &&
               !IsFunctionPointer && !IsArray && GenericTypes.Count == 0;

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
        /// Returns a value indicating whether this signature represents an IntPtr.
        /// </summary>
        /// <returns>A value indicating whether this signature represents an IntPtr.</returns>
        public bool IsIntPtr()
        {
            return (ToString() == "IntPtr" || ToString() == "nint") && !IsIn && !IsByRef && !IsOut;
        }

        /// <summary>
        /// Returns a value indicating whether this signature represents a UIntPtr.
        /// </summary>
        /// <returns>A value indicating whether this signature represents a UIntPtr.</returns>
        public bool IsUIntPtr()
        {
            return (ToString() == "UIntPtr" || ToString() == "nuint") && !IsIn && !IsByRef && !IsOut;
        }

        public bool Eq(Type other) // can't use default equatable logic due to json.net thinking fnptrs self-reference
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

        internal void ForceNegativeIndirection(int val) => _indirectionLevels = val;
    }
}
