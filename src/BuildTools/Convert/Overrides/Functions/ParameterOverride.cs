// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Generator.Common.Functions;
using JetBrains.Annotations;
using Type = Generator.Common.Functions.Type;

namespace Generator.Convert.Overrides.Functions
{
    /// <summary>
    /// Represents an overridden parameter.
    /// </summary>
    public class ParameterOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterOverride" /> class.
        /// </summary>
        /// <param name="name">The base name of the parameter.</param>
        /// <param name="newName">The new name of the parameter.</param>
        /// <param name="newType">The new type of the parameter.</param>
        /// <param name="newFlow">The new flow of the parameter.</param>
        /// <param name="newCount">The new count of the parameter.</param>
        public ParameterOverride
        (
            [NotNull] string name,
            [CanBeNull] string newName,
            [CanBeNull] Type newType,
            FlowDirection? newFlow,
            [CanBeNull] string newCount
        )
        {
            BaseName = name ?? throw new ArgumentNullException(nameof(name));
            NewName = newName;
            NewType = newType;
            NewFlow = newFlow;
            NewCount = newCount;
        }

        /// <summary>
        /// Gets the name of the parameter that the override affects.
        /// </summary>
        [NotNull]
        public string BaseName { get; }

        /// <summary>
        /// Gets the new name of the parameter.
        /// </summary>
        [CanBeNull]
        public string NewName { get; }

        /// <summary>
        /// Gets the new type of the parameter.
        /// </summary>
        [CanBeNull]
        public Type NewType { get; }

        /// <summary>
        /// Gets the new flow of the parameter.
        /// </summary>
        [CanBeNull]
        public FlowDirection? NewFlow { get; }

        /// <summary>
        /// Gets the new count of the parameter. The count is validated and built into a <see cref="Count" /> in
        /// the baking step.
        /// </summary>
        [CanBeNull]
        public string NewCount { get; }
    }
}
