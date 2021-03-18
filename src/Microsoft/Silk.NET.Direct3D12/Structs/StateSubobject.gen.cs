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
    [NativeName("Name", "D3D12_STATE_SUBOBJECT")]
    public unsafe partial struct StateSubobject
    {
        public StateSubobject
        (
            StateSubobjectType? type = null,
            void* pDesc = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (pDesc is not null)
            {
                PDesc = pDesc;
            }
        }


        [NativeName("Type", "D3D12_STATE_SUBOBJECT_TYPE")]
        [NativeName("Type.Name", "D3D12_STATE_SUBOBJECT_TYPE")]
        [NativeName("Name", "Type")]
        public StateSubobjectType Type;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pDesc")]
        public void* PDesc;
    }
}
