// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEDUP_CONTAINER_EXTENT.xml' path='doc/member[@name="DEDUP_CONTAINER_EXTENT"]/*'/>
public partial struct DEDUP_CONTAINER_EXTENT
{
    /// <include file='DEDUP_CONTAINER_EXTENT.xml' path='doc/member[@name="DEDUP_CONTAINER_EXTENT.ContainerIndex"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ContainerIndex;
    /// <include file='DEDUP_CONTAINER_EXTENT.xml' path='doc/member[@name="DEDUP_CONTAINER_EXTENT.StartOffset"]/*'/>
    [NativeTypeName("long long")]
    public long StartOffset;
    /// <include file='DEDUP_CONTAINER_EXTENT.xml' path='doc/member[@name="DEDUP_CONTAINER_EXTENT.Length"]/*'/>
    [NativeTypeName("long long")]
    public long Length;
}