// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAPI_MODE_PAGE_REQUEST_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_REQUEST_TYPE"]/*' />
public enum IMAPI_MODE_PAGE_REQUEST_TYPE
{
    /// <include file='IMAPI_MODE_PAGE_REQUEST_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_REQUEST_TYPE.IMAPI_MODE_PAGE_REQUEST_TYPE_CURRENT_VALUES"]/*' />
    IMAPI_MODE_PAGE_REQUEST_TYPE_CURRENT_VALUES = 0,

    /// <include file='IMAPI_MODE_PAGE_REQUEST_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_REQUEST_TYPE.IMAPI_MODE_PAGE_REQUEST_TYPE_CHANGEABLE_VALUES"]/*' />
    IMAPI_MODE_PAGE_REQUEST_TYPE_CHANGEABLE_VALUES = 1,

    /// <include file='IMAPI_MODE_PAGE_REQUEST_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_REQUEST_TYPE.IMAPI_MODE_PAGE_REQUEST_TYPE_DEFAULT_VALUES"]/*' />
    IMAPI_MODE_PAGE_REQUEST_TYPE_DEFAULT_VALUES = 2,

    /// <include file='IMAPI_MODE_PAGE_REQUEST_TYPE.xml' path='doc/member[@name="IMAPI_MODE_PAGE_REQUEST_TYPE.IMAPI_MODE_PAGE_REQUEST_TYPE_SAVED_VALUES"]/*' />
    IMAPI_MODE_PAGE_REQUEST_TYPE_SAVED_VALUES = 3,
}
