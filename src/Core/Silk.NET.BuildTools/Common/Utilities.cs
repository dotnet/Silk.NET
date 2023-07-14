// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using ClangSharp;
using ClangSharp.Interop;

using Silk.NET.BuildTools.Common.Functions;
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
        public static readonly HashSet<string> CSharpKeywords = new HashSet<string>
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
        /// Escapes the given string using an at symbol if needed.
        /// </summary>
        /// <param name="s">String to escape.</param>
        /// <returns>Escaped string.</returns>
        public static string AtEscape(this string s)
            => CSharpKeywords.Contains(s) ? $"@{s}" : s;

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
        /// This uses .ToString() to sort faster through the duplicate entries
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <param name="getSignature">A function that returns a trivially hashable signature for the item.</param>
        /// <param name="postDuplicate">
        /// A function that is executed when a duplicate is found; with the current proposed non-duplicate items, the
        /// items the discovered duplicate was checked against, and the duplicate.
        /// </param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicatesFast<T>
        (
            this IEnumerable<T> enumerable,
            Func<T, string> getSignature,
            Action<List<T>, List<T>, T>? postDuplicate = null  
        )
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            var checker = new Dictionary<string, List<T>>();
            foreach (var item in enumerable)
            {
                // get a signature description (basically the parameter types)
                var signature = getSignature(item);
                
                // if we've seen these parameters before for this function.
                if (checker.ContainsKey(signature))
                {
                    // if we've seen this signature before, continue and do not add.
                    if (checker[signature].Any(x => x.Equals(item)))
                    {
                        postDuplicate?.Invoke(ret, checker[signature], item);
                        continue;
                    }
                    
                    // otherwise, register this function for duplicate checking.
                    checker[signature].Add(item);
                }
                else
                {
                    // else, register this signature for duplicate checking.
                    checker.Add(signature, new List<T>() { item });
                }
                
                // not a duplicate!
                ret.Add(item);
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
        /// An extension method which returns the given enumerable without duplicate elements.
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <param name="isDuplicate">A function that checks whether or not items are duplicates.</param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicatesFast<T>(this IEnumerable<T> enumerable, Func<T, T, bool> isDuplicate, Func<T, string> GetSignature)
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            var checker = new Dictionary<string, List<T>>();
            foreach (var item in enumerable)
            {
                var signature = GetSignature(item);
                if (checker.ContainsKey(signature))
                {
                    if (checker[signature].Any(x => isDuplicate(x, item))) continue;
                    checker[signature].Add(item);
                }
                else
                {
                    checker.Add(signature, new List<T>() { item });
                }
                ret.Add(item);
            }
            return ret;
        }

        /// <summary>
        /// Gets an array declaration string that matches the given level of array dimensions.
        /// </summary>
        /// <param name="arrayDimensions">The dimension.</param>
        /// <returns>The string.</returns>
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

        public static sbyte? ParseSbyte(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return sbyte.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!sbyte.TryParse(chars, out var ret))
            {
                if (sbyte.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex sbyte \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a sbyte. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static byte? ParseByte(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return byte.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!byte.TryParse(chars, out var ret))
            {
                if (byte.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex byte \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a byte. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static short? ParseShort(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return short.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!short.TryParse(chars, out var ret))
            {
                if (short.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex short \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a short. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static ushort? ParseUshort(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return ushort.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!ushort.TryParse(chars, out var ret))
            {
                if (ushort.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex ushort \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a ushort. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static int? ParseInt(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return int.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!int.TryParse(chars, out var ret))
            {
                if (int.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex int \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a int. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static uint? ParseUint(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return uint.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!uint.TryParse(chars, out var ret))
            {
                if (uint.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex uint \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a uint. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static long? ParseLong(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return long.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!long.TryParse(chars, out var ret))
            {
                if (long.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex long \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a long. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static ulong? ParseUlong(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return ulong.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!ulong.TryParse(chars, out var ret))
            {
                if (ulong.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex ulong \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a ulong. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }

        public static bool IsBuildToolsIntrinsic(this IEnumerable<Attribute> attributes, out List<string> args)
        {
            var ret = attributes.FirstOrDefault(x => x.Name == "BuildToolsIntrinsic");
            if (ret is null)
            {
                args = null;
                return false;
            }

            args = ret.Arguments;
            return true;
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> enumerable, T singleItem)
        {
            foreach (var item in enumerable)
            {
                yield return item;
            }

            yield return singleItem;
        }

        public static Accessibility MapAccessibility(this CX_CXXAccessSpecifier access) => access switch
        {
            CX_CXXAccessSpecifier.CX_CXXInvalidAccessSpecifier => Accessibility.Public,
            CX_CXXAccessSpecifier.CX_CXXPublic => Accessibility.Public,
            CX_CXXAccessSpecifier.CX_CXXProtected => Accessibility.Public,
            CX_CXXAccessSpecifier.CX_CXXPrivate => Accessibility.Private,
            _ => Accessibility.Internal
        };

        public static string MapAccessibility(this Accessibility access, bool s = false) => access switch
        {
            Accessibility.Public => "public" + (s ? " " : string.Empty),
            Accessibility.Protected => "protected" + (s ? " " : string.Empty),
            Accessibility.Internal => "internal" + (s ? " " : string.Empty),
            Accessibility.Private => "private" + (s ? " " : string.Empty),
            _ => string.Empty
        };

        public static bool ConstitutesVulkanOutOverload(this string name) => name.StartsWith
            ("vkCreate") || name.StartsWith("vkAllocate") || name.StartsWith
            ("vkGet");

        public static string MapNativeString(this Functions.Type type) => type.OriginalName?.ToUpper() switch
        {
            "BSTR" => "NativeStringEncoding.BStr",
            "LPSTR" or "LPCSTR" => "NativeStringEncoding.LPStr",
            "LPTSTR" or "LPCTSTR" => "NativeStringEncoding.LPTStr",
            "LPUTF8STR" => "NativeStringEncoding.LPUTF8Str",
            "LPWSTR" or "LPCWSTR" => "NativeStringEncoding.LPWStr",
            _ => "NativeStringEncoding.UTF8"
        };

        public static string MapUnmanagedType(this Functions.Type type) => type.OriginalName?.ToUpper() switch
        {
            "BSTR" => "Silk.NET.Core.Native.UnmanagedType.BStr",
            "LPSTR" or "LPCSTR" => "Silk.NET.Core.Native.UnmanagedType.LPStr",
            "LPTSTR" or "LPCTSTR" => "Silk.NET.Core.Native.UnmanagedType.LPTStr",
            "LPUTF8STR" => "Silk.NET.Core.Native.UnmanagedType.LPUTF8Str",
            "LPWSTR" or "LPCWSTR" => "Silk.NET.Core.Native.UnmanagedType.LPWStr",
            _ => "Silk.NET.Core.Native.UnmanagedType.LPUTF8Str"
        };

        /// <summary>
        /// Finds a common prefix in a set of names with respect to the word boundaries
        /// </summary>
        /// <param name="names">Set of names, snake_case</param>
        /// <param name="allowFullMatch">Allows result to be a a full match with one of the names</param>
        /// <param name="allowLeadingDigits">Allows remainder tokens to start with a digit</param>
        /// <returns>String that is common between all provided names</returns>
        public static string FindCommonPrefix(List<string> names, bool allowFullMatch, bool allowLeadingDigits)
        {
            var commonPrefixFirstPass = FindCommonPrefix(names, allowFullMatch, names.Max(x => x.Length));
            if (allowLeadingDigits)
            {
                return commonPrefixFirstPass;
            }

            var tgtPos = commonPrefixFirstPass.Length;

            var startingWithDigit = names.Where(n => n.Length > tgtPos && char.IsDigit(n[tgtPos]));
            if (startingWithDigit.Any())
            {
                return FindCommonPrefix(names, allowFullMatch, tgtPos - 1);
            }

            return commonPrefixFirstPass;
        }

        /// <summary>
        /// Finds a common prefix in a set of names with respect to the word boundaries
        /// </summary>
        /// <param name="names">Set of names, snake_case</param>
        /// <param name="allowFullMatch">Allows result to be a a full match with one of the names</param>
        /// <param name="maxLen">Match length limit</param>
        /// <returns>String that is common between all provided names</returns>
        public static string FindCommonPrefix(List<string> names, bool allowFullMatch, int maxLen)
        {
            var pos = 0;
            var foundPrefix = "";
            var minLen = names.Min(x => x.Length);
            var found = false;
            while (!found)
            {
                pos++;
                if (pos >= maxLen || pos > names[0].Length)
                {
                    break;
                }
                var prefix = names[0].Substring(0, pos);
                foreach (var name in names.Skip(1))
                {
                    if (!name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        break;
                    }
                }
                foundPrefix = prefix;
            }

            if (!foundPrefix.Contains('_'))
            {
                return "";
            }

            if (foundPrefix.Length == minLen && allowFullMatch)
            {
                return foundPrefix;
            }
            return foundPrefix.Substring(0, foundPrefix.LastIndexOf('_') + 1);
        }

        /// <summary>
        /// Replaces any temporary folder names from the given string containing a file path with &gt;...&lt;
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>The edited string.</returns>
        public static string RemoveTempNames(this string s)
            => Generator.TempFolders.Aggregate(s, (now, tmp) => now.Replace(tmp, "<...>"));

        /// <summary>
        /// Gets the content for the NativeName Src attribute for this decl. 
        /// </summary>
        /// <param name="decl">The decl.</param>
        /// <returns>The content for the NativeName attribute.</returns>
        public static string ToNativeName(this Decl decl)
        {
            decl.Location.GetSpellingLocation(out var file, out var line, out var column, out _);
            return $"Line {line}, Column {column} in {Path.GetFileName(file.Name.ToString())}";
        }
        
        public static bool IsProbablyABitmask(this Enums.Enum @enum)
            => @enum.Tokens.Count > 1 && // there is more than one token
               // at least approx 50% of the tokens have only one bit set
               @enum.Tokens.Count(x => BitOperations.PopCount(ParseToken(x.Value, @enum)) == 1)
               >= MathF.Floor(@enum.Tokens.Count / 2f) &&
               // it's not sequential (1, 2, 3)
               !@enum.IsSequential();

        private static bool IsSequential(this Enums.Enum @enum)
        {
            const int maxMisses = 1;
            var misses = 0;
            for (var i = 0; i < @enum.Tokens.Count; i++)
            {
                if (ParseToken(@enum.Tokens[i].Value, @enum) != (ulong)(i - misses) &&
                    ParseToken(@enum.Tokens[i].Value, @enum) != (ulong)((i - misses) + 1))
                {
                    misses++;
                }

                if (misses > maxMisses)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool HasDefaultValue(this Enums.Enum @enum)
            => @enum.Tokens.Any(x => ParseToken(x.Value, @enum) is 0);

        private static ulong ParseToken(string value, Enums.Enum @enum) => value.StartsWith("0x")
            ? ulong.Parse(value[2..], NumberStyles.HexNumber, null)
            : value.StartsWith("unchecked")
                ? ParseToken(value[$"unchecked(({@enum.EnumBaseType.Name})".Length..].TrimEnd(')').Trim(), @enum)
                : ulong.TryParse(value, out var val)
                    ? val
                    : long.TryParse(value, out var signedVal)
                        ? @enum.EnumBaseType.Name switch
                        {
                            "int" => unchecked((ulong) (int) signedVal),
                            "uint" => unchecked((uint) signedVal),
                            "long" or "ulong" => unchecked((ulong) signedVal),
                            _ => throw new ArgumentOutOfRangeException()
                        }
                        : throw new ArgumentException("failed to parse", nameof(value));
        /// <summary>
        /// Separates the input words with underscore
        /// </summary>
        /// <param name="input">The string to be underscored</param>
        /// <returns></returns>
        public static string LenientUnderscore(this string input)
        {
            // This is a modified version of Humanizer's Underscore methods with the following changes:
            // - The regex ([\p{Ll}\d])([\p{Lu}]) has been replaced with
            //   ([\p{Ll}\d])(?=[\p{Lu}][\p{Lu}\p{Ll}])([\p{Lu}]) - In this regex, the positive lookahead assertion
            //   (?=[\p{Lu}][\p{Lu}\p{Ll}]) ensures that the next character after the match is an uppercase letter,
            //   followed by any letter (uppercase or lowercase). This will only match if the 2nd character after the
            //   initial match is uppercase. That was suggested by ChatGPT, a human had to add the final
            //   [\p{Ll}])([\p{Lu}]) to ensure we don't erroneous match non-pascal case strings and to capture the
            //   second character to ensure we can do the replacement. Still pretty smart though.
            // - The final ToLower has been omitted as it was not deemed necessary 
            // - The regex ([\p{Ll}])([\p{Lu}]) has been added to replace lowercase letters followed by an uppercase letter with the 
            //   same sequence but with an underscore inbetween, 
            //   this fixes cases like SpvImageFormatR32ui being Spv_Image_FormatR32ui instead of Spv_Image_Format_R32ui
            return Regex.Replace
            (
                Regex.Replace
                (
                    Regex.Replace
                    (
                        Regex.Replace
                        (
                            input, 
                            @"([\p{Lu}]+)([\p{Lu}][\p{Ll}])", 
                            "$1_$2"
                        ),
                        @"([\p{Ll}])(?=[\p{Lu}][\p{Lu}\p{Ll}])([\p{Lu}])", 
                        "$1_$2"
                    ),
                    @"([\p{Ll}])([\p{Lu}])", 
                    "$1_$2"
                ),
                @"[-\s]", 
                "_"
            );
        }
    }
}
