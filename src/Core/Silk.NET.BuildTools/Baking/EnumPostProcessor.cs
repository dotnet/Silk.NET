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
    /// <summary>
    /// The trimming method. New trimming methods need to be added to the bottom so they have a higher number and thus
    /// more preference when adding obsolete attributes.
    /// </summary>
    public enum NameMethod
    {
        Version217,
        Version218
    }

    public static readonly string[] NameMethodObsoleteControls =
    {
        "no-pre-2.17-obsolete-enums",
        "no-pre-2.18-obsolete-enums"
    };

    private static readonly HashSet<string> _forbiddenTrimmings = new() { "unsigned", "per" };

    public static void Process(Profile profile, BindTask task)
    {
        AddFlagsAttribute(profile);
        StripCommonPrefix(profile, task, NameMethod.Version218);
        StripCommonPrefix(profile, task, NameMethod.Version217);
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

    private static void StripCommonPrefix(Profile profile, BindTask task, NameMethod method)
    {
        if (profile.Name == "OpenCL")
        {
            // done at the convert/construct level
            return;
        }

        if (task.Controls.Max(x => Array.IndexOf(NameMethodObsoleteControls, x)) > (int) method)
        {
            // This check passing means that there is a control descriptor that prevents generation of obsolete enums
            // from older trimming methods. i.e. if no-pre-2.18-obsolete-enums is present, don't try generating enums
            // that will be obsoleted by the newer naming method. The reason that this is > and not >= is because if
            // we're using the 2.18 naming method and we've asked for no pre-2.18 obsolete enums, we still need to
            // generate the 2.18 trimmings to know what to exclude/obsolete, whereas this initial check determines
            // whether we can skip the older naming method outright.
            return;
        }
        
        // VERY IMPORTANT: Only apply this logic to the LAST name trimming method, otherwise when the last one rolls
        // around we'll have nothing left to trim.
        var noObsoleteEnums = task.Controls.Contains(NameMethodObsoleteControls[(int) method]);

        foreach (var @enum in profile.Projects.Values.SelectMany(x => x.Enums))
        {
            // If the enum has no tokens, 
            if (@enum.Tokens.Count == 0)
            {
                // skip it
                continue;
            }

            string enumTrimmingName;
            if (method == NameMethod.Version217)
            {
                foreach (var tok in @enum.Tokens)
                {
                    tok.TrimmingName = tok.NativeName;
                }
                
                enumTrimmingName = @enum.NativeName;
                if (!enumTrimmingName.Contains('_'))
                {
                    enumTrimmingName = enumTrimmingName.Underscore();
                }
            }
            else
            {
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

                enumTrimmingName = @enum.NativeName.LenientUnderscore();
            }

            var prefix = @enum.Tokens.Count(y => y.TrimmingMethod is null) == 1
                ? Utilities.FindCommonPrefix
                    (new List<string> { @enum.Tokens[0].TrimmingName, enumTrimmingName }, true, false)
                : Utilities.FindCommonPrefix(@enum.Tokens.Select(x => x.TrimmingName).ToList(), false, false);

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

            // Iterate through all of the forbidden trimmings,
            foreach (var word in _forbiddenTrimmings)
            {
                // If the prefix starts with a forbidden trimming,
                if (prefix.StartsWith($"{word}_"))
                {
                    // Clear the prefix
                    prefix = string.Empty;
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
            }

            //If we have found a prefix
            if (prefix.Length > 0)
            {
                // Generate the new trimmings from the untrimmed enums.
                var newEnums = @enum.Tokens.Where(x => x.TrimmingMethod is null).Select
                (
                    x =>
                    {
                        var newName = Naming.Translate(x.TrimmingName[prefix.Length..], task.FunctionPrefix);

                        // If the trimmed name is the same as the original name, don't generate a new token for it.
                        // HOWEVER, if we're not going to include the original tokens, then we do actually need to
                        // generate it.
                        if (newName == x.Name && !noObsoleteEnums)
                        {
                            return null;
                        }

                        // Clone the attribute list so adding an obsolete attribute to the original doesn't affect the
                        // new token. We do however want to keep the non-name related obsolete attributes if any.
                        var attrs = x.Attributes.Where
                        (
                            y => y is not { Name: "Obsolete" or "System.Obsolete", Origin: nameof(StripCommonPrefix) }
                        ).ToList();
                        
                        // Create the return token.
                        var ret = new Token
                        {
                            Attributes = attrs,
                            Doc = x.Doc,
                            Name = newName,
                            NativeName = x.NativeName,
                            Value = x.Value,
                            TrimmingMethod = method
                        };

                        var obsoleteForNonNameReasons = x.Attributes.Any
                        (
                            y => y is { Name: "Obsolete" or "System.Obsolete", Origin: not nameof(StripCommonPrefix) }
                        );

                        if (obsoleteForNonNameReasons)
                        {
                            // Just return now and don't do any obsolete attribute processing - all variants of this
                            // token will be obsolete for the same non-trimming-related reason.
                            return ret;
                        }

                        // Get the token that is "preferred" to this one i.e. it was trimmed using a better name method
                        var preferredToken = @enum.Tokens.FirstOrDefault
                        (
                            y => y.NativeName == x.NativeName && y.TrimmingMethod is not null &&
                                 (int) y.TrimmingMethod.Value > (int) method
                        );
                        
                        // Get any tokens that this one defers i.e. trimmed using a worse name method.
                        var deferredTokens = @enum.Tokens.Where
                        (
                            y => y.NativeName == x.NativeName && y.TrimmingMethod is not null &&
                                 (int) y.TrimmingMethod.Value < (int) method
                        ).Concat(x);

                        // Mark this new token as deferred so it gets an obsolete attribute too.
                        if (preferredToken is not null)
                        {
                            deferredTokens = deferredTokens.Concat(ret);
                        }

                        var obsoleteAttr = new Attribute
                        {
                            Name = "Obsolete",
                            Arguments = new List<string>
                            {
                                $"\"Deprecated in favour of \\\"{preferredToken?.Name ?? newName}\\\"\""
                            },
                            Origin = nameof(StripCommonPrefix)
                        };

                        foreach (var deferred in deferredTokens)
                        {
                            var existingObsolete = deferred.Attributes
                                .FirstOrDefault(y => y.Name is "Obsolete" or "System.Obsolete");
                            if (existingObsolete is { Origin: nameof(StripCommonPrefix) })
                            {
                                // Remove the old obsolete attribute, as there's a new token it's superseded by.
                                deferred.Attributes.Remove(existingObsolete);
                            }
                            else if (existingObsolete is not null)
                            {
                                // Skip tokens that have been obsoleted for non-trimming-related reasons.
                                continue;
                            }

                            if (deferred.Name != (preferredToken?.Name ?? newName))
                            {
                                deferred.Attributes.Add(obsoleteAttr);
                            }
                        }

                        // Finally return the token.
                        return ret;
                    }
                )
                .Where(x => x is not null)
                .ToList();

                @enum.Tokens.RemoveAll(x => newEnums.Any(y => y.Name == x.Name));
                if (noObsoleteEnums)
                {
                    @enum.Tokens.RemoveAll
                    (
                        x => x.TrimmingMethod is null || (int) x.TrimmingMethod.Value <= (int) method
                    );
                }

                @enum.Tokens.AddRange(newEnums);
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
