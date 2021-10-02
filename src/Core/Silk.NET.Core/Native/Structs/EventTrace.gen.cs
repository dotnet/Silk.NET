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

namespace Silk.NET.Core.Native
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
            uint? mofLength = null
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
    }
}
