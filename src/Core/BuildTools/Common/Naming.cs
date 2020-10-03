// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;
using JetBrains.Annotations;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Translates an identifier (a type name, a constant name, etc) into a .NET-style identifier.
    /// </summary>
    public static class Naming
    {
        /// <summary>
        /// Gets a regular expression that matches against isolated long acronyms (3+ capital characters).
        /// </summary>
        private static readonly Regex LongAcronymsRegex = new Regex
            ("(?<![A-Z])[A-Z]{3,}(?![A-Z])", RegexOptions.Compiled);

        /// <summary>
        /// Gets a regular expression that matches against short acronym candidates, which should still be transformed.
        /// </summary>
        private static readonly Regex ShortNonAcronymsRegex = new Regex
            ("(?<![A-Z])(IS|AS|NO|ON|TO|OP|BY|OF|IN|UP|OR)(?![A-Z])", RegexOptions.Compiled);

        /// <summary>
        /// Gets a regular expression that matches against simple data type identifiers in other identifiers.
        /// </summary>
        private static readonly Regex DataTypeIdentifersRegex = new Regex("\\dU?(F|I)", RegexOptions.Compiled);

        /// <summary>
        /// Gets a set of overrides used for name translation when dealing with complicated extensions and acronyms.
        /// </summary>
        public static readonly IReadOnlyDictionary<string, string> ExtensionAndAcronymOverrides =
            new Dictionary<string, string>
            {
                // ReSharper disable StringLiteralTypo
                {"CMAAINTEL", "CmaaIntel"},
                {"QCOM", "QCom"},
                {"SNORM", "SNorm"}
                // ReSharper restore StringLiteralTypo
            };

        /// <summary>
        /// Translates an identifier name into a C#-style PascalCase name.
        /// </summary>
        /// <param name="name">The name to translate.</param>
        /// <param name="prefix">The name prefix.</param>
        /// <returns>The translated name.</returns>
        [NotNull]
        public static string Translate([NotNull] string name, string prefix)
        {
            var builder = new StringBuilder(name);

            // ReSharper thinks the calls to Cast<Match> are redundant, but removing them changes the type of match,
            // and I don't know enough about LINQ to know how to fix it.
            // ReSharper disable RedundantEnumerableCastCall
            foreach (var match in LongAcronymsRegex.Matches(builder.ToString()).Cast<Match>())
            {
                if (!ExtensionAndAcronymOverrides.TryGetValue(match.Value, out var replacement))
                {
                    replacement = match.Value.Transform(To.LowerCase, To.TitleCase);
                }

                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, replacement);
            }

            foreach (var match in ShortNonAcronymsRegex.Matches(builder.ToString()).Cast<Match>())

            {
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, match.Value.Transform(To.LowerCase, To.TitleCase));
            }

            foreach (var match in DataTypeIdentifersRegex.Matches(builder.ToString()).Cast<Match>())
            {
                builder.Remove(match.Index, match.Length);
                builder.Insert(match.Index, match.Value.Transform(To.LowerCase, To.TitleCase));
            }
            // ReSharper restore RedundantEnumerableCastCall

            if (char.IsDigit(builder[0]))
            {
                builder.Insert(0, "C");
            }

            var newName = builder.ToString().Pascalize();
            return newName.CheckMemberName(prefix);
        }

        /// <summary>
        /// Translates an identifier name into a C#-style PascalCase name. Omits the use of LINQ from <see cref="Translate"/>.
        /// <seealso cref="Translate"/>
        /// </summary>
        /// <param name="name">The name to translate.</param>
        /// <param name="prefix">The name prefix.</param>
        /// <returns>The translated name.</returns>
        public static string TranslateLite([NotNull] string name, string prefix)
        {
            var builder = new StringBuilder(name);

            if (char.IsDigit(builder[0]))
            {
                builder.Insert(0, "C");
            }

            var newName = builder.ToString().Pascalize();
            return newName.CheckMemberName(prefix);
        }
    }
}
