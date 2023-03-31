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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FILE_FRAGMENT")]
    public unsafe partial struct FileFragment
    {
        public FileFragment
        (
            ulong? fileOffset = null,
            ulong? fragmentSize = null
        ) : this()
        {
            if (fileOffset is not null)
            {
                FileOffset = fileOffset.Value;
            }

            if (fragmentSize is not null)
            {
                FragmentSize = fragmentSize.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "fileOffset")]
        public ulong FileOffset;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "fragmentSize")]
        public ulong FragmentSize;
    }
}
