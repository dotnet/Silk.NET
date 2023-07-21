// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_METADATA_EXCHANGE_TYPE.xml' path='doc/member[@name="WS_METADATA_EXCHANGE_TYPE"]/*' />
public enum WS_METADATA_EXCHANGE_TYPE
{
    /// <include file='WS_METADATA_EXCHANGE_TYPE.xml' path='doc/member[@name="WS_METADATA_EXCHANGE_TYPE.WS_METADATA_EXCHANGE_TYPE_NONE"]/*' />
    WS_METADATA_EXCHANGE_TYPE_NONE = 0,

    /// <include file='WS_METADATA_EXCHANGE_TYPE.xml' path='doc/member[@name="WS_METADATA_EXCHANGE_TYPE.WS_METADATA_EXCHANGE_TYPE_MEX"]/*' />
    WS_METADATA_EXCHANGE_TYPE_MEX = 1,

    /// <include file='WS_METADATA_EXCHANGE_TYPE.xml' path='doc/member[@name="WS_METADATA_EXCHANGE_TYPE.WS_METADATA_EXCHANGE_TYPE_HTTP_GET"]/*' />
    WS_METADATA_EXCHANGE_TYPE_HTTP_GET = 2,
}
