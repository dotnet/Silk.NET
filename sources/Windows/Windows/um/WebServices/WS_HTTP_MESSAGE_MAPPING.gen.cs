// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING"]/*' />
public unsafe partial struct WS_HTTP_MESSAGE_MAPPING
{
    /// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING.requestMappingOptions"]/*' />
    [NativeTypeName("ULONG")]
    public uint requestMappingOptions;

    /// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING.responseMappingOptions"]/*' />
    [NativeTypeName("ULONG")]
    public uint responseMappingOptions;

    /// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING.requestHeaderMappings"]/*' />
    public WS_HTTP_HEADER_MAPPING** requestHeaderMappings;

    /// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING.requestHeaderMappingCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint requestHeaderMappingCount;

    /// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING.responseHeaderMappings"]/*' />
    public WS_HTTP_HEADER_MAPPING** responseHeaderMappings;

    /// <include file='WS_HTTP_MESSAGE_MAPPING.xml' path='doc/member[@name="WS_HTTP_MESSAGE_MAPPING.responseHeaderMappingCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint responseHeaderMappingCount;
}
