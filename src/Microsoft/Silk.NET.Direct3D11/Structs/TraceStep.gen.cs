// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint iD = default,
            int instructionActive = default,
            byte numRegistersWritten = default,
            byte numRegistersRead = default,
            ushort miscOperations = default,
            uint opcodeType = default,
            ulong currentGlobalCycle = default
        )
        {
            ID = iD;
            InstructionActive = instructionActive;
            NumRegistersWritten = numRegistersWritten;
            NumRegistersRead = numRegistersRead;
            MiscOperations = miscOperations;
            OpcodeType = opcodeType;
            CurrentGlobalCycle = currentGlobalCycle;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ID")]
        public uint ID;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InstructionActive")]
        public int InstructionActive;

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
