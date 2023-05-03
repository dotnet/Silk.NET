// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Humanizer;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;

namespace Silk.NET.BuildTools.Baking;

public static class EnumPostProcessor
{
    private static readonly HashSet<string> _forbiddenTrimmings = new() { "unsigned", "per" };

    public static void Process(Profile profile, BindTask task)
    {
        AddFlagsAttribute(profile);
        StripCommonPrefix(profile, task);
        AddNoneFlags(profile);
    }

    private static void AddNoneFlags(Profile profile)
    {
        foreach (var @enum in from project in profile.Projects.Values
                 from @enum in project.Enums
                 where @enum.Attributes.Any(x => x.Name is "System.Flags" or "Flags") &&
                       !@enum.HasDefaultValue() &&
                       @enum.Tokens.All(x => x.Name is not "None")
                 select @enum)
        {
            @enum.Tokens.Insert(0, new Token { Name = "None", Value = "0" });
        }
    }

    private static void StripCommonPrefix(Profile profile, BindTask task)
    {
        if (profile.Name == "OpenCL")
        {
            // done at the convert/construct level
            return;
        }
        
        foreach (var @enum in profile.Projects.Values.SelectMany(x => x.Enums))
        {
            // If the enum has no tokens, 
            if (@enum.Tokens.Count == 0)
            {
                // skip it
                continue;
            }

            foreach (var tok in @enum.Tokens)
            {   
                //If theres a prefix override for this enum,
                if(task.PrefixOverrides.ContainsKey(@enum.NativeName)) 
                {
                    //Use the raw native name as the trimming name
                    tok.TrimmingName = tok.NativeName;
                    continue;
                }

                tok.TrimmingName = tok.NativeName.LenientUnderscore();
            }

            var enumTrimmingName = @enum.NativeName.LenientUnderscore();

            var enumTrimmingName2_17 = @enum.NativeName;
            if(!enumTrimmingName2_17.Contains('_')) 
            {
                enumTrimmingName2_17 = enumTrimmingName2_17.Underscore();
            }

            //Try to find a common prefix for the enum tokens
            var prefix = @enum.Tokens.Count == 1
                ? Utilities.FindCommonPrefix
                    (new List<string> { @enum.Tokens[0].TrimmingName, enumTrimmingName }, true, false)
                : Utilities.FindCommonPrefix(@enum.Tokens.Select(x => x.TrimmingName).ToList(), false, false);

            //Try to find a common prefix for the enum tokens, using the old pre-2.18 logic
            var prefix2_17 = @enum.Tokens.Count == 1
                ? Utilities.FindCommonPrefix
                    (new List<string> { @enum.Tokens[0].NativeName, enumTrimmingName2_17 }, true, false)
                : Utilities.FindCommonPrefix(@enum.Tokens.Select(x => x.NativeName).ToList(), false, false);

            if(@enum.NativeName == "WGPUTextureDimension") {
                Console.WriteLine($"CCCCCC: {enumTrimmingName}:{prefix}");
                Console.WriteLine($"DDDDDD: {enumTrimmingName2_17}:{prefix2_17}");
            }

            //Set the prefix to the prefix override for this enum, if it exists.
            //This is to allow us to handle poorly/inconsistently named enums, 
            //without putting special cases elsewhere in the logic
            //ex: For the enum
            //    enum Things {
            //      ThingsRGB
            //      ThingRGB
            //    }
            //If we specify a prefix override of "Thing", 
            //then it will trim ThingsRGB to sRGB and ThingRGB to RGB
            //a case like this is simple to add a special case for in the generator to handle sRGB specially, 
            //but see ImageChannelOrder from spirv.h for a more problematic occurance.
            if (task.PrefixOverrides.TryGetValue(@enum.NativeName, out string overriddenPrefix)) 
            {
                prefix = overriddenPrefix;
            }

            // If any of the token's trimming name is shorter than the prefix length,
            if (@enum.Tokens.Any(x => x.TrimmingName.Length <= prefix.Length))
            {
                // Do a second pass, but put the enum name in the loop to see if it makes a difference
                prefix = Utilities.FindCommonPrefix
                (
                    @enum.Tokens.Select(x => x.TrimmingName).Concat(enumTrimmingName).ToList(),
                    false, false
                );
            }

            // pre 2.18 logic
            // If any of the token's native name is shorter than the prefix length,
            if (@enum.Tokens.Any(x => x.NativeName.Length <= prefix2_17.Length))
            {
                // Do a second pass, but put the enum name in the loop to see if it makes a difference
                prefix2_17 = Utilities.FindCommonPrefix
                (
                    @enum.Tokens.Select(x => x.NativeName).Concat(Enumerable.Repeat(enumTrimmingName2_17, 1)).ToList(),
                    false, false
                );
            }

            if(@enum.NativeName == "WGPUTextureDimension") {
                Console.WriteLine($"EEEEEE: {enumTrimmingName}:{prefix}");
                Console.WriteLine($"FFFFFF: {enumTrimmingName2_17}:{prefix2_17}");
            }

            // Iterate through all of the forbidden trimmings,
            foreach (var word in _forbiddenTrimmings)
            {
                // If the prefix starts with a forbidden trimming,
                if (prefix.StartsWith($"{word}_"))
                {
                    // Clear the prefix
                    prefix = string.Empty;
                }

                // If the prefix starts with a forbidden trimming,
                if (prefix2_17.StartsWith($"{word}_"))
                {
                    // Clear the prefix
                    prefix2_17 = string.Empty;
                }

                // If the prefix contains the forbidden trimming surrounded by underscores,
                var idx = prefix.IndexOf($"_{word}_", StringComparison.OrdinalIgnoreCase);
                if (idx != -1)
                {
                    //Trim the end of the prefix to the start of the forbidden trimming
                    //ex:
                    //    word = GL
                    //    prefix = THIS_GL_
                    //
                    //    it makes prefix = THIS
                    prefix = prefix[..idx];
                }

                // If the prefix contains the forbidden trimming surrounded by underscores,
                idx = prefix2_17.IndexOf($"_{word}_", StringComparison.OrdinalIgnoreCase);
                if (idx != -1)
                {
                    //Trim the end of the prefix to the start of the forbidden trimming
                    //ex:
                    //    word = GL
                    //    prefix = THIS_GL_
                    //
                    //    it makes prefix = THIS
                    prefix2_17 = prefix2_17[..idx];
                }
            }

            //If we have found a prefix
            if (prefix.Length > 0 || prefix2_17.Length > 0)
            {
                //Transform the old tokens into a set of new tokens, with names using the 2.18 logic
                var newTokens = @enum.Tokens.Select
                (
                    x =>
                    {
                        var newName = Naming.Translate(x.TrimmingName[prefix.Length..], task.FunctionPrefix);

                        if(@enum.NativeName == "WGPUTextureDimension")
                        {
                            Console.WriteLine($"AAAAAAAA {prefix}:{x.TrimmingName}:{newName}");
                        }

                        var attrs = x.Attributes.ToList();

                        //Remove all existing oboslete attributes
                        x.Attributes.RemoveAll(x => x.Name is "Obsolete" or "System.Obsolete");

                        x.Attributes.Add
                        (
                            new Attribute
                            {
                                Name = "Obsolete",
                                Arguments = new List<string>
                                {
                                    $"\"Deprecated in favour of \\\"{newName}\\\"\""
                                }
                            }
                        );

                        return new Token
                        {
                            Attributes = attrs,
                            Doc = x.Doc,
                            Name = newName,
                            NativeName = x.NativeName,
                            Value = x.Value
                        };
                    }
                )
                .ToList();

                //Transform the old tokens into a set of new tokens, with names using the 2.17 logic
                var tokens2_17 = @enum.Tokens.Select
                (
                    x =>
                    {
                        var newName = Naming.Translate(x.NativeName[prefix2_17.Length..], task.FunctionPrefix);

                        if(@enum.NativeName == "WGPUTextureDimension")
                        {
                            Console.WriteLine($"BBBBBBBB {prefix2_17}:{x.NativeName}:{newName}:{task.FunctionPrefix}");
                        }

                        var attrs = x.Attributes.ToList();

                        //If the old token does not have any Obsolete attributes
                        if(!x.Attributes.Any(x => x.Name is "Obsolete" or "System.Obsolete")) 
                        {
                            x.Attributes.Add
                            (
                                new Attribute
                                {
                                    Name = "Obsolete",
                                    Arguments = new List<string>
                                    {
                                        $"\"Deprecated in favour of \\\"{newName}\\\"\""
                                    }
                                }
                            );
                        }

                        return new Token
                        {
                            Attributes = attrs,
                            Doc = x.Doc,
                            Name = newName,
                            NativeName = x.NativeName,
                            Value = x.Value
                        };
                    }
                )
                .ToList();

                //Create a copy of the "obsolete" enum tokens
                var obsoleteTokens = @enum.Tokens.ToList();
                
                //Clear the tokens list
                @enum.Tokens.Clear();

                // no-obsolete-enum disables the old obsolete enum logic, so
                // If we do not have the `no-obsolete-enum` control descriptor,
                if (!task.Controls.Contains("no-obsolete-enum"))
                {
                    //Remove any tokens 
                    obsoleteTokens.RemoveAll(x => tokens2_17.Any(y => x.Name == y.Name));

                    //Add the obsolete enums to the token list
                    @enum.Tokens.AddRange(obsoleteTokens);
                }

                // no-pre-2.18-enums disables the pre-2.18 enum prefix trimming logic, so
                // If we do not have the `no-pre-2.18-enums` control descriptor
                if (!task.Controls.Contains("no-pre-2.18-enums"))
                {
                    //Remove any tokens 
                    tokens2_17.RemoveAll(x => newTokens.Any(y => x.Name == y.Name));

                    //Add the obsolete enums to the token list
                    @enum.Tokens.AddRange(tokens2_17);
                }

                //Add the new enum tokens to the list
                @enum.Tokens.AddRange(newTokens);
            }
        }
    }

    private static void AddFlagsAttribute(Profile profile)
    {
        foreach (var @enum in from project in profile.Projects.Values
                 from @enum in project.Enums
                 where @enum.Attributes.All(x => x.Name is not "Flags" and not "System.Flags") &&
                       @enum.IsProbablyABitmask()
                 select @enum)
        {
            @enum.Attributes.Add(new Attribute { Name = "Flags" });
        }
    }
}
