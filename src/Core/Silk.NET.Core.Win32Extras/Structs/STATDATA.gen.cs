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
    [NativeName("Name", "tagSTATDATA")]
    public unsafe partial struct STATDATA
    {
        public STATDATA
        (
            FORMATETC? formatetc = null,
            uint? advf = null,
            IAdviseSink* pAdvSink = null,
            uint? dwConnection = null
        ) : this()
        {
            if (formatetc is not null)
            {
                Formatetc = formatetc.Value;
            }

            if (advf is not null)
            {
                Advf = advf.Value;
            }

            if (pAdvSink is not null)
            {
                PAdvSink = pAdvSink;
            }

            if (dwConnection is not null)
            {
                DwConnection = dwConnection.Value;
            }
        }


        [NativeName("Type", "FORMATETC")]
        [NativeName("Type.Name", "FORMATETC")]
        [NativeName("Name", "formatetc")]
        public FORMATETC Formatetc;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "advf")]
        public uint Advf;

        [NativeName("Type", "IAdviseSink *")]
        [NativeName("Type.Name", "IAdviseSink *")]
        [NativeName("Name", "pAdvSink")]
        public IAdviseSink* PAdvSink;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwConnection")]
        public uint DwConnection;
    }
}
