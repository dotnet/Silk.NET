// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Generator.Common;
using Generator.Convert.Overrides;
using Enum = Generator.Common.Enums.Enum;

namespace Generator.Convert.Construction
{
    /// <summary>
    /// Provides utilities for applying overrides to profiles.
    /// </summary>
    public static class Overrider
    {
        /// <summary>
        /// Gets the overrides read from the override files specified in <see cref="Converter.CliOptions" />.
        /// </summary>
        public static Lazy<List<ApiProfileOverride>> Overrides { get; } = new Lazy<List<ApiProfileOverride>>
        (
            () => Converter.CliOptions.Overrides?.SelectMany(OverrideReader.GetProfileOverrides).ToList()
        );

        /// <summary>
        /// Gets the overrides for this profile using the <see cref="Converter.CliOptions" />, and then applies them to the
        /// profile.
        /// </summary>
        /// <param name="profile">The profile to which overrides should be applied.</param>
        public static void Override(Profile profile)
        {
            var overrides = Overrides?.Value.FirstOrDefault
                (x => x.Name == profile.Name && x.Version == profile.Version);
            if (overrides == null)
            {
                // no overrides available, the profile must be perfect.
                return;
            }

            ApplyFunctionReplacement(overrides, profile);
            ApplyEnumerationOverrides(overrides, profile);
        }

        private static void ApplyEnumerationOverrides(ApiProfileOverride overrides, Profile profile)
        {
            foreach (var overridesAddedEnumeration in overrides.AddedEnumerations)
            {
                profile.Projects["Core"]
                    .Enums.Add
                    (
                        new Enum
                        {
                            Name = overridesAddedEnumeration.Name,
                            Tokens = overridesAddedEnumeration.DirectTokens.Concat
                                (
                                    overridesAddedEnumeration.UseTokens.Select
                                    (
                                        x => profile.Projects["Core"]
                                            .Enums
                                            .FirstOrDefault(y => y.Name == x.Enumeration)
                                            ?
                                            .Tokens
                                            .FirstOrDefault(y => y.Name == x.Token)
                                    )
                                )
                                .Concat
                                (
                                    overridesAddedEnumeration.ReuseEnumerations.Select
                                        (
                                            x => profile.Projects["Core"]
                                                .Enums.FirstOrDefault(y => y.Name == x.Enumeration)
                                        )
                                        .SelectMany(x => x?.Tokens)
                                )
                                .ToList()
                        }
                    );
            }
        }

        private static void ApplyFunctionReplacement(ApiProfileOverride overrides, Profile profile)
        {
            foreach (var @interface in profile.Projects.Values.SelectMany(x => x.Interfaces.Values))
            {
            }
        }
    }
}
