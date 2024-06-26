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
    [NativeName("Name", "_tagpropertykey")]
    public unsafe partial struct Tagpropertykey
    {
        public Tagpropertykey
        (
            Guid? fmtid = null,
            uint? pid = null
        ) : this()
        {
            if (fmtid is not null)
            {
                Fmtid = fmtid.Value;
            }

            if (pid is not null)
            {
                Pid = pid.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "fmtid")]
        public Guid Fmtid;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "pid")]
        public uint Pid;
    }
}
