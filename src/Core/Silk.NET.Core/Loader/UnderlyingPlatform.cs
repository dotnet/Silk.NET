using System;
using System.Collections.Generic;
using System.Text;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    /// An enum representing possible underlying platforms.
    /// </summary>
    public enum UnderlyingPlatform
    {
        /// <summary>
        /// Unknown underlying platform, default value.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Windows on x64
        /// </summary>
        Windows64,
        /// <summary>
        /// Windows on x86
        /// </summary>
        Windows86,
        /// <summary>
        /// Linux
        /// </summary>
        Linux,
        /// <summary>
        /// Android
        /// </summary>
        Android,
        /// <summary>
        /// MacOS
        /// </summary>
        MacOS,
        /// <summary>
        /// iOS
        /// </summary>
        IOS
    }
}
