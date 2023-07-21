// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6"]/*' />
public unsafe partial struct DIEFFECT_DX6
{
    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwDuration"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDuration;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwSamplePeriod"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSamplePeriod;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwGain"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGain;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwTriggerButton"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTriggerButton;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwTriggerRepeatInterval"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTriggerRepeatInterval;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.cAxes"]/*' />
    [NativeTypeName("DWORD")]
    public uint cAxes;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.rgdwAxes"]/*' />
    [NativeTypeName("LPDWORD")]
    public uint* rgdwAxes;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.rglDirection"]/*' />
    [NativeTypeName("LPLONG")]
    public int* rglDirection;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.lpEnvelope"]/*' />
    [NativeTypeName("LPDIENVELOPE")]
    public DIENVELOPE* lpEnvelope;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.cbTypeSpecificParams"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbTypeSpecificParams;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.lpvTypeSpecificParams"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpvTypeSpecificParams;

    /// <include file='DIEFFECT_DX6.xml' path='doc/member[@name="DIEFFECT_DX6.dwStartDelay"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStartDelay;
}
