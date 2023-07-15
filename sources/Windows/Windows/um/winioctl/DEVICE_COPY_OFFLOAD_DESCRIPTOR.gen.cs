// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct DEVICE_COPY_OFFLOAD_DESCRIPTOR
{
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.MaximumTokenLifetime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumTokenLifetime;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.DefaultTokenLifetime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DefaultTokenLifetime;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.MaximumTransferSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong MaximumTransferSize;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.OptimalTransferCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong OptimalTransferCount;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.MaximumDataDescriptors"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumDataDescriptors;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.MaximumTransferLengthPerDescriptor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumTransferLengthPerDescriptor;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.OptimalTransferLengthPerDescriptor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OptimalTransferLengthPerDescriptor;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.OptimalTransferLengthGranularity"]/*'/>
    [NativeTypeName("WORD")]
    public ushort OptimalTransferLengthGranularity;
    /// <include file='DEVICE_COPY_OFFLOAD_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_COPY_OFFLOAD_DESCRIPTOR.Reserved"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved[2];
}