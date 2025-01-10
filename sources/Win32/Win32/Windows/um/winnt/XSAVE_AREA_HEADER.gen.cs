// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct XSAVE_AREA_HEADER
{
    [NativeTypeName("DWORD64")]
    public ulong Mask;

    [NativeTypeName("DWORD64")]
    public ulong CompactionMask;

    [NativeTypeName("DWORD64[6]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    [InlineArray(6)]
    public partial struct _Reserved2_e__FixedBuffer
    {
        public ulong e0;
    }
}
