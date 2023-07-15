// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS"]/*'/>
public partial struct DIDEVCAPS
{
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwDevType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDevType;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwAxes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAxes;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwButtons"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwButtons;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwPOVs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPOVs;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwFFSamplePeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFFSamplePeriod;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwFFMinTimeResolution"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFFMinTimeResolution;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwFirmwareRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFirmwareRevision;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwHardwareRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHardwareRevision;
    /// <include file='DIDEVCAPS.xml' path='doc/member[@name="DIDEVCAPS.dwFFDriverVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFFDriverVersion;
}