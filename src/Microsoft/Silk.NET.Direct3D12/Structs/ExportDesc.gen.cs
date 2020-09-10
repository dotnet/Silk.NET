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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_EXPORT_DESC")]
    public unsafe partial struct ExportDesc
    {
        public ExportDesc
        (
            char* name = default,
            char* exportToRename = default,
            ExportFlags flags = default
        )
        {
            Name = name;
            ExportToRename = exportToRename;
            Flags = flags;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "ExportToRename")]
        public char* ExportToRename;

        [NativeName("Type", "D3D12_EXPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_EXPORT_FLAGS")]
        [NativeName("Name", "Flags")]
        public ExportFlags Flags;
    }
}
