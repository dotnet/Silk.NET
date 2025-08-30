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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1608_C5")]
    public unsafe partial struct EventTraceLogfilewUnion2
    {
        public EventTraceLogfilewUnion2
        (
            PfnPeventCallback? eventCallback = null,
            PfnPeventRecordCallback? eventRecordCallback = null
        ) : this()
        {
            if (eventCallback is not null)
            {
                EventCallback = eventCallback.Value;
            }

            if (eventRecordCallback is not null)
            {
                EventRecordCallback = eventRecordCallback.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "PEVENT_CALLBACK")]
        [NativeName("Type.Name", "PEVENT_CALLBACK")]
        [NativeName("Name", "EventCallback")]
        public PfnPeventCallback EventCallback;

        [FieldOffset(0)]
        [NativeName("Type", "PEVENT_RECORD_CALLBACK")]
        [NativeName("Type.Name", "PEVENT_RECORD_CALLBACK")]
        [NativeName("Name", "EventRecordCallback")]
        public PfnPeventRecordCallback EventRecordCallback;
    }
}
