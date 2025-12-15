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
    [NativeName("Name", "D3D12_IB_STRIP_CUT_VALUE")]
    public unsafe partial struct IBStripCutValue
    {
        public IBStripCutValue
        (
            IndexBufferStripCutValue? indexBufferStripCutValue = null
        ) : this()
        {
            if (indexBufferStripCutValue is not null)
            {
                IndexBufferStripCutValue = indexBufferStripCutValue.Value;
            }
        }


        [NativeName("Type", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
        [NativeName("Type.Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
        [NativeName("Name", "IndexBufferStripCutValue")]
        public IndexBufferStripCutValue IndexBufferStripCutValue;
    }
}
