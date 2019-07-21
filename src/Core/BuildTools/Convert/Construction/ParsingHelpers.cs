// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Convert.XML;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Convert.Construction
{
    /// <summary>
    /// Shared functionality for the parsing classes.
    /// </summary>
    public static class ParsingHelpers
    {
        /// <summary>
        /// A regular expression that matches the parameter names inside of a COMPSIZE(a,b,c) expression.
        /// </summary>
        public static readonly Regex ComputedSizeParametersRegex =
            new Regex("(?<=COMPSIZE\\()(\\w+?,?)*(?=\\))", RegexOptions.Compiled);

        /// <summary>
        /// A regular expression that matches most common mathematical symbols and the digits 0 to 9.
        /// </summary>
        public static readonly Regex MathematicalSymbolsAndNumbersRegex =
            new Regex("^[\\d[[:blank:]+\\-\\/()*!]+?$", RegexOptions.Compiled);

        /// <summary>
        /// Parses a version from a given <see cref="XElement" />, returning a default value if the attribute is null.
        /// </summary>
        /// <param name="element">The element the attribute is on.</param>
        /// <param name="attributeName">The name of the attribute to parse from.</param>
        /// <param name="defaultVersion">The default value to return.</param>
        /// <returns>A parsed version.</returns>
        [CanBeNull]
        [ContractAnnotation("defaultVersion : null => canbenull; defaultVersion : notnull => notnull")]
        public static Version ParseVersion
        (
            [NotNull] XElement element,
            [NotNull] string attributeName = "version",
            [CanBeNull] Version defaultVersion = null
        )
        {
            var versionAttribute = element.Attribute(attributeName);

            if (versionAttribute is null)
            {
                return defaultVersion;
            }

            var versionString = versionAttribute.Value;
            if (string.IsNullOrWhiteSpace(versionString))
            {
                throw new InvalidDataException("The version attribute was empty.");
            }

            return ParseVersion(versionString, defaultVersion);
        }

        /// <summary>
        /// Parses a version from a given <see cref="string" />, returning a default value if the string is null or
        /// whitespace.
        /// </summary>
        /// <param name="versionString">The version string.</param>
        /// <param name="defaultVersion">The default value to return.</param>
        /// <returns>A parsed version.</returns>
        [CanBeNull]
        [ContractAnnotation("defaultVersion : null => canbenull; defaultVersion : notnull => notnull")]
        public static Version ParseVersion([CanBeNull] string versionString, [CanBeNull] Version defaultVersion = null)
        {
            var version = string.IsNullOrWhiteSpace(versionString)
                ? defaultVersion
                : new Version(versionString);

            return version;
        }

        /// <summary>
        /// Parses a type signature from the given <see cref="XElement" />.
        /// </summary>
        /// <param name="typeElement">The type element.</param>
        /// <returns>A parsed type.</returns>
        [NotNull]
        public static Type ParseTypeSignature([NotNull] XElement typeElement)
        {
            var typeString = typeElement.GetRequiredAttribute("type").Value;

            return ParseTypeSignature(typeString);
        }

        /// <summary>
        /// Parses a type signature from the given string.
        /// </summary>
        /// <param name="type">The type string.</param>
        /// <returns>A parsed type.</returns>
        [NotNull]
        public static Type ParseTypeSignature([NotNull] string type)
        {
            if (type.Contains('*') && (type.Contains('[') || type.Contains(']')))
            {
                throw new InvalidDataException("A type cannot be both a pointer and an array at the same time.");
            }

            const string constValueSpecifier = "const ";
            const string constPointerSpecifier = " const";
            const string structSpecifier = "struct ";

            // We'll ignore struct and const specifiers for the moment
            var isConstValue = type.StartsWith(constValueSpecifier);
            if (isConstValue)
            {
                type = type.Remove(0, constValueSpecifier.Length);
            }

            var isConstPointer = type.EndsWith(constPointerSpecifier);
            if (isConstPointer)
            {
                var specifierIndex = type.LastIndexOf(constPointerSpecifier, StringComparison.Ordinal);
                type = type.Remove(specifierIndex);
            }

            var isStruct = type.StartsWith(structSpecifier);
            if (isStruct)
            {
                type = type.Remove(0, structSpecifier.Length);
            }

            var typeName = new string(type.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());

            var pointerLevel = 0;
            var isPointer = type.EndsWith("*");
            if (isPointer)
            {
                var firstPointerLevelIndex = typeName.IndexOf('*');
                var lastPointerLevelIndex = typeName.LastIndexOf('*');

                pointerLevel = Math.Abs(lastPointerLevelIndex - firstPointerLevelIndex) + 1;

                typeName = typeName.Remove(firstPointerLevelIndex);
            }

            var arrayLevel = 0;
            var isArray = typeName.EndsWith("]");
            if (isArray)
            {
                var firstArrayIndex = typeName.IndexOf('[');
                var lastArrayIndex = typeName.IndexOf(']');

                arrayLevel = Math.Abs(firstArrayIndex - lastArrayIndex);

                typeName = typeName.Remove(firstArrayIndex);
            }

            return new Type {Name = typeName, IndirectionLevels = pointerLevel, ArrayDimensions = arrayLevel};
        }

        /// <summary>
        /// Gets the root element of the signature file.
        /// </summary>
        /// <param name="signatures">The signature document.</param>
        /// <returns>The root element.</returns>
        [NotNull]
        public static XElement GetSignatureRoot([NotNull] XDocument signatures)
        {
            return signatures.GetRequiredElement("signatures");
        }

        /// <summary>
        /// Parses a <see cref="Count" /> from a raw string.
        /// </summary>
        /// <param name="countData">The raw count string.</param>
        /// <param name="hasComputedCount">Whether or not the signature has a computed count.</param>
        /// <param name="computedCountParameterNames">The names of the parameters used in the computed count. </param>
        /// <param name="hasValueReference">Whether or not the signature has a value reference.</param>
        /// <param name="valueReferenceName">The name of the referenced parameter.</param>
        /// <param name="valueReferenceExpression">
        /// The mathematical expression to apply to the name of the referenced parameter.
        /// </param>
        /// <exception cref="InvalidDataException">Thrown if the input string is in an invalid format.</exception>
        /// <returns>
        /// This function returns a static count signature if the count is a static number. If not, the function will
        /// return null, and provide additional information in the <paramref name="hasComputedCount" /> and
        /// <paramref name="hasValueReference" /> parameters. These two are mutually exclusive, and if one is true, the
        /// other is guaranteed to be false.
        /// In the case of a null return value, the following cases may occur:
        /// * The input count string was null.
        /// * <paramref name="hasComputedCount" /> is true, and <paramref name="computedCountParameterNames" /> contains a
        ///   list of all parameter names that are used to compute the count.
        /// * <paramref name="hasValueReference" /> is true, and <paramref name="valueReferenceName" /> contains the name
        ///   of the parameter from which the count is taken.
        /// <paramref name="valueReferenceExpression" /> may contain a mathematical expression, which should be applied
        ///   to the parameter's value to get the final count.
        /// </returns>
        [CanBeNull]
        [ContractAnnotation
        (
            "hasComputedCount : true => computedCountParameterNames : notnull; hasValueReference : true => valueReferenceName : notnull"
        )]
        public static Count ParseCountSignature
        (
            [CanBeNull] string countData,
            out bool hasComputedCount,
            [CanBeNull] out IReadOnlyList<string> computedCountParameterNames,
            out bool hasValueReference,
            [CanBeNull] out string valueReferenceName,
            [CanBeNull] out string valueReferenceExpression
        )
        {
            computedCountParameterNames = null;
            valueReferenceName = null;
            valueReferenceExpression = null;

            hasComputedCount = false;
            hasValueReference = false;

            if (string.IsNullOrWhiteSpace(countData))
            {
                return null;
            }

            if (int.TryParse(countData, out var staticCount))
            {
                return new Count(staticCount);
            }

            if (ComputedSizeParametersRegex.IsMatch(countData))
            {
                // It's a computed count, so we'll extract the names and let the count signature resolve in the second pass
                var countParamNames = ComputedSizeParametersRegex
                    .Matches(countData)
                    .Select(m => m.Value)
                    .First()
                    .Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);

                computedCountParameterNames = countParamNames.ToList();

                hasComputedCount = true;

                return new Count(computedCountParameterNames);
            }

            if (SyntaxFacts.IsValidIdentifier(countData))
            {
                // It's a parameter value reference count (that is, taken from the value of another parameter)
                valueReferenceName = countData;

                hasValueReference = true;
                return new Count(valueReferenceName);
            }

            // Some counts are a value reference along with some sort of numerical operation - let's skip forward in
            // the string until we hit the first invalid character, and see if the rest are just numbers or math ops
            var dataBeforeFirstInvalidCharacter = new string(countData.TakeWhile(char.IsLetterOrDigit).ToArray());
            var dataAfterFirstInvalidCharacter = new string(countData.SkipWhile(char.IsLetterOrDigit).ToArray());

            var isRestMath = MathematicalSymbolsAndNumbersRegex.IsMatch(dataAfterFirstInvalidCharacter);
            if (SyntaxFacts.IsValidIdentifier(dataBeforeFirstInvalidCharacter) && isRestMath)
            {
                // then the rest is likely a mathematical expression
                valueReferenceName = dataBeforeFirstInvalidCharacter;
                valueReferenceExpression = dataAfterFirstInvalidCharacter;

                hasValueReference = true;
                return new Count(valueReferenceName);
            }

            throw new InvalidDataException("No valid count could be parsed from the input.");
        }
    }
}
