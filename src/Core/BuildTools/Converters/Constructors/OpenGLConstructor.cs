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
    /// An API constructor for OpenGL.
    /// </summary>
    public class OpenGLConstructor : IConstructor
    {
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
                                Namespace = $".{category.CheckMemberName(task.ConverterOpts.FunctionPrefix)}",
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
                                        $"I{Naming.Translate(TrimName(rawCategory, task), task.ConverterOpts.FunctionPrefix).CheckMemberName(task.ConverterOpts.FunctionPrefix)}"
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

            var mergedEnums = new Dictionary<string, Enum>();
            var gl = profile.Projects["Core"].Classes[0].ClassName.ToUpper().CheckMemberName(task.ConverterOpts.FunctionPrefix);
            mergedEnums.Add
            (
                $"{gl}Enum",
                new Enum
                {
                    Name = $"{gl}Enum", ExtensionName = "Core", Attributes = new List<Attribute>(),
                    Tokens = new List<Token>(), NativeName = "GLenum",
                }
            );
            
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
                                Name = prefix.CheckMemberName(task.ConverterOpts.FunctionPrefix), ExtensionName = prefix,
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
                            IsRoot = @enum.ExtensionName == "Core",
                            Namespace = @enum.ExtensionName == "Core"
                                ? string.Empty
                                : $".{@enum.ExtensionName.CheckMemberName(task.ConverterOpts.FunctionPrefix)}",
                            Classes = new List<Class>{new Class{ClassName = task.ConverterOpts.ClassName}}
                        }
                    );
                }

                profile.Projects[@enum.ExtensionName].Enums.Add(@enum);
            }
        }

        /// <inheritdoc />
        public void WriteStructs(Profile profile, IEnumerable<Struct> structs, BindTask task)
        {
            // do nothing
        }

        /// <inheritdoc />
        public void WriteConstants(Profile profile, IEnumerable<Constant> constants, BindTask task)
        {
            // do nothing
        }

        /// <summary>
        /// Trims the API prefix from the function names.
        /// </summary>
        /// <param name="name">The name to trim.</param>
        /// <param name="opts">The converter options.</param>
        /// <returns>The trimmed name.</returns>
        public string TrimName(string name, BindTask task)
        {
            if (name.StartsWith($"{task.ConverterOpts.FunctionPrefix.ToUpper()}_"))
            {
                return name.Remove(0, task.ConverterOpts.FunctionPrefix.Length + 1);
            }

            return name.StartsWith
                (task.ConverterOpts.FunctionPrefix)
                ? name.Remove(0, task.ConverterOpts.FunctionPrefix.Length)
                : name;
        }
        
        private static string FormatCategory(string rawCategory)
        {
            return rawCategory.Split('_').FirstOrDefault();
        }
    }
}
