// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Text;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.GLXmlConvert.Construction.Trimmers
{
    /// <summary>
    /// Trims OpenGL extension names from OpenGL functions.
    /// </summary>
    public class ExtensionNameTrimmer : ITrimmer<Function>, ITrimmer<string>
    {
        /// <inheritdoc />
        public bool IsRelevant(Function trimmable)
        {
            if (trimmable.ExtensionName is null)
            {
                return false;
            }

            return trimmable.Name.ToLower().EndsWith(trimmable.ExtensionName.ToLower());
        }

        /// <inheritdoc />
        public Function Trim(Function trimmable)
        {
            var extensionNameIndex = trimmable.NativeName.LastIndexOf
                (trimmable.ExtensionName, StringComparison.OrdinalIgnoreCase);
            trimmable.Name = trimmable.NativeName.Remove(extensionNameIndex).CheckMemberName(GLXmlConverter.CliOptions.Prefix);
            return trimmable;
        }

        /// <inheritdoc />
        public bool IsRelevant(string trimmable)
        {
            var uppercaseCount = 0;
            for (var i = trimmable.Length - 1; i >= 0; --i)
            {
                if (char.IsUpper(trimmable, i))
                {
                    uppercaseCount++;
                    continue;
                }

                break;
            }

            if (uppercaseCount > 1)
            {
                return true;
            }

            return false;
        }

        /// <inheritdoc />
        public string Trim(string trimmable)
        {
            var sb = new StringBuilder();

            var isTrimming = true;
            for (var i = trimmable.Length - 1; i >= 0; --i)
            {
                if (isTrimming && char.IsUpper(trimmable, i))
                {
                    continue;
                }

                isTrimming = false;
                sb.Insert(0, trimmable[i]);
            }

            return sb.ToString();
        }
    }
}
