// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AXESLISTA
{
    [NativeTypeName("DWORD")]
    public uint axlReserved;

    [NativeTypeName("DWORD")]
    public uint axlNumAxes;

    [NativeTypeName("AXISINFOA[16]")]
    public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

    [InlineArray(16)]
    public partial struct _axlAxisInfo_e__FixedBuffer
    {
        public AXISINFOA e0;
    }
}
