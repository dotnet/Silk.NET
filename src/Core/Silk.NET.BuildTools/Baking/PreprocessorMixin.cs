// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Silk.NET.BuildTools.Common;
using Attribute = Silk.NET.BuildTools.Common.Attribute;

namespace Silk.NET.BuildTools.Baking
{
    public static class PreprocessorMixin
    {
        public static void AddDirectives(Profile profile, Dictionary<string, string[]> directives)
        {
            Console.WriteLine("Adding preprocessor directives...");
            directives ??= new Dictionary<string, string[]>();
            foreach (var kvp in profile.Projects)
            {
                foreach (var @class in kvp.Value.Classes)
                {
                    foreach (var nativeApi in @class.NativeApis)
                    {
                        foreach (var function in nativeApi.Value.Functions)
                        {
                            var matchingDirectives = directives.Where
                                (x => x.Value.Any(y => Regex.IsMatch(function.NativeName, y)));
                            string finishedDirectives = null;
                            foreach (var directive in matchingDirectives)
                            {
                                if (finishedDirectives != null)
                                {
                                    finishedDirectives += "&& ";
                                }

                                if (directive.Key.ToLower().StartsWith("$override(") && directive.Key.EndsWith(")"))
                                {
                                    var number = directive.Key.Substring(10, directive.Key.Length - 11);
                                    if (!int.TryParse(number, out var @override))
                                    {
                                        Console.WriteLine
                                        (
                                            $"Warning: Invalid override exclude: {directive.Key}. " +
                                            $"(\"{number}\" is not a valid integer)"
                                        );
                                        continue;
                                    }

                                    function.Attributes.Add(new Attribute
                                    {
                                        Name = "ExcludeFromOverride",
                                        Arguments = new List<string>{number}
                                    });
                                    
                                    continue;
                                }

                                if (directive.Key.Contains("$"))
                                {
                                    Console.WriteLine($"Warning: Invalid preprocessor directive: {directive.Key}");
                                    continue;
                                }

                                finishedDirectives += directive.Key;
                            }

                            function.PreprocessorConditions = finishedDirectives;
                        }
                    }
                }
            }
        }
    }
}
