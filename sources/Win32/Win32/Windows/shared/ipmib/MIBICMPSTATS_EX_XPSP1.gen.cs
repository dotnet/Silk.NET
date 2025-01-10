// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIBICMPSTATS_EX_XPSP1
{
    [NativeTypeName("DWORD")]
    public uint dwMsgs;

    [NativeTypeName("DWORD")]
    public uint dwErrors;

    [NativeTypeName("DWORD[256]")]
    public _rgdwTypeCount_e__FixedBuffer rgdwTypeCount;

    [InlineArray(256)]
    public partial struct _rgdwTypeCount_e__FixedBuffer
    {
        public uint e0;
    }
}
