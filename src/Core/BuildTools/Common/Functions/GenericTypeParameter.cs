// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Functions
{
    /// <summary>
    /// Represents a C# generic type parameter.
    /// </summary>
    public class GenericTypeParameter : IEquatable<GenericTypeParameter>
    {
        [JsonConstructor]
        public GenericTypeParameter(string? genericTypeParameterName = null, IEnumerable<string>? constraints = null)
        {
            Name = genericTypeParameterName ?? string.Empty;
            Constraints = constraints?.ToList() ?? new List<string>();
        }

        /// <summary>
        /// Gets or sets the name of this generic type parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of generic type parameter constraints.
        /// </summary>
        public List<string> Constraints { get; set; }

        public bool Equals(GenericTypeParameter? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(Name, other.Name) && Constraints.SequenceEqual(other.Constraints);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is GenericTypeParameter parameter && Equals(parameter);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Constraints != null ? Constraints.GetHashCode() : 0);
            }
        }
    }
}
