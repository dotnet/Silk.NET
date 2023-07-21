// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_HOST_NAMES.xml' path='doc/member[@name="WS_HOST_NAMES"]/*' />
public unsafe partial struct WS_HOST_NAMES
{
    /// <include file='WS_HOST_NAMES.xml' path='doc/member[@name="WS_HOST_NAMES.hostNames"]/*' />
    public WS_STRING* hostNames;

    /// <include file='WS_HOST_NAMES.xml' path='doc/member[@name="WS_HOST_NAMES.hostNameCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint hostNameCount;
}
