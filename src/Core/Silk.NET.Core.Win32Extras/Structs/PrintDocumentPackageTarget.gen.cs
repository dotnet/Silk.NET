// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Guid("4842669e-9947-46ea-8ba2-d8cce432c2ca")]
    [NativeName("Name", "PrintDocumentPackageTarget")]
    public unsafe partial struct PrintDocumentPackageTarget
    {
        public static readonly Guid Guid = new("4842669e-9947-46ea-8ba2-d8cce432c2ca");

    }
}
