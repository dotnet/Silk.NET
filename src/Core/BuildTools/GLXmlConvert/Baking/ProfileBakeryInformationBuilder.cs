// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
            Result = new ProfileBakeryInformation();
        }

        /// <summary>
        /// Gets the resulting <see cref="ProfileBakeryInformation" />.
        /// </summary>
        public ProfileBakeryInformation Result { get; }

        /// <summary>
        /// Adds the given implemented profiles to the <see cref="ProfileBakeryInformation" />.
        /// </summary>
        /// <param name="implements">The profiles to implement.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder Implements(params string[] implements)
        {
            Result.Implements.AddRange(implements);
            return this;
        }

        /// <summary>
        /// Sets the profile's namespaces.
        /// </summary>
        /// <param name="ns">The root namespace.</param>
        /// <param name="extensionNs">The extension root namespace.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithNamespaces(string ns, string extensionNs)
        {
            Result.Namespace = ns;
            Result.ExtensionsNamespace = extensionNs;
            return this;
        }

        /// <summary>
        /// Sets the profile's name.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithName(string name)
        {
            Result.Name = name;
            return this;
        }

        /// <summary>
        /// Sets the function prefix.
        /// </summary>
        /// <param name="prefix">The function prefix.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithPrefix(string prefix)
        {
            Result.FunctionPrefix = prefix;
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
            Result.NameContainer.Linux = linux;
            Result.NameContainer.Android = android;
            Result.NameContainer.MacOS = osx;
            Result.NameContainer.Windows = windows;
            Result.NameContainer.IOS = ios;
            Result.NameContainer.ClassName = classname;
            return this;
        }

        /// <summary>
        /// Sets the output folder.
        /// </summary>
        /// <param name="folder">The output folder.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithOutputFolder(string folder)
        {
            Result.OutputFolder = folder;
            return this;
        }

        /// <summary>
        /// Sets the class name.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <returns>This instance (for chaining purposes).</returns>
        public ProfileBakeryInformationBuilder WithClassName(string className)
        {
            Result.ClassName = className;
            return this;
        }

        public ProfileBakeryInformationBuilder WithSymbolLoader(string loader)
        {
            Result.SymbolLoader = loader;
            return this;
        }
    }
}
