// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WS_XML_NODE_POSITION.xml' path='doc/member[@name="WS_XML_NODE_POSITION"]/*' />
public unsafe partial struct WS_XML_NODE_POSITION
{
    /// <include file='WS_XML_NODE_POSITION.xml' path='doc/member[@name="WS_XML_NODE_POSITION.buffer"]/*' />
    [NativeTypeName("WS_XML_BUFFER*")]
    public IntPtr buffer;

    /// <include file='WS_XML_NODE_POSITION.xml' path='doc/member[@name="WS_XML_NODE_POSITION.node"]/*' />
    public void* node;
}
