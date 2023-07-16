// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CREDENTIAL_ATTRIBUTEW.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEW"]/*'/>
public unsafe partial struct CREDENTIAL_ATTRIBUTEW
{
    /// <include file='CREDENTIAL_ATTRIBUTEW.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEW.Keyword"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* Keyword;
    /// <include file='CREDENTIAL_ATTRIBUTEW.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEW.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CREDENTIAL_ATTRIBUTEW.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEW.ValueSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ValueSize;
    /// <include file='CREDENTIAL_ATTRIBUTEW.xml' path='doc/member[@name="CREDENTIAL_ATTRIBUTEW.Value"]/*'/>
    [NativeTypeName("LPBYTE")]
    public byte* Value;
}