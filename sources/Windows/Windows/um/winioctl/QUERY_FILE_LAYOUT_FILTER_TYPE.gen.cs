// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='QUERY_FILE_LAYOUT_FILTER_TYPE.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_FILTER_TYPE"]/*' />
public enum QUERY_FILE_LAYOUT_FILTER_TYPE
{
    /// <include file='QUERY_FILE_LAYOUT_FILTER_TYPE.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_FILTER_TYPE.QUERY_FILE_LAYOUT_FILTER_TYPE_NONE"]/*' />
    QUERY_FILE_LAYOUT_FILTER_TYPE_NONE = 0,

    /// <include file='QUERY_FILE_LAYOUT_FILTER_TYPE.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_FILTER_TYPE.QUERY_FILE_LAYOUT_FILTER_TYPE_CLUSTERS"]/*' />
    QUERY_FILE_LAYOUT_FILTER_TYPE_CLUSTERS = 1,

    /// <include file='QUERY_FILE_LAYOUT_FILTER_TYPE.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_FILTER_TYPE.QUERY_FILE_LAYOUT_FILTER_TYPE_FILEID"]/*' />
    QUERY_FILE_LAYOUT_FILTER_TYPE_FILEID = 2,

    /// <include file='QUERY_FILE_LAYOUT_FILTER_TYPE.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_FILTER_TYPE.QUERY_FILE_LAYOUT_FILTER_TYPE_STORAGE_RESERVE_ID"]/*' />
    QUERY_FILE_LAYOUT_FILTER_TYPE_STORAGE_RESERVE_ID = 3,

    /// <include file='QUERY_FILE_LAYOUT_FILTER_TYPE.xml' path='doc/member[@name="QUERY_FILE_LAYOUT_FILTER_TYPE.QUERY_FILE_LAYOUT_NUM_FILTER_TYPES"]/*' />
    QUERY_FILE_LAYOUT_NUM_FILTER_TYPES,
}
