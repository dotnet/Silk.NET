// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CSVFS_DISK_CONNECTIVITY.xml' path='doc/member[@name="CSVFS_DISK_CONNECTIVITY"]/*' />
public enum CSVFS_DISK_CONNECTIVITY
{
    /// <include file='CSVFS_DISK_CONNECTIVITY.xml' path='doc/member[@name="CSVFS_DISK_CONNECTIVITY.CsvFsDiskConnectivityNone"]/*' />
    CsvFsDiskConnectivityNone = 0,

    /// <include file='CSVFS_DISK_CONNECTIVITY.xml' path='doc/member[@name="CSVFS_DISK_CONNECTIVITY.CsvFsDiskConnectivityMdsNodeOnly"]/*' />
    CsvFsDiskConnectivityMdsNodeOnly = 1,

    /// <include file='CSVFS_DISK_CONNECTIVITY.xml' path='doc/member[@name="CSVFS_DISK_CONNECTIVITY.CsvFsDiskConnectivitySubsetOfNodes"]/*' />
    CsvFsDiskConnectivitySubsetOfNodes = 2,

    /// <include file='CSVFS_DISK_CONNECTIVITY.xml' path='doc/member[@name="CSVFS_DISK_CONNECTIVITY.CsvFsDiskConnectivityAllNodes"]/*' />
    CsvFsDiskConnectivityAllNodes = 3,
}
