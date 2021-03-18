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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATE_OBJECT_DESC")]
    public unsafe partial struct StateObjectDesc
    {
        public StateObjectDesc
        (
            StateObjectType? type = null,
            uint? numSubobjects = null,
            StateSubobject* pSubobjects = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (numSubobjects is not null)
            {
                NumSubobjects = numSubobjects.Value;
            }

            if (pSubobjects is not null)
            {
                PSubobjects = pSubobjects;
            }
        }


        [NativeName("Type", "D3D12_STATE_OBJECT_TYPE")]
        [NativeName("Type.Name", "D3D12_STATE_OBJECT_TYPE")]
        [NativeName("Name", "Type")]
        public StateObjectType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSubobjects")]
        public uint NumSubobjects;

        [NativeName("Type", "const D3D12_STATE_SUBOBJECT *")]
        [NativeName("Type.Name", "const D3D12_STATE_SUBOBJECT *")]
        [NativeName("Name", "pSubobjects")]
        public StateSubobject* PSubobjects;
    }
}
