// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_ANY_ATTRIBUTES.xml' path='doc/member[@name="WS_ANY_ATTRIBUTES"]/*'/>
public unsafe partial struct WS_ANY_ATTRIBUTES
{
    /// <include file='WS_ANY_ATTRIBUTES.xml' path='doc/member[@name="WS_ANY_ATTRIBUTES.attributes"]/*'/>
    public WS_ANY_ATTRIBUTE* attributes;
    /// <include file='WS_ANY_ATTRIBUTES.xml' path='doc/member[@name="WS_ANY_ATTRIBUTES.attributeCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint attributeCount;
}