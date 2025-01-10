// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_POWER_LEVEL
{
    [NativeTypeName("BOOLEAN")]
    public byte Enable;

    [NativeTypeName("BYTE[3]")]
    public _Spare_e__FixedBuffer Spare;

    [NativeTypeName("DWORD")]
    public uint BatteryLevel;
    public POWER_ACTION_POLICY PowerPolicy;
    public SYSTEM_POWER_STATE MinSystemState;

    [InlineArray(3)]
    public partial struct _Spare_e__FixedBuffer
    {
        public byte e0;
    }
}
