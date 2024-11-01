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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L1464_C5")]
    public unsafe partial struct EventTraceUnion
    {
        public EventTraceUnion
        (
            uint? clientContext = null,
            EtwBufferContext? bufferContext = null
        ) : this()
        {
            if (clientContext is not null)
            {
                ClientContext = clientContext.Value;
            }

            if (bufferContext is not null)
            {
                BufferContext = bufferContext.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ClientContext")]
        public uint ClientContext;

        [FieldOffset(0)]
        [NativeName("Type", "ETW_BUFFER_CONTEXT")]
        [NativeName("Type.Name", "ETW_BUFFER_CONTEXT")]
        [NativeName("Name", "BufferContext")]
        public EtwBufferContext BufferContext;
    }
}
