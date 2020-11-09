// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Silk.NET.BuildTools.Common;

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
