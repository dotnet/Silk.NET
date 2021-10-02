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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L715_C5")]
    public unsafe partial struct TraceLogfileHeaderUnion2
    {
        public TraceLogfileHeaderUnion2
        (
            Guid? logInstanceGuid = null
        ) : this()
        {
            if (logInstanceGuid is not null)
            {
                LogInstanceGuid = logInstanceGuid.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "LogInstanceGuid")]
        public Guid LogInstanceGuid;
    }
}
