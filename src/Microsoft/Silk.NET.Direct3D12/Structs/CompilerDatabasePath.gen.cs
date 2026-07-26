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
    [NativeName("Name", "D3D12_COMPILER_DATABASE_PATH")]
    public unsafe partial struct CompilerDatabasePath
    {
        public CompilerDatabasePath
        (
            CompilerValueTypeFlags? types = null,
            char* pPath = null
        ) : this()
        {
            if (types is not null)
            {
                Types = types.Value;
            }

            if (pPath is not null)
            {
                PPath = pPath;
            }
        }


        [NativeName("Type", "D3D12_COMPILER_VALUE_TYPE_FLAGS")]
        [NativeName("Type.Name", "D3D12_COMPILER_VALUE_TYPE_FLAGS")]
        [NativeName("Name", "Types")]
        public CompilerValueTypeFlags Types;

        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "pPath")]
        public char* PPath;
    }
}
