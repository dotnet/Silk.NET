// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3"]/*'/>
public partial struct DHPRIVKEY_VER3
{
    /// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3.magic"]/*'/>
    [NativeTypeName("DWORD")]
    public uint magic;
    /// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3.bitlenP"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenP;
    /// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3.bitlenQ"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenQ;
    /// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3.bitlenJ"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenJ;
    /// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3.bitlenX"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlenX;
    /// <include file='DHPRIVKEY_VER3.xml' path='doc/member[@name="DHPRIVKEY_VER3.DSSSeed"]/*'/>
    public DSSSEED DSSSeed;
}