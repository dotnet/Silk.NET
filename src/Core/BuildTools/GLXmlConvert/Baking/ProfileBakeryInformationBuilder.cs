// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.GLXmlConvert.Baking
{
    /// <summary>
    /// A builder class for <see cref="ProfileBakeryInformation" />.
    /// </summary>
    public class ProfileBakeryInformationBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileBakeryInformationBuilder" /> class.
        /// </summary>
        public ProfileBakeryInformationBuilder()
        {
            _implements = new List<string>();
        }
        
        private string? _namespace;
        private string? _extensionsNamespace;
        private string? _name;
        private string? _outputFolder;
        private NameContainer? _nameContainer;
        private string? _functionPrefix;
        private string? _className;
        private string? _symbolLoader;
        private List<string> _implements;

        /// <summary>
        /// Gets the resulting <see cref="ProfileBakeryInformation" />.
        /// </summary>
        public ProfileBakeryInformation Result
            => new ProfileBakeryInformation(
                _namespace ?? throw new ArgumentNullException("Namespace"),
                _extensionsNamespace ?? throw new ArgumentNullException("ExtensionsNamespace"),
                _name ?? throw new ArgumentNullException("Name"),
                _outputFolder ?? throw new ArgumentNullException("Output Folder"),
                _nameContainer ?? throw new ArgumentNullException("Name Container"),
                _functionPrefix ?? throw new ArgumentNullException("Function Prefix"),
                _className ?? throw new ArgumentNullException("Class Name"),
                _symbolLoader ?? throw new ArgumentNullException("Symbol Loader"),
                _implements);

        /// <summary>
        /// Adds the given implemented profiles to the <see cref="ProfileBakeryInformation" />.
        /// </summary>
        /// <param name="implements">The profiles to implement.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder Implements(params string[] implements)
        {
            _implements.AddRange(implements);
            return this;
        }

        /// <summary>
        /// Sets the profile's namespaces.
        /// </summary>
        /// <param name="ns">The root namespace.</param>
        /// <param name="extensionsNs">The extensions root namespace.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithNamespaces(string ns, string extensionsNs)
        {
            _namespace = ns;
            _extensionsNamespace = extensionsNs;
            return this;
        }

        /// <summary>
        /// Sets the profile's name.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        /// <summary>
        /// Sets the function prefix.
        /// </summary>
        /// <param name="prefix">The function prefix.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithPrefix(string prefix)
        {
            _functionPrefix = prefix;
            return this;
        }

        /// <summary>
        /// Sets the profile's name container.
        /// </summary>
        /// <param name="classname">The value for the ClassName property.</param>
        /// <param name="linux">The value for the Linux property.</param>
        /// <param name="android">The value for the Android property.</param>
        /// <param name="osx">The value for the MacOS property.</param>
        /// <param name="windows">The value for the Windows property.</param>
        /// <param name="ios">The value for the IOS property.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithLibraries
        (
            string classname,
            string linux,
            string android,
            string osx,
            string windows,
            string ios
        )
        {
            _nameContainer = new NameContainer(linux, windows, osx, android, ios, classname);
            return this;
        }

        /// <summary>
        /// Sets the output folder.
        /// </summary>
        /// <param name="folder">The output folder.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithOutputFolder(string folder)
        {
            _outputFolder = folder;
            return this;
        }

        /// <summary>
        /// Sets the class name.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithClassName(string className)
        {
            _className = className;
            return this;
        }

        public ProfileBakeryInformationBuilder WithSymbolLoader(string loader)
        {
            _symbolLoader = loader;
            return this;
        }
    }
}
