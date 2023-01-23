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
    [NativeName("Name", "D3D11_TRACE_STEP")]
    public unsafe partial struct TraceStep
    {
        public TraceStep
        (
            uint? iD = null,
            Silk.NET.Core.Bool32? instructionActive = null,
            byte? numRegistersWritten = null,
            byte? numRegistersRead = null,
            ushort? miscOperations = null,
            uint? opcodeType = null,
            ulong? currentGlobalCycle = null
        ) : this()
        {
            if (iD is not null)
            {
                ID = iD.Value;
            }

            if (instructionActive is not null)
            {
                InstructionActive = instructionActive.Value;
            }

            if (numRegistersWritten is not null)
            {
                NumRegistersWritten = numRegistersWritten.Value;
            }

            if (numRegistersRead is not null)
            {
                NumRegistersRead = numRegistersRead.Value;
            }

            if (miscOperations is not null)
            {
                MiscOperations = miscOperations.Value;
            }

            if (opcodeType is not null)
            {
                OpcodeType = opcodeType.Value;
            }

            if (currentGlobalCycle is not null)
            {
                CurrentGlobalCycle = currentGlobalCycle.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ID")]
        public uint ID;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InstructionActive")]
        public Silk.NET.Core.Bool32 InstructionActive;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "NumRegistersWritten")]
        public byte NumRegistersWritten;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "NumRegistersRead")]
        public byte NumRegistersRead;

        [NativeName("Type", "D3D11_TRACE_MISC_OPERATIONS_MASK")]
        [NativeName("Type.Name", "D3D11_TRACE_MISC_OPERATIONS_MASK")]
        [NativeName("Name", "MiscOperations")]
        public ushort MiscOperations;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OpcodeType")]
        public uint OpcodeType;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CurrentGlobalCycle")]
        public ulong CurrentGlobalCycle;
    }
}
