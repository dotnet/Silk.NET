// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiExportFormatDesc")]
    public unsafe partial struct ExportFormatDesc
    {
        public ExportFormatDesc
        (
            byte* id = default,
            byte* description = default,
            byte* fileExtension = default
        )
        {
            Id = id;
            Description = description;
            FileExtension = fileExtension;
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "id")]
        public byte* Id;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "description")]
        public byte* Description;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "fileExtension")]
        public byte* FileExtension;
    }
}
