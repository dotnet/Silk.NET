// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_PROTOCOL_SPECIFIC_DATA
{
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolType"]/*'/>
    public STORAGE_PROTOCOL_TYPE ProtocolType;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.DataType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataType;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataRequestValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataRequestValue;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataRequestSubValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataRequestSubValue;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataOffset;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataLength;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.FixedProtocolReturnData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataRequestSubValue2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataRequestSubValue2;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataRequestSubValue3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataRequestSubValue3;
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA.ProtocolDataRequestSubValue4"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ProtocolDataRequestSubValue4;
}