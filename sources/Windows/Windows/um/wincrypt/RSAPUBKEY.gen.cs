// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RSAPUBKEY.xml' path='doc/member[@name="RSAPUBKEY"]/*'/>
public partial struct RSAPUBKEY
{
    /// <include file='RSAPUBKEY.xml' path='doc/member[@name="RSAPUBKEY.magic"]/*'/>
    [NativeTypeName("DWORD")]
    public uint magic;
    /// <include file='RSAPUBKEY.xml' path='doc/member[@name="RSAPUBKEY.bitlen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bitlen;
    /// <include file='RSAPUBKEY.xml' path='doc/member[@name="RSAPUBKEY.pubexp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint pubexp;
}