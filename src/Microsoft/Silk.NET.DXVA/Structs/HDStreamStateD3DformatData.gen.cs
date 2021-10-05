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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_D3DFORMAT_DATA")]
    public unsafe partial struct HDStreamStateD3DformatData
    {
        public HDStreamStateD3DformatData
        (
            Silk.NET.Direct3D9.Format? format = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.Direct3D9.Format Format;
    }
}
