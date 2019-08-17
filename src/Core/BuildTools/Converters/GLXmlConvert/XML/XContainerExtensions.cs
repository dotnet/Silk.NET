// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Silk.NET.BuildTools.GLXmlConvert.XML
{
    /// <summary>
    /// Extension methods for the <see cref="XContainer" /> class.
    /// </summary>
    public static class XContainerExtensions
    {
        /// <summary>
        /// Gets a required class element from a container. By default, this searches for an element named "div" with
        /// the given class name as an attribute.
        /// </summary>
        /// <param name="container">The container to get the element from.</param>
        /// <param name="className">The name of the element's class.</param>
        /// <param name="sectionName">The name of the element.</param>
        /// <returns>The section.</returns>
        /// <exception cref="InvalidDataException">Thrown if the section couldn't be found.</exception>
        /// <exception cref="AmbiguousMatchException">Thrown if more than one matching section was found.</exception>
        public static XElement GetRequiredSectionByClass
        (
            [NotNull] this XContainer container,
            [NotNull] string className,
            [NotNull] string sectionName = "div"
        )
        {
            var sectionElements = container.Elements();
            if (!string.IsNullOrWhiteSpace(sectionName))
            {
                sectionElements = container.Elements(sectionName);
            }

            var targetSections = sectionElements.Where
                    (e => e.GetRequiredAttribute("class").Value == className)
                .ToList();

            if (!targetSections.Any())
            {
                throw new InvalidDataException($"Required section \"{className}\" not found.");
            }

            if (targetSections.Count > 1)
            {
                throw new AmbiguousMatchException($"Multiple sections of class \"{className}\" were found.");
            }

            return targetSections.First();
        }

        /// <summary>
        /// Gets a required class element from a container. By default, this searches for an element named "div" with
        /// the given class name as an attribute.
        /// </summary>
        /// <param name="container">The container to get the element from.</param>
        /// <param name="className">The name of the element's class.</param>
        /// <param name="sectionName">The name of the element.</param>
        /// <returns>The section.</returns>
        /// <exception cref="InvalidDataException">Thrown if the section couldn't be found.</exception>
        /// <exception cref="AmbiguousMatchException">Thrown if more than one matching section was found.</exception>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<XElement> GetRequiredSectionsByClass
        (
            [NotNull] this XContainer container,
            [NotNull] string className,
            [NotNull] string sectionName = "div"
        )
        {
            var sectionElements = container.Elements(sectionName);
            var targetSections = sectionElements.Where
                    (e => e.GetRequiredAttribute("class").Value == className)
                .ToList();

            if (!targetSections.Any())
            {
                throw new InvalidDataException($"Required section \"{className}\" not found.");
            }

            return targetSections;
        }

        /// <summary>
        /// Gets a required element from a container.
        /// </summary>
        /// <param name="container">The container to get the element from.</param>
        /// <param name="elementName">The name of the element.</param>
        /// <param name="ignoreNamespace">Whether or not the namespace should be ignored.</param>
        /// <exception cref="InvalidDataException">Thrown if the element is not present.</exception>
        /// <returns>The element.</returns>
        [NotNull]
        public static XElement GetRequiredElement
        (
            [NotNull] this XContainer container,
            [NotNull] string elementName,
            bool ignoreNamespace = true
        )
        {
            var element = ignoreNamespace
                ? container.Elements().FirstOrDefault(a => a.Name.LocalName == elementName)
                : container.Element(elementName);

            if (element is null)
            {
                throw new InvalidDataException($"Required element \"{elementName}\" not found.");
            }

            return element;
        }

        /// <summary>
        /// Gets a set of required elements from a container.
        /// </summary>
        /// <param name="container">The container to get the elements from.</param>
        /// <param name="elementName">The name of the element.</param>
        /// <param name="ignoreNamespace">Whether or not the namespace should be ignored.</param>
        /// <returns>The elements.</returns>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<XElement> GetRequiredElements
        (
            [NotNull] this XContainer container,
            [NotNull] string elementName,
            bool ignoreNamespace = true
        )
        {
            var elements = ignoreNamespace
                ? container.Elements().Where(a => a.Name.LocalName == elementName)
                : container.Elements(elementName);

            var requiredElements = elements.ToList();
            if (!requiredElements.Any())
            {
                throw new InvalidDataException($"Required element \"{elements}\" not found.");
            }

            return requiredElements;
        }
    }
}
