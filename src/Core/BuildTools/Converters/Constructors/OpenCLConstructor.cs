// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.Constructors
{
    public class OpenCLConstructor : IConstructor
    {
        /// <summary>
        /// Writes a collection of enums to their appropriate projects.
        /// </summary>
        /// <param name="profile">The profile to write the projects to.</param>
        /// <param name="enums">The enums to write.</param>
        public void WriteEnums(Profile profile, IEnumerable<Enum> enums, ProfileConverterOptions opts)
        {
            var mergedEnums = new Dictionary<string, Enum>();
            var gl = profile.ClassName.ToUpper().CheckMemberName(opts.Prefix);
            mergedEnums.Add
            (
                $"{gl}Enum",
                new Enum
                {
                    Name = $"{gl}Enum", ExtensionName = "Core", Attributes = new List<Attribute>(),
                    Tokens = new List<Token>(), NativeName = "GLenum",
                }
            );

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
            
            // first, we need to categorise the enums into "Core", or their vendor (i.e. "NV", "SGI", "KHR" etc)
            foreach (var @enum in enums)
            {
                if (@enum.ProfileName != profile.Name || @enum.ProfileVersion?.ToString(2) != profile.Version)
                {
                    continue;
                }
                
                if (@enum.ExtensionName == "Core")
                {
                    mergedEnums[$"{gl}Enum"].Tokens.AddRange(@enum.Tokens);
                }
                else if (@enum.ExtensionName == "Core (Grouped)")
                {
                    @enum.ExtensionName = "Core";
                    profile.Projects["Core"].Enums.Add(@enum);
                }
                else
                {
                    var prefix = FormatCategory(@enum.ExtensionName);
                    if (!mergedEnums.ContainsKey(prefix))
                    {
                        mergedEnums.Add
                        (
                            prefix,
                            new Enum
                            {
                                Name = prefix.CheckMemberName(opts.Prefix), ExtensionName = prefix,
                                NativeName = "GLenum"
                            }
                        );
                    }
                    mergedEnums[prefix].Tokens.AddRange(@enum.Tokens);
                }
            }
            
            // now that we've categorised them, lets add them into their appropriate projects.
            foreach (var (_, @enum) in mergedEnums)
            {
                if (!profile.Projects.ContainsKey(@enum.ExtensionName))
                {
                    profile.Projects.Add
                    (
                        @enum.ExtensionName,
                        new Project
                        {
                            CategoryName = @enum.ExtensionName, ExtensionName = @enum.ExtensionName, IsRoot = @enum.ExtensionName == "Core",
                            Namespace = @enum.ExtensionName == "Core"
                                ? string.Empty
                                : $".{@enum.ExtensionName.CheckMemberName(opts.Prefix)}"
                        }
                    );
                }

                profile.Projects[@enum.ExtensionName].Enums.Add(@enum);
            }
        }

        /// <summary>
        /// Writes a collection of functions to their appropriate projects.
        /// </summary>
        /// <param name="profile">The profile to write the projects to.</param>
        /// <param name="functions">The functions to write.</param>
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
                                CategoryName = category, ExtensionName = category, IsRoot = false,
                                Namespace = $".{category.CheckMemberName(opts.Prefix)}"
                            }
                        );
                    }

                    // check that the interface exists
                    if
                    (
                        !profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Interfaces.ContainsKey(rawCategory)
                    )
                    {
                        profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Interfaces.Add
                            (
                                rawCategory,
                                new Interface
                                {
                                    Name =
                                        $"I{Naming.Translate(TrimName(rawCategory, opts), opts.Prefix).CheckMemberName(opts.Prefix)}"
                                }
                            );
                    }

                    // add the function to the interface
                    profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                        .Interfaces[rawCategory]
                        .Functions.Add(function);

                    if (TryCreateEnumVariant(function, out var variant, profile.Projects["Core"]))
                    {
                        profile.Projects[function.ExtensionName == "Core" ? "Core" : category]
                            .Interfaces[rawCategory]
                            .Functions.Add(variant);
                    }
                }
            }
        }

        private bool TryCreateEnumVariant(Function function, out Function variant, Project core)
        {
            var varied = false;
            var newParameters = new List<Parameter>();
            var paramsMod = false;
            Type newReturnType = function.ReturnType;
            foreach (var functionParameter in function.Parameters)
            {
                if (functionParameter.Type.OriginalGroup is null || core.Enums.All
                        (x => x.Name != functionParameter.Type.OriginalGroup))
                {
                    newParameters.Add(functionParameter);
                    continue;
                }

                paramsMod = true;
                varied = true;
                var t =
                    new TypeSignatureBuilder(functionParameter.Type).WithName
                            (functionParameter.Type.OriginalGroup)
                        .Build();
                t.OriginalName = t.Name; // stop GLenum mapping
                newParameters.Add
                (
                    new ParameterSignatureBuilder(functionParameter).WithType
                    (
                        t
                    ).Build()
                );
            }

            if (!(function.ReturnType.OriginalGroup is null || core.Enums.All
                    (x => x.Name != function.ReturnType.OriginalGroup)))
            {
                varied = true;
                newReturnType = new TypeSignatureBuilder(function.ReturnType).WithName
                        (function.ReturnType.OriginalGroup)
                    .Build();
                newReturnType.OriginalName = newReturnType.Name;
            }

            variant = new FunctionSignatureBuilder(function).WithParameters(newParameters)
                .WithName(paramsMod ? function.Name : function.Name + "G")
                .WithReturnType(newReturnType)
                .Build();
            return varied;
        }

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
        
        public void WriteStructs(Profile profile, IEnumerable<Struct> structs, ProfileConverterOptions opts)
        {
            profile.Projects["Core"].Structs.AddRange(structs);
        }

        public void WriteConstants(Profile profile, IEnumerable<Constant> constants, ProfileConverterOptions opts)
        {
            profile.Constants.AddRange(constants);
        }
    }
}
