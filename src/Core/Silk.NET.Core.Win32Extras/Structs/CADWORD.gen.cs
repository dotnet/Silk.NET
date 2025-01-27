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
    [NativeName("Name", "tagCADWORD")]
    public unsafe partial struct CADWORD
    {
        public CADWORD
        (
            uint? cElems = null,
            uint* pElems = null
        ) : this()
        {
            if (cElems is not null)
            {
                CElems = cElems.Value;
            }

            if (pElems is not null)
            {
                PElems = pElems;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cElems")]
        public uint CElems;

        [NativeName("Type", "DWORD *")]
        [NativeName("Type.Name", "DWORD *")]
        [NativeName("Name", "pElems")]
        public uint* PElems;
    }
}
