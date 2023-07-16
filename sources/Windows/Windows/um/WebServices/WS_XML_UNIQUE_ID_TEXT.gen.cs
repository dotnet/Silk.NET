// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_XML_UNIQUE_ID_TEXT.xml' path='doc/member[@name="WS_XML_UNIQUE_ID_TEXT"]/*'/>
public partial struct WS_XML_UNIQUE_ID_TEXT
{
    /// <include file='WS_XML_UNIQUE_ID_TEXT.xml' path='doc/member[@name="WS_XML_UNIQUE_ID_TEXT.text"]/*'/>
    public WS_XML_TEXT text;
    /// <include file='WS_XML_UNIQUE_ID_TEXT.xml' path='doc/member[@name="WS_XML_UNIQUE_ID_TEXT.value"]/*'/>
    public Guid value;
}