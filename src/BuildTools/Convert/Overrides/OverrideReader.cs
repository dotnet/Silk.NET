// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Generator.Common.Functions;
using Generator.Convert.Construction;
using Generator.Convert.Overrides.Enumerations;
using Generator.Convert.Overrides.Functions;
using Generator.Convert.XML;
using JetBrains.Annotations;

namespace Generator.Convert.Overrides
{
    /// <summary>
    /// Reads and organizes override signatures from an XML document.
    /// </summary>
    public static class OverrideReader
    {
        /// <summary>
        /// Retrieves the overridden profiles in the signatures.
        /// </summary>
        /// <param name="overrideFilePath">The document containing the overrides.</param>
        /// <returns>A set of profiles.</returns>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<ApiProfileOverride> GetProfileOverrides([NotNull] string overrideFilePath)
        {
            var doc = LoadOverrideDocument(overrideFilePath);
            return GetProfileOverrides(doc);
        }

        /// <summary>
        /// Retrieves the overridden profiles in the override files..
        /// </summary>
        /// <param name="overrideFilePaths">The files to load.</param>
        /// <returns>A set of profiles.</returns>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<ApiProfileOverride> GetProfileOverrides([NotNull] params string[] overrideFilePaths)
        {
            var documents = overrideFilePaths.Select(LoadOverrideDocument);
            return GetProfileOverrides(documents.ToArray());
        }

        /// <summary>
        /// Loads an XDocument from the given file.
        /// </summary>
        /// <param name="overrideFilePath">A path to the file.</param>
        /// <returns>The document.</returns>
        /// <exception cref="FileNotFoundException">Thrown if no file was found at the path.</exception>
        [NotNull]
        private static XDocument LoadOverrideDocument([NotNull] [PathReference] string overrideFilePath)
        {
            if (!File.Exists(overrideFilePath))
            {
                throw new FileNotFoundException("Couldn't find the given override file.", overrideFilePath);
            }

            XDocument doc;
            using (var s = File.OpenRead(overrideFilePath))
            {
                doc = XDocument.Load(s);
            }

            return doc;
        }

        /// <summary>
        /// Retrieves the overridden profiles in the signatures.
        /// </summary>
        /// <param name="signatureDocuments">The documents that contain overrides.</param>
        /// <returns>A set of profiles.</returns>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<ApiProfileOverride> GetProfileOverrides
        (
            [NotNull] params XDocument[] signatureDocuments
        )
        {
            var foundProfiles = new Dictionary
            <
                string,
                Dictionary
                <
                    string,
                    List<XElement>
                >
            >();

            var profileElements = signatureDocuments.Select
                    (GetOverridesRoot)
                .Elements()
                .Where(e => e.Name == "add" || e.Name == "overload" || e.Name == "replace");
            foreach (var profileElement in profileElements)
            {
                var profileNamesAndVersions = (Names: ParseProfileNames(profileElement),
                    Versions: GetVersions(profileElement));

                var profilePairs = profileNamesAndVersions.Names.SelectMany
                (
                    n =>
                        new[] {n}.Zip(profileNamesAndVersions.Versions, (x, y) => (x, y))
                );

                foreach (var (profileName, profileVersion) in profilePairs)
                {
                    if (foundProfiles.TryGetValue(profileName, out var existingProfileVersions))
                    {
                        if (existingProfileVersions.TryGetValue(profileVersion, out var existingProfile))
                        {
                            existingProfile.Add(profileElement);
                            continue;
                        }

                        // We do have the name registered, but not this version
                        existingProfileVersions.Add(profileVersion, new List<XElement> {profileElement});
                        continue;
                    }

                    // We don't have it registered
                    foundProfiles.Add
                    (
                        profileName,
                        new Dictionary<string, List<XElement>>
                        {
                            {profileVersion, new List<XElement> {profileElement}}
                        }
                    );
                }
            }

            foreach (var kvp in foundProfiles)
            {
                var profileName = kvp.Key;
                var elementsByVersion = kvp.Value;
                foreach (var kvp2 in elementsByVersion)
                {
                    var version = kvp2.Key;
                    var elements = kvp2.Value;
                    var enumerationAdditions = new List<EnumerationOverride>();

                    var functionReplacements = new List<FunctionOverride>();

                    foreach (var element in elements)
                    {
                        switch (element.Name.ToString())
                        {
                            case "add":
                            {
                                enumerationAdditions.AddRange(element.Elements("enum").Select(ParseEnumeration));
                                break;
                            }

                            case "replace":
                            {
                                functionReplacements.AddRange
                                    (element.Elements("function").Select(ParseFunctionOverride));
                                break;
                            }

                            case "overload":
                            {
                                Console.WriteLine
                                (
                                    "Warning: XML Overloads are deprecated and should be moved to" +
                                    "helper classes. XML Overloads will be ignored."
                                );
                                break;
                            }

                            default:
                            {
                                throw new InvalidDataException("Invalid element found in profile.");
                            }
                        }
                    }

                    yield return new ApiProfileOverride
                    (
                        profileName,
                        version,
                        enumerationAdditions,
                        functionReplacements
                    );
                }
            }
        }

