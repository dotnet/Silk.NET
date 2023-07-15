// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2"]/*'/>
public partial struct CSV_QUERY_MDS_PATH_V2
{
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.Version"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Version;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.RequiredSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RequiredSize;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.MdsNodeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MdsNodeId;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.DsNodeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DsNodeId;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.DiskConnectivity"]/*'/>
    public CSVFS_DISK_CONNECTIVITY DiskConnectivity;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.VolumeId"]/*'/>
    public Guid VolumeId;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.IpAddressOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IpAddressOffset;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.IpAddressLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IpAddressLength;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.PathOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PathOffset;
    /// <include file='CSV_QUERY_MDS_PATH_V2.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH_V2.PathLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PathLength;
}