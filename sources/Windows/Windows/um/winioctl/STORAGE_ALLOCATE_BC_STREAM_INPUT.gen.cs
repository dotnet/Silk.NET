// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT"]/*'/>
public unsafe partial struct STORAGE_ALLOCATE_BC_STREAM_INPUT
{
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.RequestsPerPeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RequestsPerPeriod;
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.Period"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Period;
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.RetryFailures"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte RetryFailures;
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.Discardable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Discardable;
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.Reserved1"]/*'/>
    [NativeTypeName("BOOLEAN[2]")]
    public fixed byte Reserved1[2];
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.AccessType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AccessType;
    /// <include file='STORAGE_ALLOCATE_BC_STREAM_INPUT.xml' path='doc/member[@name="STORAGE_ALLOCATE_BC_STREAM_INPUT.AccessMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AccessMode;
}