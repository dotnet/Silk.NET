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
    [NativeName("Name", "_EVENT_TRACE")]
    public unsafe partial struct EventTrace
    {
        public EventTrace
        (
            EventTraceHeader? header = null,
            uint? instanceId = null,
            uint? parentInstanceId = null,
            Guid? parentGuid = null,
            void* mofData = null,
            uint? mofLength = null,
            EventTraceUnion? anonymous = null,
            uint? clientContext = null,
            EtwBufferContext? bufferContext = null
        ) : this()
        {
            if (header is not null)
            {
                Header = header.Value;
            }

            if (instanceId is not null)
            {
                InstanceId = instanceId.Value;
            }

            if (parentInstanceId is not null)
            {
                ParentInstanceId = parentInstanceId.Value;
            }

            if (parentGuid is not null)
            {
                ParentGuid = parentGuid.Value;
            }

            if (mofData is not null)
            {
                MofData = mofData;
            }

            if (mofLength is not null)
            {
                MofLength = mofLength.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (clientContext is not null)
            {
                ClientContext = clientContext.Value;
            }

            if (bufferContext is not null)
            {
                BufferContext = bufferContext.Value;
            }
        }


        [NativeName("Type", "EVENT_TRACE_HEADER")]
        [NativeName("Type.Name", "EVENT_TRACE_HEADER")]
        [NativeName("Name", "Header")]
        public EventTraceHeader Header;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "InstanceId")]
        public uint InstanceId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ParentInstanceId")]
        public uint ParentInstanceId;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "ParentGuid")]
        public Guid ParentGuid;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "MofData")]
        public void* MofData;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "MofLength")]
        public uint MofLength;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1464_C5")]
        [NativeName("Name", "anonymous1")]
        public EventTraceUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint ClientContext
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].ClientContext;
        }
#else
        public uint ClientContext
        {
            get => Anonymous.ClientContext;
            set => Anonymous.ClientContext = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref EtwBufferContext BufferContext
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].BufferContext;
        }
#else
        public EtwBufferContext BufferContext
        {
            get => Anonymous.BufferContext;
            set => Anonymous.BufferContext = value;
        }
#endif

    }
}
