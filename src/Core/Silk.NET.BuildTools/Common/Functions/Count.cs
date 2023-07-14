// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Functions
{
    /// <summary>
    /// Represents a computed or static element count of a parameter. A computed parameter varies its count based on the
    /// input arguments the user provides, and is extremely difficult (if not wholly impossible) to predict accurately.
    /// Therefore, these counts tend to generate a set of catch-all signatures (such as a single element, a pointer, an
    /// array, and a ref).
    /// </summary>
    public class Count
    {
        /// <summary>
        /// Backing field for <see cref="Count" />.
        /// </summary>
        [JsonProperty("StaticCount")] private int _count;

        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        [Obsolete("This constructor is for JSON use only. Please use one of the overloads.")]
        public Count()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        /// <param name="count">The static count.</param>
        public Count(int count)
        {
            _count = count;
            ComputedFromNames = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        /// <param name="computedFrom">The parameters the count is computed from.</param>
        public Count(IReadOnlyList<string> computedFrom)
        {
            ComputedFromNames = computedFrom.ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        /// <param name="value">The parameter the count is taken from.</param>
        /// <param name="isValueReference">Whether the value given is a reference to a parameter or a constant.</param>
        public Count(string? value, bool isValueReference = true)
        {
            if (isValueReference)
            {
                ValueReference = value;
                ComputedFromNames = new List<string>();
            }
            else
            {
                ConstantName = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the constant which determines this count's value.
        /// </summary>
        public string ConstantName { get; set; }

        /// <summary>
        /// Gets the static count of the parameter.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the count varies based on other parameters.</exception>
        [JsonIgnore]
        public int StaticCount
        {
            get
            {
                if (IsComputed)
                {
                    throw new InvalidOperationException
                    (
                        $"The count varies based on other parameters. Use {nameof(ComputedFrom)} instead."
                    );
                }

                if (IsReference)
                {
                    throw new InvalidOperationException
                    (
                        $"The count is a reference to a value in another parameter. Use {nameof(ValueReference)} instead."
                    );
                }

                return _count;
            }
        }

        /// <summary>
        /// Gets or sets the parameter that the count is taken from.
        /// </summary>
        public string? ValueReference { get; set; }

        /// <summary>
        /// Mathematical expression following the count.
        /// </summary>
        public string? Expression { get; set; }

        /// <summary>
        /// Gets or sets the function that the parameter in question is part of.
        /// </summary>
        [JsonIgnore]
        public Function FunctionReference { get; set; }

        /// <summary>
        /// Gets the parameters that the count is computed from.
        /// </summary>
                [JsonIgnore]
        public IReadOnlyList<Parameter> ComputedFrom => ComputedFromNames.Select
            (
                x => FunctionReference.Parameters.FirstOrDefault(y => y.Name == x)
            )
            .ToList();

        /// <summary>
        /// Gets or sets the parameter names the count is computed from.
        /// </summary>
        public List<string> ComputedFromNames { get; set; }

        /// <summary>
        /// Gets a value indicating whether the count is computed from other parameters.
        /// </summary>
        [JsonIgnore]
        public bool IsComputed => ComputedFromNames?.Any() ?? false;

        /// <summary>
        /// Gets a value indicating whether the count is retrieved from a constant.
        /// </summary>
        [JsonIgnore]
        public bool IsConstant => !(ConstantName is null);

        /// <summary>
        /// Gets a value indicating whether the count is a reference to the value of another parameter.
        /// </summary>
        [JsonIgnore]
        public bool IsReference => !(ValueReference is null);

        /// <summary>
        /// Gets a value indicating whether the count is a static count.
        /// </summary>
        [JsonIgnore]
        public bool IsStatic => !(IsComputed || IsReference);

        /// <summary>
        /// Gets a value indicating whether this count represents a count which is likely more than one.
        /// </summary>
        [JsonIgnore]
        public bool IsMultiple => IsStatic && _count > 1 || IsReference;

        /// <inheritdoc />
        public override string ToString()
        {
            if (IsComputed)
            {
                return $"COMPSIZE({string.Join(", ", ComputedFromNames)})";
            }

            return IsReference ? $"valueof({ValueReference})" : StaticCount.ToString();
        }
    }
}
