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
    [NativeName("Name", "TRACE_CONTEXT_REGISTER_INFO")]
    public unsafe partial struct TraceContextRegisterInfo
    {
        public TraceContextRegisterInfo
        (
            EtwContextRegisterTypes? registerTypes = null,
            uint? reserved = null
        ) : this()
        {
            if (registerTypes is not null)
            {
                RegisterTypes = registerTypes.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "ETW_CONTEXT_REGISTER_TYPES")]
        [NativeName("Type.Name", "ETW_CONTEXT_REGISTER_TYPES")]
        [NativeName("Name", "RegisterTypes")]
        public EtwContextRegisterTypes RegisterTypes;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;
    }
}
