// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.InteropServices;

namespace Silk.NET.Core
{
    /// <summary>
    /// A struct of potential WindowHandles, represented by nullables
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public struct WindowHandles
    {
        /// Probably redundant? Not sure
        public bool IsSupported { get; }
        // ...
    }
}
