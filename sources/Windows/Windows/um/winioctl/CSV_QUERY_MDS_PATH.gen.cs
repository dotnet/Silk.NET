// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH"]/*' />
public unsafe partial struct CSV_QUERY_MDS_PATH
{
    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.MdsNodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint MdsNodeId;

    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.DsNodeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DsNodeId;

    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.PathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint PathLength;

    /// <include file='CSV_QUERY_MDS_PATH.xml' path='doc/member[@name="CSV_QUERY_MDS_PATH.Path"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Path[1];
}
