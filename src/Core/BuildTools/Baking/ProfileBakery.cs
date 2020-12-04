// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using MoreLinq.Extensions;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;

namespace Silk.NET.BuildTools.Baking
{
    /// <summary>
    /// A collection of methods for baking/fusing APIs together.
    /// </summary>
    public static class ProfileBakery
    {
        /// <summary>
        /// Bake the given options.
        /// </summary>
        /// <param name="cliOptions">The options to bake.</param>
        public static void Bake(BakeryOptions cliOptions)
        {
            Console.WriteLine("Baking raw profiles...");
            Bake
            (
                cliOptions.BakeryInformation
                    .Select(File.ReadAllText)
                    .SelectMany(JsonConvert.DeserializeObject<ProfileBakeryInformation[]>),
                cliOptions.Folder,
                cliOptions.PrettyPrinted,
                cliOptions.DocumentationFolder
            );
            Console.WriteLine("Finishing up...");
            if (!cliOptions.PreserveRawAPIs)
            {
                DeleteRawAPIs(cliOptions.Folder);
            }
        }

        /// <summary>
        /// Bakes APIs together given the <see cref="ProfileBakeryInformation" />, and outputs the baked
        /// profile to the given folder.
        /// </summary>
        /// <param name="information">The information of what APIs to bake.</param>
        /// <param name="folder">The output folder.</param>
        /// <param name="pretty">Whether the output JSON should be pretty-printed.</param>
        /// <param name="docs">The documentation string.</param>
        public static void Bake(ProfileBakeryInformation information, string folder, bool pretty, string docs)
        {
            // get APIs implemented
            var impl = information.Implements.Select(x => File.ReadAllText(Path.Combine(folder, $"api-{x}.json")))
                .Select(JsonConvert.DeserializeObject<Profile>)
                .ToList();

            // create the profile
            var profile = new Profile
            {
                Name = information.Name,
                Namespace = information.Namespace,
                ExtensionsNamespace = information.ExtensionsNamespace,
                OutputFolder = information.OutputFolder,
                ClassName = information.ClassName,
                SymbolLoaderName = information.SymbolLoader
            };
            profile.Projects.Add
            (
                "Core",
                new Project
                {
                    CategoryName = "Core", ExtensionName = "Core", Namespace = string.Empty, IsRoot = true
                }
            );

            // bake in the implemented interfaces, enums, and extension projects
            var extProjects = impl.SelectMany(x => x.Projects.Where(y => y.Key != "Core"));
            var coreProjects = impl.Select(x => x.Projects["Core"]).ToList();
            var coreFunc = coreProjects.SelectMany(x => x.Interfaces);
            var coreEnums = coreProjects.SelectMany(x => x.Enums);
            var coreStructs = coreProjects.SelectMany(x => x.Structs);
            profile.Projects["Core"].Interfaces = profile.Projects["Core"].Interfaces.Concat(coreFunc).ToDictionary();
            profile.Projects["Core"].Enums.AddRange(coreEnums);
            profile.Projects["Core"].Structs.AddRange(coreStructs);
            profile.Projects = profile.Projects.Concat(extProjects).ToDictionary();
            profile.FunctionPrefix = information.FunctionPrefix;
            profile.Names = information.NameContainer;
            profile.Constants = impl.SelectMany(x => x.Constants).ToList();

            MergeAll(profile); // note: the key of the Interfaces dictionary is changed here, so don't rely on it herein
            Vary(profile);
            CheckForDuplicates(profile);
            TypeMapper.MapEnums(profile); // we need to map the enums to make sure they are correct for their extension.

            // bake in the documentation
            if (!string.IsNullOrWhiteSpace(docs))
            {
                DocumentationWriter.Write(profile, docs);
            }

            // save this to disk
            File.WriteAllText
            (
                Path.Combine(folder, $"{information.Name}.json"),
                JsonConvert.SerializeObject(profile, pretty ? Formatting.Indented : Formatting.None)
            );

            Console.WriteLine($"Created profile \"{information.Name}\".");
        }

        private static void Vary(Profile profile)
        {
            foreach (var project in profile.Projects.Values)
            {
                foreach (var @interface in project.Interfaces.Values)
                {
                    @interface.Functions.AddRange
                        (Overloader.GetEarlyVariants(@interface.Functions, profile.Projects["Core"]));
                    @interface.Functions = Overloader.GetWithVariants
                            (@interface.Functions, profile.Projects["Core"])
                        .ToList();
                }
            }
        }

