// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Constructors
{
    /// <summary>
    /// An API constructor for Vulkan.
    /// </summary>
    public class VulkanConstructor : IConstructor
    {
        /// <inheritdoc />
        public void WriteFunctions(Profile profile, IEnumerable<Function> functions, ProfileConverterOptions opts)
        {
            foreach (var function in functions)
            {
                if (function.ProfileName != profile.Name || function.ProfileVersion?.ToString(2) != profile.Version)
                {
                    continue;
                }

                foreach (var rawCategory in function.Categories)
                {
                    var category = FormatCategory(rawCategory);
                    var preCategory = $"{opts.Prefix.ToUpper()}_{rawCategory}";
                    // check that the root project exists
                    if (!profile.Projects.ContainsKey("Core"))
                    {
                        profile.Projects.Add
                        (
                            "Core",
                            new Project
                            {
                                CategoryName = "Core", ExtensionName = "Core", IsRoot = true,
                                Namespace = string.Empty
                            }
                        );
                    }

                    // check that the extension project exists, if applicable
                    if (function.ExtensionName != "Core" && !profile.Projects.ContainsKey(category))
                    {
                        profile.Projects.Add
                        (
                            category,
                            new Project
                            {
                                CategoryName = category, ExtensionName = $"{opts.Prefix.ToUpper()}_{category}",
                                IsRoot = false,
                                Namespace = $".{category.CheckMemberName(opts.Prefix)}"
                            }
                        );
                    }

                    // check that the interface exists
                    if
                    (
                        !profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Interfaces.ContainsKey(preCategory)
                    )
                    {
                        profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Interfaces.Add
                            (
                                preCategory,
                                new Interface
                                {
                                    Name =
                                        $"I{Naming.Translate(TrimName(rawCategory, opts), opts.Prefix).CheckMemberName(opts.Prefix)}"
                                }
                            );
                    }

                    // add the function to the interface
                    profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                        .Interfaces[preCategory]
                        .Functions.Add(function);
                }
            }
        }

        /// <inheritdoc />
        public void WriteEnums(Profile profile, IEnumerable<Enum> enums, ProfileConverterOptions opts)
        {
            if (!profile.Projects.ContainsKey("Core"))
            {
                profile.Projects.Add
                (
                    "Core",
                    new Project
                    {
                        CategoryName = "Core", ExtensionName = "Core", IsRoot = false,
                        Namespace = string.Empty
                    }
                );
            }

            profile.Projects["Core"].Enums.AddRange(enums);
            profile.TypeMaps.Add(enums.RemoveDuplicates((x, y) => x.NativeName == y.NativeName).ToDictionary(x => x.NativeName, x => x.Name));
        }

        /// <inheritdoc />
        public void WriteStructs(Profile profile, IEnumerable<Struct> structs, ProfileConverterOptions opts)
        {
            var map = new Dictionary<string, string>();
            foreach (var @struct in structs)
            {
                if (@struct.ProfileName != profile.Name || @struct.ProfileVersion?.ToString(2) != profile.Version)
                {
                    continue;
                }

                var category = FormatCategory(@struct.ExtensionName);

                // check that the root project exists
                if (!profile.Projects.ContainsKey("Core"))
                {
                    profile.Projects.Add
                    (
                        "Core",
                        new Project
                        {
                            CategoryName = "Core", ExtensionName = "Core", IsRoot = true,
                            Namespace = string.Empty
                        }
                    );
                }

                // check that the extension project exists, if applicable
                if (@struct.ExtensionName != "Core" && !profile.Projects.ContainsKey(category))
                {
                    profile.Projects.Add
                    (
                        category,
                        new Project
                        {
                            CategoryName = category, ExtensionName = $"{opts.Prefix.ToUpper()}_{category}",
                            IsRoot = false,
                            Namespace = $".{category.CheckMemberName(opts.Prefix)}"
                        }
                    );
                }

                // add the struct
                profile.Projects[@struct.ExtensionName == "Core" ? "Core" : category].Structs.Add(@struct);

                // add the struct to the type map
                map[@struct.NativeName] = @struct.Name;
            }

            // register the type map
            profile.TypeMaps.Add(map);
        }

        /// <inheritdoc />
        public void WriteConstants(Profile profile, IEnumerable<Constant> constants, ProfileConverterOptions opts)
        {
            profile.Constants.AddRange(constants.Where(x => profile.Constants.All(y => y.Name != x.Name)));
        }

        /// <summary>
        /// Trims the API prefix from the function names.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The converter options.</param>
        /// <returns>The trimmed name.</returns>
        public string TrimName(string name, ProfileConverterOptions opts)
        {
            if (name.StartsWith($"{opts.Prefix.ToUpper()}_"))
            {
                return name.Remove(0, opts.Prefix.Length + 1);
            }

            return name.StartsWith(opts.Prefix) ? name.Remove(0, opts.Prefix.Length) : name;
        }

        private static string FormatCategory(string rawCategory)
        {
            return rawCategory.Split('_').FirstOrDefault();
        }
    }
}
