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
    [NativeName("Name", "tagSTATPROPSTG")]
    public unsafe partial struct STATPROPSTG
    {
        public STATPROPSTG
        (
            char* lpwstrName = null,
            uint? propid = null,
            ushort? vt = null
        ) : this()
        {
            if (lpwstrName is not null)
            {
                LpwstrName = lpwstrName;
            }

            if (propid is not null)
            {
                Propid = propid.Value;
            }

            if (vt is not null)
            {
                Vt = vt.Value;
            }
        }


        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "lpwstrName")]
        public char* LpwstrName;

        [NativeName("Type", "PROPID")]
        [NativeName("Type.Name", "PROPID")]
        [NativeName("Name", "propid")]
        public uint Propid;

        [NativeName("Type", "VARTYPE")]
        [NativeName("Type.Name", "VARTYPE")]
        [NativeName("Name", "vt")]
        public ushort Vt;
    }
}
