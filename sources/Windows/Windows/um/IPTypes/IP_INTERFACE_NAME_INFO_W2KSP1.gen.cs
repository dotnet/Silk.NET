// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1"]/*'/>
public partial struct IP_INTERFACE_NAME_INFO_W2KSP1
{
    /// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1.Index"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Index;
    /// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1.MediaType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MediaType;
    /// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1.ConnectionType"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte ConnectionType;
    /// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1.AccessType"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte AccessType;
    /// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1.DeviceGuid"]/*'/>
    public Guid DeviceGuid;
    /// <include file='IP_INTERFACE_NAME_INFO_W2KSP1.xml' path='doc/member[@name="IP_INTERFACE_NAME_INFO_W2KSP1.InterfaceGuid"]/*'/>
    public Guid InterfaceGuid;
}