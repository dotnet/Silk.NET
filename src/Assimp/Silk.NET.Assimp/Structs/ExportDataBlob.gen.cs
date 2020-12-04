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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiExportDataBlob")]
    public unsafe partial struct ExportDataBlob
    {
        public ExportDataBlob
        (
            uint? size = null,
            void* data = null,
            AssimpString? name = null,
            ExportDataBlob* next = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (data is not null)
            {
                Data = data;
            }

            if (name is not null)
            {
                Name = name.Value;
            }

            if (next is not null)
            {
                Next = next;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "size")]
        public uint Size;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "data")]
        public void* Data;

        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "name")]
        public AssimpString Name;

        [NativeName("Type", "aiExportDataBlob *")]
        [NativeName("Type.Name", "aiExportDataBlob *")]
        [NativeName("Name", "next")]
        public ExportDataBlob* Next;
    }
}
