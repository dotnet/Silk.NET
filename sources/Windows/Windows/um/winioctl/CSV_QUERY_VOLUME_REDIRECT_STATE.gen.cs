// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CSV_QUERY_VOLUME_REDIRECT_STATE.xml' path='doc/member[@name="CSV_QUERY_VOLUME_REDIRECT_STATE"]/*' />
public partial struct CSV_QUERY_VOLUME_REDIRECT_STATE
{
    /// <include file='CSV_QUERY_VOLUME_REDIRECT_STATE.xml' path='doc/member[@name="CSV_QUERY_VOLUME_REDIRECT_STATE.MdsNodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint MdsNodeId;

    /// <include file='CSV_QUERY_VOLUME_REDIRECT_STATE.xml' path='doc/member[@name="CSV_QUERY_VOLUME_REDIRECT_STATE.DsNodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DsNodeId;

    /// <include file='CSV_QUERY_VOLUME_REDIRECT_STATE.xml' path='doc/member[@name="CSV_QUERY_VOLUME_REDIRECT_STATE.IsDiskConnected"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IsDiskConnected;

    /// <include file='CSV_QUERY_VOLUME_REDIRECT_STATE.xml' path='doc/member[@name="CSV_QUERY_VOLUME_REDIRECT_STATE.ClusterEnableDirectIo"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ClusterEnableDirectIo;

    /// <include file='CSV_QUERY_VOLUME_REDIRECT_STATE.xml' path='doc/member[@name="CSV_QUERY_VOLUME_REDIRECT_STATE.DiskConnectivity"]/*' />
    public CSVFS_DISK_CONNECTIVITY DiskConnectivity;
}
