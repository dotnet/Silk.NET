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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("00000002-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMalloc")]
    public unsafe partial struct IMalloc
    {
        public static readonly Guid Guid = new("00000002-0000-0000-c000-000000000046");

    }
}
