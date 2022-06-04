// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Constructors
{
    /// <summary>
    /// An API constructor for OpenCL.
    /// </summary>
    public class OpenCLConstructor : IConstructor
    {
        internal const string UngroupedDeprecationMessage = "\"The \\\"ungrouped\\\" enums ({0}) are deprecated in " +
                                                            "favour of the \\\"grouped\\\" enums ({1}). Not only is " +
                                                            "this akin to how the original specification represents " +
                                                            "enums, it also ensures that the size of the enum is " +
                                                            "correct which is a guarantee the \\\"ungrouped\\\" " +
                                                            "enums do not provide. As such, we have made every "+
                                                            "attempt to prevent functions known to use these "+
                                                            "ungrouped enums problematically from compiling; but "+
                                                            "regardless of whether usage of these deprecated enums "+
                                                            "compiles please use the other enums to ensure that all "+
                                                            "functions will work as intended. \"";
        
        /// <inheritdoc />
        public void WriteFunctions(Profile profile, IEnumerable<Function> functions, BindTask task)
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
                    // check that the root project exists
                    if (!profile.Projects.ContainsKey("Core"))
                    {
                        profile.Projects.Add
                        (
                            "Core",
                            new Project
                            {
                                IsRoot = true,
                                Namespace = string.Empty,
                                Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
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
                                IsRoot = false,
                                Namespace = $".{category.CheckMemberName(task.FunctionPrefix)}",
                                Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                            }
                        );
                    }

                    // check that the interface exists
                    if
                    (
                        !profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Classes[0].NativeApis.ContainsKey(rawCategory)
                    )
                    {
                        profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Classes[0].NativeApis.Add
                            (
                                rawCategory,
                                new NativeApiSet
                                {
                                    Name =
                                        $"I{Naming.Translate(TrimName(rawCategory, task), task.FunctionPrefix).CheckMemberName(task.FunctionPrefix)}"
                                }
                            );
                    }

                    // add the function to the interface
                    profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                        .Classes[0].NativeApis[rawCategory]
                        .Functions.Add(function);
                }
            }
        }
        
        /// <inheritdoc />
        public void WriteEnums(Profile profile, IEnumerable<Enum> enums, BindTask task)
        {
            if (!profile.Projects.ContainsKey("Core"))
            {
                profile.Projects.Add
                (
                    "Core",
                    new Project
                    {
                        IsRoot = true,
                        Namespace = string.Empty,
                        Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                    }
                );
            }

            
            // BACKWARDS COMPATIBILITY LOGIC: Why is this its own specialized logic? Because originally I was going to
            // go the "break everything" route and eradicate CLEnum entirely, but then I realised that'd be pretty
            // irresponsible for a minor release despite us being technically wrong. For the trivial cases, we can just
            // make a shim. So here we write a deprecated CLEnum, and the OpenCLBackwardsCompatibilityOverloader will
            // generate deprecated overloads using that CLEnum. Anyways I deleted all the code before reaching that
            // conclusion so it's possible I've just rewritten the code that was already here that does the same thing.
            void WriteBackCompatEnum(string prefix, IEnumerable<Token> tokens)
            {
                var name = prefix == "Core" ? "CLEnum" : prefix;
                var @enum = profile.Projects[prefix].Enums.FirstOrDefault(x => x.Name == name);
                if (@enum is null)
                {
                    @enum = new Enum
                    {
                        Attributes = new List<Attribute>
                        {
                            new()
                            {
                                Name = "Obsolete",
                                Arguments = new List<string>
                                {
                                    string.Format
                                    (
                                        UngroupedDeprecationMessage,
                                        "CLEnum, KHR, etc...",
                                        "ErrorCodes, DeviceType, etc..."
                                    )
                                }
                            }
                        },
                        ExtensionName = prefix,
                        Name = name,
                        NativeName = "CLenum"
                    };

                    profile.Projects[prefix].Enums.Add(@enum);
                }

                @enum.Tokens.AddRange
                (
                    tokens.SelectMany
                    (
                        x => Enumerable.Repeat(x, 1)
                            .Concat
                            (
                                // BACKWARDS COMPATIBILITY NOTE: The names were made more friendly in 2.16 at the
                                // reader-level. This is great, but if we want to minimize breakage we should bring back
                                // the original name (if different).
                                Enumerable.Repeat
                                (
                                    new Token
                                    {
                                        Name = Naming.Translate(TrimName(x.NativeName, task), task.FunctionPrefix),
                                        Attributes = x.Attributes, Doc = x.Doc, Value = x.Value,
                                        NativeName = x.NativeName
                                    }, 1
                                )
                            )
                            .DistinctBy(y => y.Name)
                    )
                );

            }

            void CheckPrefix(string prefix)
            {
                if (!profile.Projects.ContainsKey(prefix))
                {
                    profile.Projects.Add
                    (
                        prefix,
                        new Project
                        {
                            IsRoot = prefix == "Core",
                            Namespace = prefix == "Core"
                                ? string.Empty
                                : $".{prefix.CheckMemberName(task.FunctionPrefix)}",
                            Classes = new List<Class> { new Class { ClassName = task.ConverterOpts.ClassName } }
                        }
                    );
                }
            }

            // first, we need to categorise the enums into "Core", or their vendor (i.e. "NV", "SGI", "KHR" etc)
            foreach (var @enum in enums)
            {
                if (@enum.ProfileName != profile.Name || @enum.ProfileVersion?.ToString(2) != profile.Version)
                {
                    continue;
                }

                switch (@enum.ExtensionName)
                {
                    case "Core":
                    {
                        WriteBackCompatEnum("Core", @enum.Tokens);
                        break;
                    }
                    case "Core (Grouped)":
                    {
                        @enum.ExtensionName = "Core";
                        profile.Projects["Core"].Enums.Add(@enum);
                        goto case "Core"; // write the back compat enum
                    }
                    default:
                    {
                        var prefix = FormatCategory(@enum.ExtensionName);
                        CheckPrefix(prefix);
                        if(@enum.Name == "Globals")
                        {
                            profile.Projects[prefix]
                                .Classes[0]
                                .Constants.AddRange
                                (
                                    @enum.Tokens.Select
                                    (
                                        x => new Constant
                                        {
                                            Name = x.Name, NativeName = x.NativeName,
                                            ExtensionName = @enum.ExtensionName, Type = @enum.EnumBaseType,
                                            Value = x.Value
                                        }
                                    )
                                );
                        }
                        else
                        {
                            profile.Projects[prefix].Enums.Add(@enum);
                        }

                        WriteBackCompatEnum(prefix, @enum.Tokens);
                        break;
                    }
                }
            }
            
            // BACKWARDS COMPATIBILITY NOTE: In 2.16 the enums were shuffled (for the better), and _KHR enums no longer
            // necessarily live in the KHR namespace (instead living in their strong-typed group). To minimize breakage,
            // we now go through all of strong enums and attempt to put them back into their original place. This could
            // result in the deprecated enums having more tokens than they did originally, but who cares they're not
            // meant to be used anymore anyway.
            var allSuffixes = profile.Projects
                .SelectMany(x => Enumerable.Repeat(x.Key, 1).Concat(x.Value.Enums.Select(y => y.ExtensionName)))
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Select(FormatCategory)
                .Distinct();
            foreach (var suffix in allSuffixes)
            {
                var tokens = profile.Projects.Values.SelectMany
                    (
                        x => x.Enums.SelectMany
                        (
                            y => y.Tokens.Where
                            (
                                z => suffix == "Core" && !profile.Projects.Keys.Any
                                (
                                    extSuffix => z.NativeName.EndsWith($"_{extSuffix}")
                                ) || suffix != "Core" && z.NativeName.EndsWith($"_{suffix}")
                            )
                        )
                    )
                    .ToList(); // <-- see "The Lazy Leopard and the List" at https://bit.ly/3MmLkGi;

                if (tokens.Count > 0)
                {
                    WriteBackCompatEnum(suffix, tokens);
                }
            }
        }
        
        /// <inheritdoc />
        public void WriteStructs(Profile profile, IEnumerable<Struct> structs, BindTask task)
        {
            foreach (var @struct in structs)
            {
                var prefix = FormatCategory(@struct.ExtensionName);
                profile.Projects[prefix].Structs.Add(@struct);
            }
        }

        /// <inheritdoc />
        public void WriteConstants(Profile profile, IEnumerable<Constant> constants, BindTask task)
        {
            profile.Projects["Core"].Classes[0].Constants.AddRange(constants);
        }

        /// <summary>
        /// Trims the API prefix from the function names.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The converter options.</param>
        /// <returns>The trimmed name.</returns>
        public string TrimName(string name, BindTask task)
        {
            if (name.StartsWith($"{task.FunctionPrefix.ToUpper()}_"))
            {
                return name.Remove(0, task.FunctionPrefix.Length + 1);
            }

            return name.StartsWith
                (task.FunctionPrefix)
                ? name.Remove(0, task.FunctionPrefix.Length)
                : name;
        }
        
        private static string FormatCategory(string rawCategory)
        {
            return rawCategory.Split('_').FirstOrDefault();
        }
    }
}
