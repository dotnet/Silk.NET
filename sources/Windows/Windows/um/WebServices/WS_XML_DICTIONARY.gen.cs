// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WS_XML_DICTIONARY.xml' path='doc/member[@name="WS_XML_DICTIONARY"]/*'/>
public unsafe partial struct WS_XML_DICTIONARY
{
    /// <include file='WS_XML_DICTIONARY.xml' path='doc/member[@name="WS_XML_DICTIONARY.guid"]/*'/>
    public Guid guid;
    /// <include file='WS_XML_DICTIONARY.xml' path='doc/member[@name="WS_XML_DICTIONARY.strings"]/*'/>
    public WS_XML_STRING* strings;
    /// <include file='WS_XML_DICTIONARY.xml' path='doc/member[@name="WS_XML_DICTIONARY.stringCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint stringCount;
    /// <include file='WS_XML_DICTIONARY.xml' path='doc/member[@name="WS_XML_DICTIONARY.isConst"]/*'/>
    public BOOL isConst;
}