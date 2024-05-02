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
    [NativeName("Name", "tagCUSTDATA")]
    public unsafe partial struct CustomData
    {
        public CustomData
        (
            uint? cCustData = null,
            CustomDataItem* prgCustData = null
        ) : this()
        {
            if (cCustData is not null)
            {
                CCustData = cCustData.Value;
            }

            if (prgCustData is not null)
            {
                PrgCustData = prgCustData;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "cCustData")]
        public uint CCustData;

        [NativeName("Type", "LPCUSTDATAITEM")]
        [NativeName("Type.Name", "LPCUSTDATAITEM")]
        [NativeName("Name", "prgCustData")]
        public CustomDataItem* PrgCustData;
    }
}
