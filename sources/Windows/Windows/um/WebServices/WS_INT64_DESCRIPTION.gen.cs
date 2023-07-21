// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_INT64_DESCRIPTION.xml' path='doc/member[@name="WS_INT64_DESCRIPTION"]/*' />
public partial struct WS_INT64_DESCRIPTION
{
    /// <include file='WS_INT64_DESCRIPTION.xml' path='doc/member[@name="WS_INT64_DESCRIPTION.minValue"]/*' />
    [NativeTypeName("long long")]
    public long minValue;

    /// <include file='WS_INT64_DESCRIPTION.xml' path='doc/member[@name="WS_INT64_DESCRIPTION.maxValue"]/*' />
    [NativeTypeName("long long")]
    public long maxValue;
}
