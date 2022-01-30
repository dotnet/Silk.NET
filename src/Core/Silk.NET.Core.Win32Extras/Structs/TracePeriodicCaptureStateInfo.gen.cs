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
    [NativeName("Name", "_TRACE_PERIODIC_CAPTURE_STATE_INFO")]
    public unsafe partial struct TracePeriodicCaptureStateInfo
    {
        public TracePeriodicCaptureStateInfo
        (
            uint? captureStateFrequencyInSeconds = null,
            ushort? providerCount = null,
            ushort? reserved = null
        ) : this()
        {
            if (captureStateFrequencyInSeconds is not null)
            {
                CaptureStateFrequencyInSeconds = captureStateFrequencyInSeconds.Value;
            }

            if (providerCount is not null)
            {
                ProviderCount = providerCount.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "CaptureStateFrequencyInSeconds")]
        public uint CaptureStateFrequencyInSeconds;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "ProviderCount")]
        public ushort ProviderCount;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Reserved")]
        public ushort Reserved;
    }
}
