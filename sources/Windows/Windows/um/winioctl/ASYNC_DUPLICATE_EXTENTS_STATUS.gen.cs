// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS"]/*'/>
public partial struct ASYNC_DUPLICATE_EXTENTS_STATUS
{
    /// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS.State"]/*'/>
    public DUPLICATE_EXTENTS_STATE State;
    /// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS.SourceFileOffset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong SourceFileOffset;
    /// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS.TargetFileOffset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TargetFileOffset;
    /// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS.ByteCount"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ByteCount;
    /// <include file='ASYNC_DUPLICATE_EXTENTS_STATUS.xml' path='doc/member[@name="ASYNC_DUPLICATE_EXTENTS_STATUS.BytesDuplicated"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BytesDuplicated;
}