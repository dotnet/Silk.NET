// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using Silk.NET.BuildTools.Common.Structs;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Gets a list of keywords in the C# language.
        /// </summary>
        [NotNull]
        public static List<string> CSharpKeywords => new List<string>
        {
            "abstract",
            "event",
            "new",
            "struct",
            "as",
            "explicit",
            "null",
            "switch",
            "base",
            "extern",
            "object",
            "this",
            "bool",
            "false",
            "operator",
            "throw",
            "break",
            "finally",
            "out",
            "true",
            "byte",
            "fixed",
            "override",
            "try",
            "case",
            "float",
            "params",
            "typeof",
            "catch",
            "for",
            "private",
            "uint",
            "char",
            "foreach",
            "protected",
            "ulong",
            "checked",
            "goto",
            "public",
            "unchecked",
            "class",
            "if",
            "readonly",
            "unsafe",
            "const",
            "implicit",
            "ref",
            "ushort",
            "continue",
            "in",
            "return",
            "using",
            "decimal",
            "int",
            "sbyte",
            "virtual",
            "default",
            "interface",
            "sealed",
            "volatile",
            "delegate",
            "internal",
            "short",
            "void",
            "do",
            "is",
            "sizeof",
            "while",
            "double",
            "lock",
            "stackalloc",
            "else",
            "long",
            "static",
            "enum",
            "namespace",
            "string"
        };

        /// <summary>
        /// An extension method which returns the given enumerable without duplicate elements.
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicates<T>(this IEnumerable<T> enumerable)
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            foreach (var item in enumerable)
            {
                if (!ret.Any(x => x.Equals(item)))
                {
                    ret.Add(item);
                }
            }

            return ret;
        }

        /// <summary>
        /// An extension method which returns the given enumerable without duplicate elements.
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <param name="isDuplicate">A function that checks whether or not items are duplicates.</param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicates<T>(this IEnumerable<T> enumerable, Func<T, T, bool> isDuplicate)
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            foreach (var item in enumerable)
            {
                if (!ret.Any(x => isDuplicate(x, item)))
                {
                    ret.Add(item);
                }
            }

            return ret;
        }

        /// <summary>
        /// Gets an array declaration string that matches the given level of array dimensions.
        /// </summary>
        /// <param name="arrayDimensions">The dimension.</param>
        /// <returns>The string.</returns>
        [NotNull]
        public static string GetArrayDimensionString(int arrayDimensions)
        {
            if (arrayDimensions == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            builder.Append('[');
            builder.Append(new string(',', arrayDimensions - 1));
            builder.Append(']');

            return builder.ToString();
        }

        /// <summary>
        /// Checks if member names are valid for C#.
        /// </summary>
        /// <param name="name">The name to check.</param>
        /// <param name="fPrefix">The prefix to append if the name fails the check.</param>
        /// <returns>The string after being validated.</returns>
        public static string CheckMemberName(this string name, string fPrefix)
        {
            name = name.Replace("_", null).Replace(" ", null);
            // ReSharper disable StringLiteralTypo
            if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().Contains(name[0]))
            // ReSharper restore StringLiteralTypo
            {
                return fPrefix.ToUpper() + name;
            }

            return name;
        }

        public static Field WithFixedFieldFixup09072020(this Field field)
        {
            if (field.Count is null)
            {
                return field;
            }
            
            if (field.Count.IsStatic)
            {
                field.Type.IndirectionLevels++;
            }
            
            return field;
        }

        public static int ParseInt(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return int.Parse(chars.Slice(2), NumberStyles.HexNumber);
            }

            if (!int.TryParse(chars, out var ret))
            {
                if (int.TryParse(chars, NumberStyles.HexNumber, null, out var hexRet))
                {
                    Console.WriteLine
                    (
                        $"Warning: Implicitly treating \"{chars.ToString()}\" as hex integer \"{hexRet}\"."
                    );

                    return hexRet;
                }
            }

            return ret;
        }
    }
}
