// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALLibraryNameContainer : SearchPathContainer
    {
        private readonly bool _preferSoft;

        private readonly SearchPathContainer _soft;
        private readonly SearchPathContainer _native;

        public OpenALLibraryNameContainer(bool preferSoft)
        {
            _preferSoft = preferSoft;

            _soft = new OpenALSoftLibraryNameContainer();
            _native = new OpenALNativeLibraryNameContainer();
        }

        /// <inheritdoc />
        public override string[] Linux => _preferSoft
            ? _soft.Linux.Concat(_native.Linux).ToArray()
            : _native.Linux.Concat(_soft.Linux).ToArray();

        /// <inheritdoc />
        public override string[] MacOS => _preferSoft
            ? _soft.MacOS.Concat(_native.MacOS).ToArray()
            : _native.MacOS.Concat(_soft.MacOS).ToArray();

        /// <inheritdoc />
        public override string[] Android => Linux;

        /// <inheritdoc />
        public override string[] IOS => MacOS;

        /// <inheritdoc />
        public override string[] Windows86 => _preferSoft
            ? _soft.Windows86.Concat(_native.Windows86).ToArray()
            : _native.Windows86.Concat(_soft.Windows86).ToArray();

        /// <inheritdoc />
        public override string[] Windows64 => _preferSoft
            ? _soft.Windows64.Concat(_native.Windows64).ToArray()
            : _native.Windows64.Concat(_soft.Windows64).ToArray();
    }
}
