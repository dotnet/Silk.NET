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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_FLAGGED_WORD_BLOB")]
    public unsafe partial struct FlaggedWordBlob
    {
        public FlaggedWordBlob
        (
            uint? fFlags = null,
            uint? clSize = null
        ) : this()
        {
            if (fFlags is not null)
            {
                FFlags = fFlags.Value;
            }

            if (clSize is not null)
            {
                ClSize = clSize.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "fFlags")]
        public uint FFlags;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "clSize")]
        public uint ClSize;
        [NativeName("Type", "unsigned short[1]")]
        [NativeName("Type.Name", "unsigned short[1]")]
        [NativeName("Name", "asData")]
        public fixed ushort AsData[1];
    }
}
