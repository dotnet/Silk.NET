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
    [NativeName("Name", "D3D11_TRACE_REGISTER")]
    public unsafe partial struct TraceRegister
    {
        public TraceRegister
        (
            TraceRegisterType? regType = null,
            TraceRegisterUnion? anonymous = null,
            byte? operandIndex = null,
            byte? flags = null,
            ushort? index1D = null
        ) : this()
        {
            if (regType is not null)
            {
                RegType = regType.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (operandIndex is not null)
            {
                OperandIndex = operandIndex.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (index1D is not null)
            {
                Index1D = index1D.Value;
            }
        }


        [NativeName("Type", "D3D11_TRACE_REGISTER_TYPE")]
        [NativeName("Type.Name", "D3D11_TRACE_REGISTER_TYPE")]
        [NativeName("Name", "RegType")]
        public TraceRegisterType RegType;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11shadertracing_L234_C5")]
        [NativeName("Name", "anonymous1")]
        public TraceRegisterUnion Anonymous;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "OperandIndex")]
        public byte OperandIndex;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "Flags")]
        public byte Flags;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort Index1D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Index1D;
        }
#else
        public ushort Index1D
        {
            get => Anonymous.Index1D;
            set => Anonymous.Index1D = value;
        }
#endif

    }
}
