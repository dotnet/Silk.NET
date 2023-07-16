// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACE_HEADER.xml' path='doc/member[@name="ACE_HEADER"]/*'/>
public partial struct ACE_HEADER
{
    /// <include file='ACE_HEADER.xml' path='doc/member[@name="ACE_HEADER.AceType"]/*'/>
    public byte AceType;
    /// <include file='ACE_HEADER.xml' path='doc/member[@name="ACE_HEADER.AceFlags"]/*'/>
    public byte AceFlags;
    /// <include file='ACE_HEADER.xml' path='doc/member[@name="ACE_HEADER.AceSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort AceSize;
}