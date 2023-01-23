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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHDETW_CREATEVIDEOPROCESSOR")]
    public unsafe partial struct HdetwCreatevideoprocessor
    {
        public HdetwCreatevideoprocessor
        (
            ulong? pObject = null,
            ulong? pD3D9Ex = null,
            Guid? vPGuid = null
        ) : this()
        {
            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (pD3D9Ex is not null)
            {
                PD3D9Ex = pD3D9Ex.Value;
            }

            if (vPGuid is not null)
            {
                VPGuid = vPGuid.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pD3D9Ex")]
        public ulong PD3D9Ex;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "VPGuid")]
        public Guid VPGuid;
    }
}
