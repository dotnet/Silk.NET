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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1294_C5")]
    public unsafe partial struct EventTracePropertiesV2Union3
    {
        public EventTracePropertiesV2Union3
        (
            EventTracePropertiesV2Union3Union? anonymous = null,
            ulong? v2Options = null,
            uint? wow = null,
            uint? qpcDeltaTracking = null,
            uint? largeMdlPages = null,
            uint? excludeKernelStack = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (v2Options is not null)
            {
                V2Options = v2Options.Value;
            }

            if (wow is not null)
            {
                Wow = wow.Value;
            }

            if (qpcDeltaTracking is not null)
            {
                QpcDeltaTracking = qpcDeltaTracking.Value;
            }

            if (largeMdlPages is not null)
            {
                LargeMdlPages = largeMdlPages.Value;
            }

            if (excludeKernelStack is not null)
            {
                ExcludeKernelStack = excludeKernelStack.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L1295_C9")]
        [NativeName("Name", "anonymous1")]
        public EventTracePropertiesV2Union3Union Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG64")]
        [NativeName("Type.Name", "ULONG64")]
        [NativeName("Name", "V2Options")]
        public ulong V2Options;
        public uint Wow
        {
            get => Anonymous.Wow;
            set => Anonymous.Wow = value;
        }

        public uint QpcDeltaTracking
        {
            get => Anonymous.QpcDeltaTracking;
            set => Anonymous.QpcDeltaTracking = value;
        }

        public uint LargeMdlPages
        {
            get => Anonymous.LargeMdlPages;
            set => Anonymous.LargeMdlPages = value;
        }

        public uint ExcludeKernelStack
        {
            get => Anonymous.ExcludeKernelStack;
            set => Anonymous.ExcludeKernelStack = value;
        }

    }
}
