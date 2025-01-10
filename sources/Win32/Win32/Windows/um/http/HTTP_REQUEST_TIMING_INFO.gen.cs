// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_REQUEST_TIMING_INFO
{
    [NativeTypeName("ULONG")]
    public uint RequestTimingCount;

    [NativeTypeName("ULONGLONG[30]")]
    public _RequestTiming_e__FixedBuffer RequestTiming;

    [InlineArray(30)]
    public partial struct _RequestTiming_e__FixedBuffer
    {
        public ulong e0;
    }
}
