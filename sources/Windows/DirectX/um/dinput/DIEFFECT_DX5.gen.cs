// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5"]/*'/>
public unsafe partial struct DIEFFECT_DX5
{
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwDuration"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDuration;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwSamplePeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSamplePeriod;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwGain"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGain;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwTriggerButton"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTriggerButton;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.dwTriggerRepeatInterval"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTriggerRepeatInterval;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.cAxes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAxes;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.rgdwAxes"]/*'/>
    [NativeTypeName("LPDWORD")]
    public uint* rgdwAxes;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.rglDirection"]/*'/>
    [NativeTypeName("LPLONG")]
    public int* rglDirection;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.lpEnvelope"]/*'/>
    [NativeTypeName("LPDIENVELOPE")]
    public DIENVELOPE* lpEnvelope;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.cbTypeSpecificParams"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbTypeSpecificParams;
    /// <include file='DIEFFECT_DX5.xml' path='doc/member[@name="DIEFFECT_DX5.lpvTypeSpecificParams"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpvTypeSpecificParams;
}