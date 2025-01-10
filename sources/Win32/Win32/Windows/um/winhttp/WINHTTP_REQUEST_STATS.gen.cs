// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.18362.0")]
public partial struct WINHTTP_REQUEST_STATS
{
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;

    [NativeTypeName("ULONG")]
    public uint ulIndex;

    [NativeTypeName("ULONG")]
    public uint cStats;

    [NativeTypeName("ULONGLONG[32]")]
    public _rgullStats_e__FixedBuffer rgullStats;

    [InlineArray(32)]
    public partial struct _rgullStats_e__FixedBuffer
    {
        public ulong e0;
    }
}
