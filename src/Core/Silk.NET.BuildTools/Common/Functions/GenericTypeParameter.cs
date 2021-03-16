// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.BuildTools.Common.Functions
{
    /// <summary>
    /// Represents a C# generic type parameter.
    /// </summary>
    public class GenericTypeParameter : IEquatable<GenericTypeParameter>
    {
        /// <summary>
        /// Create a new generic type parameter.
        /// </summary>
        public GenericTypeParameter()
        {
        }

        /// <summary>
        /// Create a new generic type parameter.
        /// </summary>
        /// <param name="genericTypeParameterName">The name of the generic type.</param>
        /// <param name="constraints">The constraints for this generic type.</param>
        public GenericTypeParameter(string genericTypeParameterName, IEnumerable<string> constraints)
        {
            Name = genericTypeParameterName;
            Constraints = constraints.ToList();
        }

        /// <summary>
        /// Gets or sets the name of this generic type parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of generic type parameter constraints.
        /// </summary>
        public List<string> Constraints { get; set; } = new List<string>();

        /// <inheritdoc />
        public bool Equals(GenericTypeParameter other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(Name, other.Name) && Constraints.SequenceEqual(other.Constraints);
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

            return obj is GenericTypeParameter parameter && Equals(parameter);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                // ReSharper disable NonReadonlyMemberInGetHashCode
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Constraints != null ? Constraints.GetHashCode() : 0);
                // ReSharper restore NonReadonlyMemberInGetHashCode
            }
        }
    }
}
