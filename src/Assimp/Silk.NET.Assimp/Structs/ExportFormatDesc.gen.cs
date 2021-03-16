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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiExportFormatDesc")]
    public unsafe partial struct ExportFormatDesc
    {
        public ExportFormatDesc
        (
            byte* id = null,
            byte* description = null,
            byte* fileExtension = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id;
            }

            if (description is not null)
            {
                Description = description;
            }

            if (fileExtension is not null)
            {
                FileExtension = fileExtension;
            }
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
