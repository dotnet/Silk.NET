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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "DxcArgPair")]
    public unsafe partial struct ArgPair
    {
        public ArgPair
        (
            char* pName = null,
            char* pValue = null
        ) : this()
        {
            if (pName is not null)
            {
                PName = pName;
            }

            if (pValue is not null)
            {
                PValue = pValue;
            }
        }


        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "pName")]
        public char* PName;

        [NativeName("Type", "const WCHAR *")]
        [NativeName("Type.Name", "const WCHAR *")]
        [NativeName("Name", "pValue")]
        public char* PValue;
    }
}
