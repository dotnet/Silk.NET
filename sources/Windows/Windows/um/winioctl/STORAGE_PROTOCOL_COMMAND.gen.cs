// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_PROTOCOL_COMMAND
{
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.ProtocolType"]/*'/>
    public STORAGE_PROTOCOL_TYPE ProtocolType;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.ReturnStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReturnStatus;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.ErrorCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ErrorCode;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.CommandLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CommandLength;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.ErrorInfoLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ErrorInfoLength;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.DataToDeviceTransferLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataToDeviceTransferLength;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.DataFromDeviceTransferLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataFromDeviceTransferLength;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.TimeOutValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeOutValue;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.ErrorInfoOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ErrorInfoOffset;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.DataToDeviceBufferOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataToDeviceBufferOffset;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.DataFromDeviceBufferOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataFromDeviceBufferOffset;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.CommandSpecific"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CommandSpecific;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.Reserved0"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved0;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.FixedProtocolReturnData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData;
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.Reserved1"]/*'/>
    [NativeTypeName("DWORD[3]")]
    public fixed uint Reserved1[3];
    /// <include file='STORAGE_PROTOCOL_COMMAND.xml' path='doc/member[@name="STORAGE_PROTOCOL_COMMAND.Command"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Command[1];
}