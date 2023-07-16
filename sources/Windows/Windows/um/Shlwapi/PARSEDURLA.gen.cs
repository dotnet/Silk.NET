// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA"]/*'/>
public unsafe partial struct PARSEDURLA
{
    /// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA.pszProtocol"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszProtocol;
    /// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA.cchProtocol"]/*'/>
    public uint cchProtocol;
    /// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA.pszSuffix"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* pszSuffix;
    /// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA.cchSuffix"]/*'/>
    public uint cchSuffix;
    /// <include file='PARSEDURLA.xml' path='doc/member[@name="PARSEDURLA.nScheme"]/*'/>
    public uint nScheme;
}