// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_QUERY_TYPE.xml' path='doc/member[@name="STORAGE_QUERY_TYPE"]/*' />
public enum STORAGE_QUERY_TYPE
{
    /// <include file='STORAGE_QUERY_TYPE.xml' path='doc/member[@name="STORAGE_QUERY_TYPE.PropertyStandardQuery"]/*' />
    PropertyStandardQuery = 0,

    /// <include file='STORAGE_QUERY_TYPE.xml' path='doc/member[@name="STORAGE_QUERY_TYPE.PropertyExistsQuery"]/*' />
    PropertyExistsQuery,

    /// <include file='STORAGE_QUERY_TYPE.xml' path='doc/member[@name="STORAGE_QUERY_TYPE.PropertyMaskQuery"]/*' />
    PropertyMaskQuery,

    /// <include file='STORAGE_QUERY_TYPE.xml' path='doc/member[@name="STORAGE_QUERY_TYPE.PropertyQueryMaxDefined"]/*' />
    PropertyQueryMaxDefined,
}