        private static void MergeAll(Profile profile) // this method could also be called Stir ;)
        {
            foreach (var project in profile.Projects.Values)
            {
                var enums = new Dictionary<string, Enum>();
                var interfaces = new Dictionary<string, Interface>();
                var structs = new Dictionary<string, Struct>();
                foreach (var enumeration in project.Enums)
                {
                    if (enums.ContainsKey(enumeration.Name))
                    {
                        enums[enumeration.Name].Tokens.AddRange(enumeration.Tokens);
                    }
                    else
                    {
                        enums.Add(enumeration.Name, enumeration);
                    }
                }

                foreach (var (key, @interface) in project.Interfaces)
                {
                    if (interfaces.ContainsKey(key))
                    {
                        foreach (var function in @interface.Functions)
                        {
                            if (interfaces[key].Functions.Any(x => x.Equals(function)))
                            {
                                continue;
                            }

                            interfaces[key].Functions.Add(function);
                        }
                    }
                    else
                    {
                        interfaces.Add(key, @interface);
                    }
                }

                foreach (var @struct in project.Structs)
                {
                    if (structs.ContainsKey(@struct.Name))
                    {
                        if (structs[@struct.Name].NativeName != @struct.NativeName)
                        {
                            Console.WriteLine
                            (
                                $"Warning: Discarding duplicate struct \"{@struct.Name}\" (Original was \"{@struct.NativeName}\", {structs[@struct.Name].NativeName} currently present)"
                            );
                        }
                    }
                    else
                    {
                        structs.Add(@struct.Name, @struct);
                    }
                }

                project.Enums = enums.Values.ToList();
                project.Interfaces = interfaces;
                project.Structs = structs.Values.ToList();
            }

            var constants = new Dictionary<string, Constant>();
            foreach (var constant in profile.Constants)
            {
                if (constants.ContainsKey(constant.Name))
                {
                    if (constants[constant.Name].NativeName != constant.NativeName || constants[constant.Name].Value != constant.Value)
                    {
                        Console.WriteLine($"Warning: Discarding duplicate constant {constant.Name}.");
                        Console.WriteLine($"    Original: {constants[constant.Name].NativeName} = {constants[constant.Name].Value}");
                        Console.WriteLine($"    Duplicate: {constant.NativeName} = {constant.Value}");
                    }
                }
                else
                {
                    constants.Add(constant.Name, constant);
                }
            }

            profile.Constants = constants.Values.ToList();
        }

        private static void CheckForDuplicates(Profile profile)
        {
            foreach (var project in profile.Projects)
            {
                foreach (var @interface in project.Value.Interfaces)
                {
                    var functions = new List<Function>();
                    foreach (var f in @interface.Value.Functions)
                    {
                        if (functions.Any(x => x.Equals(f))) continue;
                        functions.Add(f);
                    }

                    @interface.Value.Functions = functions;
                }

                foreach (var @enum in project.Value.Enums)
                {
                    var tokens = new List<Token>();
                    foreach (var token in @enum.Tokens)
                    {
                        var existingToken = tokens.FirstOrDefault(x => x.Name == token.Name);
                        if (!(existingToken is null))
                        {
                            if (existingToken.Value != token.Value)
                            {
                                Debug.WriteLine("Warning: Two tokens with the same name but different values.");
                                Debug.WriteLine($"    {existingToken.Name} = {existingToken.Value}");
                                Debug.WriteLine($"    {token.Name} = {token.Value}");
                                Debug.WriteLine($"{existingToken.Value} will be used.");
                            }

                            continue;
                        }

                        tokens.Add(token);
                    }

                    @enum.Tokens = tokens;
                }
            }
        }

        /// <summary>
        /// Deletes all of the unbaked/raw APIs in a folder.
        /// </summary>
        /// <param name="folder">The folder to search and destroy APIs in.</param>
        // For some reason, ReSharper thinks that this is "Ap Is", not "APIs", so it won't
        // accept "API" being in the abbreviation dictionary.
        // ReSharper disable once InconsistentNaming
        public static void DeleteRawAPIs(string folder)
        {
            foreach (var file in Directory.GetFiles
                    (folder)
                .Where(x => Path.GetFileName(x).StartsWith("api-") && x.EndsWith(".json")))
            {
                File.Delete(file);
            }
        }

        /// <summary>
        /// Bakes multiple sets of APIs together, and outputs them to the given folder.
        /// </summary>
        /// <param name="information">The information for the sets of APIs.</param>
        /// <param name="folder">The output folder.</param>
        /// <param name="pretty">Whether the output JSON should be pretty-printed.</param>
        /// <param name="d">The documentation string.</param>
        public static void Bake(IEnumerable<ProfileBakeryInformation> information, string folder, bool pretty, string d)
        {
            information.ForEach(b => Bake(b, folder, pretty, d));
        }
    }
}
