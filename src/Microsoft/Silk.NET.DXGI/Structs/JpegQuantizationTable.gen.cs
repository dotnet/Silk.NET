// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_JPEG_QUANTIZATION_TABLE")]
    public unsafe partial struct JpegQuantizationTable
    {
        [NativeName("Type", "BYTE [64]")]
        [NativeName("Type.Name", "BYTE [64]")]
        [NativeName("Name", "Elements")]
        public fixed byte Elements[64];
    }
}
