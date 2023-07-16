// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DHPUBKEY_VER3.xml' path='doc/member[@name="DHPUBKEY_VER3"]/*'/>
public partial struct DHPUBKEY_VER3
{
    /// <include file='DHPUBKEY_VER3.xml' path='doc/member[@name="DHPUBKEY_VER3.magic"]/*'/>
    [NativeTypeName("DWORD")]
    public uint magic;
    /// <include file='DHPUBKEY_VER3.xml' path='doc/member[@name="DHPUBKEY_VER3.bitlenP"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenP;
    /// <include file='DHPUBKEY_VER3.xml' path='doc/member[@name="DHPUBKEY_VER3.bitlenQ"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenQ;
    /// <include file='DHPUBKEY_VER3.xml' path='doc/member[@name="DHPUBKEY_VER3.bitlenJ"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenJ;
    /// <include file='DHPUBKEY_VER3.xml' path='doc/member[@name="DHPUBKEY_VER3.DSSSeed"]/*'/>
    public DSSSEED DSSSeed;
}