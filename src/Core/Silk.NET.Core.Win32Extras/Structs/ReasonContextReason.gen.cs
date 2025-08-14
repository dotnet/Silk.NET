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
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    [NativeName("Name", "__AnonymousRecord_minwinbase_L276_C5")]
    public unsafe partial struct ReasonContextReason
    {
        public ReasonContextReason
        (
            ReasonContextReasonDetailed? detailed = null,
            char* simpleReasonString = null
        ) : this()
        {
            if (detailed is not null)
            {
                Detailed = detailed.Value;
            }

            if (simpleReasonString is not null)
            {
                SimpleReasonString = simpleReasonString;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:277:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:277:9)")]
        [NativeName("Name", "Detailed")]
        public ReasonContextReasonDetailed Detailed;

        [FieldOffset(0)]
        [NativeName("Type", "LPWSTR")]
        [NativeName("Type.Name", "LPWSTR")]
        [NativeName("Name", "SimpleReasonString")]
        public char* SimpleReasonString;
    }
}
