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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEX2DMS_SRV")]
    public unsafe partial struct Tex2DmsSrv
    {
        public Tex2DmsSrv
        (
            uint? unusedFieldNothingToDefine = null
        ) : this()
        {
            if (unusedFieldNothingToDefine is not null)
            {
                UnusedFieldNothingToDefine = unusedFieldNothingToDefine.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "UnusedField_NothingToDefine")]
        public uint UnusedFieldNothingToDefine;
    }
}
