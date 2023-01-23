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
    [NativeName("Name", "_TRACE_GUID_PROPERTIES")]
    public unsafe partial struct TraceGuidProperties
    {
        public TraceGuidProperties
        (
            Guid? guid = null,
            uint? guidType = null,
            uint? loggerId = null,
            uint? enableLevel = null,
            uint? enableFlags = null,
            byte? isEnable = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (guidType is not null)
            {
                GuidType = guidType.Value;
            }

            if (loggerId is not null)
            {
                LoggerId = loggerId.Value;
            }

            if (enableLevel is not null)
            {
                EnableLevel = enableLevel.Value;
            }

            if (enableFlags is not null)
            {
                EnableFlags = enableFlags.Value;
            }

            if (isEnable is not null)
            {
                IsEnable = isEnable.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Guid")]
        public Guid Guid;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "GuidType")]
        public uint GuidType;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "LoggerId")]
        public uint LoggerId;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EnableLevel")]
        public uint EnableLevel;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "EnableFlags")]
        public uint EnableFlags;

        [NativeName("Type", "BOOLEAN")]
        [NativeName("Type.Name", "BOOLEAN")]
        [NativeName("Name", "IsEnable")]
        public byte IsEnable;
    }
}
