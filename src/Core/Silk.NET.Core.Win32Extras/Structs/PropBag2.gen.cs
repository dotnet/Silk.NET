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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "tagPROPBAG2")]
    public unsafe partial struct PropBag2
    {
        public PropBag2
        (
            uint? dwType = null,
            ushort? vt = null,
            ushort? cfType = null,
            uint? dwHint = null,
            char* pstrName = null,
            Guid? clsid = null
        ) : this()
        {
            if (dwType is not null)
            {
                DwType = dwType.Value;
            }

            if (vt is not null)
            {
                Vt = vt.Value;
            }

            if (cfType is not null)
            {
                CfType = cfType.Value;
            }

            if (dwHint is not null)
            {
                DwHint = dwHint.Value;
            }

            if (pstrName is not null)
            {
                PstrName = pstrName;
            }

            if (clsid is not null)
            {
                Clsid = clsid.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwType")]
        public uint DwType;

        [NativeName("Type", "VARTYPE")]
        [NativeName("Type.Name", "VARTYPE")]
        [NativeName("Name", "vt")]
        public ushort Vt;

        [NativeName("Type", "CLIPFORMAT")]
        [NativeName("Type.Name", "CLIPFORMAT")]
        [NativeName("Name", "cfType")]
        public ushort CfType;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwHint")]
        public uint DwHint;

        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "pstrName")]
        public char* PstrName;

        [NativeName("Type", "CLSID")]
        [NativeName("Type.Name", "CLSID")]
        [NativeName("Name", "clsid")]
        public Guid Clsid;
    }
}
