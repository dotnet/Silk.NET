// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE"]/*'/>
public unsafe partial struct DVTARGETDEVICE
{
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint tdSize;
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdDriverNameOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort tdDriverNameOffset;
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdDeviceNameOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort tdDeviceNameOffset;
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdPortNameOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort tdPortNameOffset;
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdExtDevmodeOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort tdExtDevmodeOffset;
    /// <include file='DVTARGETDEVICE.xml' path='doc/member[@name="DVTARGETDEVICE.tdData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte tdData[1];
}