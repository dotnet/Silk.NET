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
    [NativeName("Name", "_ENABLE_TRACE_PARAMETERS_V1")]
    public unsafe partial struct EnableTraceParametersV1
    {
        public EnableTraceParametersV1
        (
            uint? version = null,
            uint? enableProperty = null,
            uint? controlFlags = null,
            Guid? sourceId = null,
            EventFilterDescriptor* enableFilterDesc = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (enableProperty is not null)
            {
                EnableProperty = enableProperty.Value;
            }

            if (controlFlags is not null)
            {
                ControlFlags = controlFlags.Value;
            }

            if (sourceId is not null)
            {
                SourceId = sourceId.Value;
            }

            if (enableFilterDesc is not null)
            {
                EnableFilterDesc = enableFilterDesc;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Version")]
        public uint Version;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EnableProperty")]
        public uint EnableProperty;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ControlFlags")]
        public uint ControlFlags;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "SourceId")]
        public Guid SourceId;

        [NativeName("Type", "PEVENT_FILTER_DESCRIPTOR")]
        [NativeName("Type.Name", "PEVENT_FILTER_DESCRIPTOR")]
        [NativeName("Name", "EnableFilterDesc")]
        public EventFilterDescriptor* EnableFilterDesc;
    }
}
