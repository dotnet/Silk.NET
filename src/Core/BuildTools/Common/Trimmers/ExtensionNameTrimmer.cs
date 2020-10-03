// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Linq;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Trimmers
{
    /// <summary>
    /// Trims OpenGL extension names from OpenGL functions.
    /// </summary>
    public class ExtensionNameTrimmer : ITrimmer<Function>, ITrimmer<string>
    {
        /// <summary>
        /// A list of all known vendor codes.
        /// </summary>
        public static readonly string[] Vendors = {
            // ReSharper disable StringLiteralTypo
            "IMG",
            "AMD",
            "AMDX",
            "ARM",
            "FSL",
            "BRCM",
            "NXP",
            "NV",
            "NVX",
            "VIV",
            "VSI",
            "KDAB",
            "ANDROID",
            "CHROMIUM",
            "GOOGLE",
            "QCOM",
            "LUNARG",
            "SAMSUNG",
            "SEC",
            "TIZEN",
            "RENDERDOC",
            "NN",
            "MVK",
            "KHR",
            "KHX",
            "EXT",
            "MESA",
            "KAZAN",
            "AMD",
            "APPLE",
            "ARB",
            "EXT",
            "INTEL",
            "KHR",
            "NV",
            "OVR",
            "AMD",
            "APPLE",
            "ARB",
            "ATI",
            "EXT",
            "GL3DFX",
            "GREMEDY",
            "HP",
            "IBM",
            "INGR",
            "INTEL",
            "KHR",
            "MESA",
            "MESAX",
            "NV",
            "NVX",
            "OES",
            "OML",
            "OVR",
            "PGI",
            "REND",
            "S3",
            "SGI",
            "SGIS",
            "SGIX",
            "SUN",
            "SUNX",
            "WIN",
            "AMD",
            "ANDROID",
            "ANGLE",
            "APPLE",
            "ARM",
            "DMP",
            "EXT",
            "FJ",
            "IMG",
            "INTEL",
            "KHR",
            "MESA",
            "NV",
            "NVX",
            "OES",
            "OVR",
            "QCOM",
            "VIV",
            // ReSharper restore StringLiteralTypo
        };

        /// <inheritdoc />
        public bool IsRelevant(Function trimmable)
        {
            return !(trimmable.ExtensionName is null)
                   && trimmable.Name.ToLower().EndsWith(trimmable.ExtensionName.ToLower());
        }

        /// <inheritdoc />
        public Function Trim(Function trimmable, string prefix)
        {
            var extensionNameIndex = trimmable.NativeName.LastIndexOf
                (trimmable.ExtensionName, StringComparison.OrdinalIgnoreCase);
            trimmable.Name = trimmable.NativeName.Remove(extensionNameIndex).CheckMemberName(prefix);
            return trimmable;
        }

        /// <inheritdoc />
        public bool IsRelevant(string trimmable)
        {
            return Vendors.Any(trimmable.EndsWith);
        }

        /// <inheritdoc />
        public string Trim(string trimmable, string prefix)
        {
            foreach (var vendor in Vendors)
            {
                if (trimmable.EndsWith(vendor))
                {
                    return trimmable.Remove(trimmable.Length - vendor.Length);
                }
            }

            return trimmable;
        }
    }
}
