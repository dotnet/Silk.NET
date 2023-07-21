// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_XML_TEXT_NODE.xml' path='doc/member[@name="WS_XML_TEXT_NODE"]/*' />
public unsafe partial struct WS_XML_TEXT_NODE
{
    /// <include file='WS_XML_TEXT_NODE.xml' path='doc/member[@name="WS_XML_TEXT_NODE.node"]/*' />
    public WS_XML_NODE node;

    /// <include file='WS_XML_TEXT_NODE.xml' path='doc/member[@name="WS_XML_TEXT_NODE.text"]/*' />
    public WS_XML_TEXT* text;
}
