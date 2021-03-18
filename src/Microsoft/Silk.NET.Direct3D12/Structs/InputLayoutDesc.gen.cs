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
    [NativeName("Name", "D3D12_INPUT_LAYOUT_DESC")]
    public unsafe partial struct InputLayoutDesc
    {
        public InputLayoutDesc
        (
            InputElementDesc* pInputElementDescs = null,
            uint? numElements = null
        ) : this()
        {
            if (pInputElementDescs is not null)
            {
                PInputElementDescs = pInputElementDescs;
            }

            if (numElements is not null)
            {
                NumElements = numElements.Value;
            }
        }


        [NativeName("Type", "const D3D12_INPUT_ELEMENT_DESC *")]
        [NativeName("Type.Name", "const D3D12_INPUT_ELEMENT_DESC *")]
        [NativeName("Name", "pInputElementDescs")]
        public InputElementDesc* PInputElementDescs;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumElements")]
        public uint NumElements;
    }
}
