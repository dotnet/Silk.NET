// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Linq;
using System.Text.RegularExpressions;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Trimmers
{
    /// <inheritdoc cref="ITrimmer{TTrimmable}" />
    /// <summary>
    /// Trims OpenGL data type endings from function names.
    /// </summary>
    public class DataTypeNameTrimmer : ITrimmer<Function>, ITrimmer<string>
    {
        /// <summary>
        /// This regex matches against known OpenGL function endings, picking them out from function names.
        /// It is comprised of two parts - the main matching set (here, the main capturing group), and a negative
        /// lookbehind workaround for difficult-to-match names. The primary set matches the actual function ending,
        /// while the lookbehind asserts that the ending match will not overreach into the end of a word.
        /// </summary>
        private static readonly Regex Endings = new Regex
        (
            @"(?<!xe)([fd]v?|u?[isb](64)?v?|v|i_v|fi)$",
            RegexOptions.Compiled
        );

        /// <summary>
        /// This regex acts like a whitelist for endings that could have been matched in some way by the main
        /// expression, but should be exempt from trimming altogether.
        /// </summary>
        private static readonly Regex EndingsNotToTrim = new Regex
        (
            "(sh|ib|[tdrey]s|[eE]n[vd]|bled" +
            "|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag" +
            "|Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through" +
            "|Uniforms|Varyings|Weight|Width|Bias|Id|Fixed|Pass|Address|Configs" +
            "|Thread|Subpass|Deferred)$",
            RegexOptions.Compiled
        );

        /// <inheritdoc />
        public bool IsRelevant(Function trimmable)
        {
            if (!trimmable.Parameters.Any())
            {
                return false;
            }

            return IsRelevant(trimmable.Name);
        }

        /// <inheritdoc />
        public Function Trim(Function trimmable, string prefix)
        {
            trimmable.Name = Trim(trimmable.NativeName, prefix).CheckMemberName(prefix);
            return trimmable;
        }

        /// <inheritdoc />
        public bool IsRelevant(string trimmable)
        {
            if (EndingsNotToTrim.IsMatch(trimmable))
            {
                return false;
            }

            if (!Endings.IsMatch(trimmable))
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        public string Trim(string name, string _)
        {
            var match = Endings.Match(name);
            return name.Remove(match.Index);
        }
    }
}
