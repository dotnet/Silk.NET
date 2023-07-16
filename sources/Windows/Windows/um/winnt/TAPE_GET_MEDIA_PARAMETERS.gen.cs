// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TAPE_GET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_MEDIA_PARAMETERS"]/*'/>
public partial struct TAPE_GET_MEDIA_PARAMETERS
{
    /// <include file='TAPE_GET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_MEDIA_PARAMETERS.Capacity"]/*'/>
    public LARGE_INTEGER Capacity;
    /// <include file='TAPE_GET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_MEDIA_PARAMETERS.Remaining"]/*'/>
    public LARGE_INTEGER Remaining;
    /// <include file='TAPE_GET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_MEDIA_PARAMETERS.BlockSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BlockSize;
    /// <include file='TAPE_GET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_MEDIA_PARAMETERS.PartitionCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PartitionCount;
    /// <include file='TAPE_GET_MEDIA_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_MEDIA_PARAMETERS.WriteProtected"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte WriteProtected;
}