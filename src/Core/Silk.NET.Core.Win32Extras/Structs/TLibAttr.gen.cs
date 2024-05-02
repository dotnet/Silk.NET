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
    [NativeName("Name", "tagTLIBATTR")]
    public unsafe partial struct TLibAttr
    {
        public TLibAttr
        (
            Guid? guid = null,
            uint? lcid = null,
            SysKind? syskind = null,
            ushort? wMajorVerNum = null,
            ushort? wMinorVerNum = null,
            ushort? wLibFlags = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (lcid is not null)
            {
                Lcid = lcid.Value;
            }

            if (syskind is not null)
            {
                Syskind = syskind.Value;
            }

            if (wMajorVerNum is not null)
            {
                WMajorVerNum = wMajorVerNum.Value;
            }

            if (wMinorVerNum is not null)
            {
                WMinorVerNum = wMinorVerNum.Value;
            }

            if (wLibFlags is not null)
            {
                WLibFlags = wLibFlags.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guid")]
        public Guid Guid;

        [NativeName("Type", "LCID")]
        [NativeName("Type.Name", "LCID")]
        [NativeName("Name", "lcid")]
        public uint Lcid;

        [NativeName("Type", "SYSKIND")]
        [NativeName("Type.Name", "SYSKIND")]
        [NativeName("Name", "syskind")]
        public SysKind Syskind;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMajorVerNum")]
        public ushort WMajorVerNum;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMinorVerNum")]
        public ushort WMinorVerNum;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wLibFlags")]
        public ushort WLibFlags;
    }
}
