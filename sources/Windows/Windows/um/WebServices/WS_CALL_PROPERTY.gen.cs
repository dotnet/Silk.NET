// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_CALL_PROPERTY.xml' path='doc/member[@name="WS_CALL_PROPERTY"]/*' />
public unsafe partial struct WS_CALL_PROPERTY
{
    /// <include file='WS_CALL_PROPERTY.xml' path='doc/member[@name="WS_CALL_PROPERTY.id"]/*' />
    public WS_CALL_PROPERTY_ID id;

    /// <include file='WS_CALL_PROPERTY.xml' path='doc/member[@name="WS_CALL_PROPERTY.value"]/*' />
    public void* value;

    /// <include file='WS_CALL_PROPERTY.xml' path='doc/member[@name="WS_CALL_PROPERTY.valueSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint valueSize;
}
