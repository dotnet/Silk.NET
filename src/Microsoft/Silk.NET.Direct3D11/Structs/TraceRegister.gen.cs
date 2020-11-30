// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_REGISTER")]
    public unsafe partial struct TraceRegister
    {
        public TraceRegister
        (
            TraceRegisterType? regType = null,
            byte? operandIndex = null,
            byte? flags = null
        ) : this()
        {
            if (regType is not null)
            {
                RegType = regType.Value;
            }

            if (operandIndex is not null)
            {
                OperandIndex = operandIndex.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "D3D11_TRACE_REGISTER_TYPE")]
        [NativeName("Type.Name", "D3D11_TRACE_REGISTER_TYPE")]
        [NativeName("Name", "RegType")]
        public TraceRegisterType RegType;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "OperandIndex")]
        public byte OperandIndex;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "Flags")]
        public byte Flags;
    }
}
