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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_GENERIC_PROGRAM_DESC")]
    public unsafe partial struct GenericProgramDesc
    {
        public GenericProgramDesc
        (
            char* programName = null,
            uint? numExports = null,
            char** pExports = null,
            uint? numSubobjects = null,
            StateSubobject** ppSubobjects = null
        ) : this()
        {
            if (programName is not null)
            {
                ProgramName = programName;
            }

            if (numExports is not null)
            {
                NumExports = numExports.Value;
            }

            if (pExports is not null)
            {
                PExports = pExports;
            }

            if (numSubobjects is not null)
            {
                NumSubobjects = numSubobjects.Value;
            }

            if (ppSubobjects is not null)
            {
                PpSubobjects = ppSubobjects;
            }
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "ProgramName")]
        public char* ProgramName;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumExports")]
        public uint NumExports;

        [NativeName("Type", "LPCWSTR *")]
        [NativeName("Type.Name", "LPCWSTR *")]
        [NativeName("Name", "pExports")]
        public char** PExports;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSubobjects")]
        public uint NumSubobjects;

        [NativeName("Type", "const D3D12_STATE_SUBOBJECT *const *")]
        [NativeName("Type.Name", "const D3D12_STATE_SUBOBJECT *const *")]
        [NativeName("Name", "ppSubobjects")]
        public StateSubobject** PpSubobjects;
    }
}
