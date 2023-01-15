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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_VALUE")]
    public unsafe partial struct TraceValue
    {
        public TraceValue
        (
            byte? validMask = null
        ) : this()
        {
            if (validMask is not null)
            {
                ValidMask = validMask.Value;
            }
        }

        [NativeName("Type", "UINT[4]")]
        [NativeName("Type.Name", "UINT[4]")]
        [NativeName("Name", "Bits")]
        public fixed uint Bits[4];

        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK")]
        [NativeName("Name", "ValidMask")]
        public byte ValidMask;
    }
}