        /// <summary>
        /// Parses a function override from the given <see cref="XElement" />.
        /// </summary>
        /// <param name="functionElement">The element.</param>
        /// <returns>A parsed override.</returns>
        [NotNull]
        private static FunctionOverride ParseFunctionOverride([NotNull] XElement functionElement)
        {
            var baseFunctionName = functionElement.GetRequiredAttribute("name").Value;
            var baseFunctionExtensions = functionElement.Attribute("extension")?.Value;

            var parameters = new List<ParameterOverride>();
            foreach (var parameterElement in functionElement.Elements("param"))
            {
                var parameterOverride = ParseParameterSignature(parameterElement);
                if (parameters.Any(p => p.BaseName == parameterOverride.BaseName))
                {
                    throw new InvalidDataException
                    (
                        $"Duplicate parameter override with name \"{parameterOverride.BaseName}\" found."
                    );
                }

                parameters.Add(parameterOverride);
            }

            var newVersion = functionElement.Element("version")?.Value;
            var obsoletionReason = functionElement.Element("obsolete")?.Value;

            var returnElement = functionElement.Element("returns");
            var newReturnType = returnElement is null
                ? null
                : ParsingHelpers.ParseTypeSignature(returnElement.Value);

            return new FunctionOverride
            (
                baseFunctionName,
                baseFunctionExtensions,
                newVersion,
                obsoletionReason,
                newReturnType,
                parameters
            );
        }

        /// <summary>
        /// Parses a function parameter signature from the given <see cref="XElement" />.
        /// </summary>
        /// <param name="paramElement">The parameter element.</param>
        /// <returns>A parsed parameter.</returns>
        [NotNull]
        private static ParameterOverride ParseParameterSignature
        (
            [NotNull] XElement paramElement
        )
        {
            var baseName = paramElement.GetRequiredAttribute("name").Value;

            var newName = paramElement.Element("name")?.Value;
            var newTypeElement = paramElement.Element("type");
            var newType = newTypeElement is null
                ? null
                : ParsingHelpers.ParseTypeSignature(newTypeElement.Value);

            var newFlowElement = paramElement.Element("flow");
            FlowDirection? newFlow = null;
            if (!(newFlowElement is null))
            {
                if (!Enum.TryParse<FlowDirection>(newFlowElement.Value, true, out var parsedFlow))
                {
                    throw new InvalidDataException("Could not parse the parameter flow.");
                }

                newFlow = parsedFlow;
            }

            var newCount = paramElement.Element("count")?.Value;

            return new ParameterOverride
            (
                baseName,
                newName,
                newType,
                newFlow,
                newCount
            );
        }

        [NotNull]
        private static EnumerationOverride ParseEnumeration([NotNull] XElement enumElement)
        {
            var enumName = NativeIdentifierTranslator.TranslateIdentifierName
            (
                enumElement.GetRequiredAttribute("name").Value
            );

            var directTokens = enumElement.Elements("token").Select(ParsingHelpers.ParseTokenSignature).ToList();
            var useTokens = enumElement.Elements("use").Select(ParseUseTokenOverride).ToList();
            var reuseTokens = enumElement.Elements("reuse").Select(ParseReuseEnumerationOverride).ToList();

            return new EnumerationOverride(enumName, directTokens, useTokens, reuseTokens);
        }

        /// <summary>
        /// Parses a reuse token from a given <see cref="XElement" />.
        /// </summary>
        /// <param name="reuseElement">The element.</param>
        /// <returns>A parsed token.</returns>
        [NotNull]
        private static ReuseEnumerationOverride ParseReuseEnumerationOverride([NotNull] XElement reuseElement)
        {
            var enumName = reuseElement.GetRequiredAttribute("enum").Value;

            return new ReuseEnumerationOverride(enumName);
        }

        /// <summary>
        /// Parses a use token from a given <see cref="XElement" />.
        /// </summary>
        /// <param name="useElement">The element.</param>
        /// <returns>A parsed token.</returns>
        [NotNull]
        private static UseTokenOverride ParseUseTokenOverride([NotNull] XElement useElement)
        {
            var tokenName = useElement.GetRequiredAttribute("token").Value;
            var enumName = useElement.Attribute("enum")?.Value;
            var isOptionalValue = useElement.Attribute("optional")?.Value;

            return new UseTokenOverride(tokenName, enumName);
        }

        /// <summary>
        /// Gets the root element of the overrides file.
        /// </summary>
        /// <param name="overrides">The document containing the overrides.</param>
        /// <returns>The root element.</returns>
        [NotNull]
        private static XElement GetOverridesRoot([NotNull] XDocument overrides)
        {
            return overrides.Element("signatures") ?? throw new InvalidDataException("No root element found.");
        }

        /// <summary>
        /// Parses a set of pipe-delimited profile names from a given element, reading them from an attribute named
        /// "name".
        /// </summary>
        /// <param name="profileElement">The element.</param>
        /// <returns>The names.</returns>
        [NotNull]
        [ItemNotNull]
        private static IEnumerable<string> ParseProfileNames([NotNull] XElement profileElement)
        {
            var profileNameString = profileElement.Attribute("name")?.Value
                                    ?? throw new InvalidDataException("Profile name attribute not found.");

            return profileNameString.Split('|');
        }

        /// <summary>
        /// Parses a set of pipe-delimited profile versions from a given element, reading them from an attribute named
        /// "version".
        /// </summary>
        /// <param name="profileElement">The element.</param>
        /// <returns>The versions.</returns>
        [NotNull]
        [ItemNotNull]
        private static IEnumerable<string> GetVersions([NotNull] XElement profileElement)
        {
            var profileVersionString = profileElement.Attribute("version")?.Value ?? string.Empty;
            var profileVersionStrings = profileVersionString.Split('|');

            return profileVersionStrings;
        }
    }
}
