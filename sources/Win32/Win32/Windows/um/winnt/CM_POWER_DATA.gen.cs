// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CM_POWER_DATA
{
    [NativeTypeName("DWORD")]
    public uint PD_Size;
    public DEVICE_POWER_STATE PD_MostRecentPowerState;

    [NativeTypeName("DWORD")]
    public uint PD_Capabilities;

    [NativeTypeName("DWORD")]
    public uint PD_D1Latency;

    [NativeTypeName("DWORD")]
    public uint PD_D2Latency;

    [NativeTypeName("DWORD")]
    public uint PD_D3Latency;

    [NativeTypeName("DEVICE_POWER_STATE[7]")]
    public _PD_PowerStateMapping_e__FixedBuffer PD_PowerStateMapping;
    public SYSTEM_POWER_STATE PD_DeepestSystemWake;

    [InlineArray(7)]
    public partial struct _PD_PowerStateMapping_e__FixedBuffer
    {
        public DEVICE_POWER_STATE e0;
    }
}
