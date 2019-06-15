using System;
using System.Text;
using Generator.Common.Functions;
using JetBrains.Annotations;

namespace Generator.Convert.Construction.Trimmers
{
    /// <summary>
    /// Trims OpenGL extension names from OpenGL functions.
    /// </summary>
    public class ExtensionNameTrimmer : ITrimmer<Function>, ITrimmer<string>
    {
        /// <inheritdoc/>
        public bool IsRelevant(Function trimmable)
        {
            if (trimmable.ExtensionName is null)
            {
                return false;
            }

            return trimmable.Name.ToLower().EndsWith(trimmable.ExtensionName.ToLower());
        }

        /// <inheritdoc/>
        public void Trim(Function trimmable)
        {
            var extensionNameIndex = trimmable.Name.LastIndexOf(trimmable.ExtensionName, StringComparison.OrdinalIgnoreCase);
            trimmable.Name = trimmable.Name.Remove(extensionNameIndex);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public void Trim(string trimmable)
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

            trimmable = sb.ToString();
        }
    }
}
