// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Converters.Constructors;
using Silk.NET.BuildTools.Converters.Readers;

namespace Silk.NET.BuildTools.Converters
{
    public static class ProfileConverter
    {
        public static IEnumerable<Profile> ReadProfiles
            (IReader reader, IConstructor ctor, Stream input, BindTask task)
        {
            var obj = reader.Load(input);
            Console.WriteLine("Reading typedefs...");
            var typedefs = reader.ReadTypedefs(obj, task).ToList();
            Console.WriteLine("Reading enums...");
            var enums = reader.ReadEnums(obj, task)
                .OrderBy(x => x.Name)
                .Where(x => task.ExcludedNativeNames is null || !task.ExcludedNativeNames.Contains(x.NativeName))
                .ToArray();
            Console.WriteLine("Reading functions...");
            var functions = reader.ReadFunctions(obj, task)
                .OrderBy(x => x.Name)
                .Where(x => task.ExcludedNativeNames is null || !task.ExcludedNativeNames.Contains(x.NativeName))
                .ToArray();
            Console.WriteLine("Reading structs...");
            var structs = reader.ReadStructs(obj, task)
                .OrderBy(x => x.Name)
                .Where(x => task.ExcludedNativeNames is null || !task.ExcludedNativeNames.Contains(x.NativeName))
                .ToArray();
            Console.WriteLine("Reading constants...");
            var constants = reader.ReadConstants(obj, task)
                .OrderBy(x => x.Name)
                .Where(x => task.ExcludedNativeNames is null || !task.ExcludedNativeNames.Contains(x.NativeName))
                .ToArray();
            Console.WriteLine("Creating profiles...");
            var profiles = enums.Select(x => (x.ProfileName, x.ProfileVersion))
                .Concat(functions.Select(x => (x.ProfileName, x.ProfileVersion)))
                .Concat(structs.Select(x => (x.ProfileName, x.ProfileVersion)))
                .Distinct()
                .Select(x => CreateBlankProfile(x.ProfileName, x.ProfileVersion));

            task.TypeMaps = new List<Dictionary<string, string>>
            {
                TypeMapper.MergeMaps
                (
                    task.TypeMaps.Where
                    (
                        x => x.TryGetValue("$typemapPrecedesInjections", out var precede) &&
                             precede.ToLower() == "true"
                    )
                    .ToList()
                ),
                TypeMapper.MergeMaps
                (
                    task.TypeMaps.Where
                    (
                        x => !x.TryGetValue("$typemapPrecedesInjections", out var precede) ||
                             precede.ToLower() != "true"
                    )
                    .ToList()
                )
            };

            foreach (var profile in profiles)
            {
                var mapNative = task.Controls.Contains("typemap-native");
                var maps = Enumerable.Repeat(task.TypeMaps[0], 1)
                    .Concat
                    (
                        typedefs
                            .Where(x => x.ProfileName is null || x.ProfileName == profile.Name)
                            .Select(x => x.Typemap)
                    )
                    .Concat(Enumerable.Repeat(task.TypeMaps[1], 1))
                    .ToList();

                ctor.WriteFunctions(profile, functions, task);
                ctor.WriteEnums(profile, enums, task);
                ctor.WriteStructs(profile, structs, task);
                ctor.WriteConstants(profile, constants, task);
                foreach (var typeMap in maps)
                {
                    TypeMapper.Map
                    (
                        typeMap,
                        profile.Projects.Values.SelectMany(x => x.Classes.SelectMany(y => y.NativeApis.Values))
                            .SelectMany(x => x.Functions), mapNative
                    );
                }

                foreach (var typeMap in maps)
                {
                    TypeMapper.Map(typeMap, structs, mapNative);
                }

                foreach (var kvp in profile.Projects)
                {
                    foreach (var @class in kvp.Value.Classes)
                    {
                        foreach (var constant in @class.Constants)
                        {
                            constant.Type = TypeMapper.MapOne(maps, constant.Type, mapNative, constant.Name);
                        }
                    }
                }

                Console.WriteLine($"Created profile \"{profile.Name}\" version {profile.Version}");

                yield return profile;
            }
        }

        private static Profile CreateBlankProfile(string name, Version version)
        {
            return new Profile
            {
                Name = name,
                Version = version?.ToString(2)
            };
        }
    }
}
