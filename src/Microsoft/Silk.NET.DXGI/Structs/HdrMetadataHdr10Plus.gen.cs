// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_HDR_METADATA_HDR10PLUS")]
    public unsafe partial struct HdrMetadataHdr10Plus
    {
        [NativeName("Type", "BYTE [72]")]
        [NativeName("Type.Name", "BYTE [72]")]
        [NativeName("Name", "Data")]
        public fixed byte Data[72];
    }
}
