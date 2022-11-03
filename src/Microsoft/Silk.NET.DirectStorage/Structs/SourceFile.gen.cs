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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_SOURCE_FILE")]
    public unsafe partial struct SourceFile
    {
        public SourceFile
        (
            IDStorageFile* source = null,
            ulong? offset = null,
            uint? size = null
        ) : this()
        {
            if (source is not null)
            {
                Source = source;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }


        [NativeName("Type", "IDStorageFile *")]
        [NativeName("Type.Name", "IDStorageFile *")]
        [NativeName("Name", "Source")]
        public IDStorageFile* Source;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Offset")]
        public ulong Offset;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Size")]
        public uint Size;
    }
}
