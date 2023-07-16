// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_READ_CAPACITY.xml' path='doc/member[@name="STORAGE_READ_CAPACITY"]/*'/>
public partial struct STORAGE_READ_CAPACITY
{
    /// <include file='STORAGE_READ_CAPACITY.xml' path='doc/member[@name="STORAGE_READ_CAPACITY.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_READ_CAPACITY.xml' path='doc/member[@name="STORAGE_READ_CAPACITY.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_READ_CAPACITY.xml' path='doc/member[@name="STORAGE_READ_CAPACITY.BlockLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BlockLength;
    /// <include file='STORAGE_READ_CAPACITY.xml' path='doc/member[@name="STORAGE_READ_CAPACITY.NumberOfBlocks"]/*'/>
    public LARGE_INTEGER NumberOfBlocks;
    /// <include file='STORAGE_READ_CAPACITY.xml' path='doc/member[@name="STORAGE_READ_CAPACITY.DiskLength"]/*'/>
    public LARGE_INTEGER DiskLength;
}