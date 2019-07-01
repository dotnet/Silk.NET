// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Represents the desired version of an API.
    /// </summary>
    public struct APIVersion
    {
        /// <summary>
        /// The major version of the API.
        /// </summary>
        public int MajorVersion;

        /// <summary>
        /// The minor version of the API.
        /// </summary>
        public int MinorVersion;

        /// <summary>
        /// Creates a new APIVersion from two integers.
        /// </summary>
        /// <param name="majorVersion">The major version to use.</param>
        /// <param name="minorVersion">The minor version to use.</param>
        public APIVersion(int majorVersion, int minorVersion)
        {
            MajorVersion = majorVersion;
            MinorVersion = minorVersion;
        }

        /// <summary>
        /// Creates a new APIVersion from a <see cref="System.Version"/>
        /// </summary>
        /// <param name="version">The version to use.</param>
        public APIVersion(Version version)
        {
            MajorVersion = version.Major;
            MinorVersion = version.Minor;
        }
    }
}