// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.18362.0")]
public partial struct WINHTTP_REQUEST_TIMES
{
    [NativeTypeName("ULONG")]
    public uint cTimes;

    [NativeTypeName("ULONGLONG[64]")]
    public _rgullTimes_e__FixedBuffer rgullTimes;

    [InlineArray(64)]
    public partial struct _rgullTimes_e__FixedBuffer
    {
        public ulong e0;
    }
}
