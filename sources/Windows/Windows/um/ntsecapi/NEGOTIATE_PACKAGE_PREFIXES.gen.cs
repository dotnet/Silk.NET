// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NEGOTIATE_PACKAGE_PREFIXES.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIXES"]/*'/>
public partial struct NEGOTIATE_PACKAGE_PREFIXES
{
    /// <include file='NEGOTIATE_PACKAGE_PREFIXES.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIXES.MessageType"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MessageType;
    /// <include file='NEGOTIATE_PACKAGE_PREFIXES.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIXES.PrefixCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PrefixCount;
    /// <include file='NEGOTIATE_PACKAGE_PREFIXES.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIXES.Offset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Offset;
    /// <include file='NEGOTIATE_PACKAGE_PREFIXES.xml' path='doc/member[@name="NEGOTIATE_PACKAGE_PREFIXES.Pad"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Pad;
}