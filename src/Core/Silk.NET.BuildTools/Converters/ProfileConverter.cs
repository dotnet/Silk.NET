// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
            Console.WriteLine("Reading enums...");
            var enums = reader.ReadEnums(obj, task).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Reading functions...");
            var functions = reader.ReadFunctions(obj, task).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Reading structs...");
            var structs = reader.ReadStructs(obj, task).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Reading constants...");
            var constants = reader.ReadConstants(obj, task).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Creating profiles...");
            var profiles = enums.Select(x => (x.ProfileName, x.ProfileVersion))
                .Concat(functions.Select(x => (x.ProfileName, x.ProfileVersion)))
                .Concat(structs.Select(x => (x.ProfileName, x.ProfileVersion)))
                .Distinct()
                .Select(x => CreateBlankProfile(x.ProfileName, x.ProfileVersion));

            foreach (var profile in profiles)
            {
                ctor.WriteEnums(profile, enums, task);
                ctor.WriteFunctions(profile, functions, task);
                ctor.WriteStructs(profile, structs, task);
                ctor.WriteConstants(profile, constants, task);
                foreach (var typeMap in task.TypeMaps)
                {
                    TypeMapper.Map
                    (
                        typeMap,
                        profile.Projects.Values.SelectMany(x => x.Classes.SelectMany(y => y.NativeApis.Values))
                            .SelectMany(x => x.Functions)
                    );
                }

                foreach (var typeMap in task.TypeMaps)
                {
                    TypeMapper.Map(typeMap, structs);
                }

                foreach (var kvp in profile.Projects)
                {
                    foreach (var @class in kvp.Value.Classes)
                    {
                        foreach (var constant in @class.Constants)
                        {
                            constant.Type = TypeMapper.MapOne(task.TypeMaps, constant.Type);
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
