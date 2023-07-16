// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_TIME_STAMP_REQUEST_INFO.xml' path='doc/member[@name="CRYPT_TIME_STAMP_REQUEST_INFO"]/*'/>
public unsafe partial struct CRYPT_TIME_STAMP_REQUEST_INFO
{
    /// <include file='CRYPT_TIME_STAMP_REQUEST_INFO.xml' path='doc/member[@name="CRYPT_TIME_STAMP_REQUEST_INFO.pszTimeStampAlgorithm"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszTimeStampAlgorithm;
    /// <include file='CRYPT_TIME_STAMP_REQUEST_INFO.xml' path='doc/member[@name="CRYPT_TIME_STAMP_REQUEST_INFO.pszContentType"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszContentType;
    /// <include file='CRYPT_TIME_STAMP_REQUEST_INFO.xml' path='doc/member[@name="CRYPT_TIME_STAMP_REQUEST_INFO.Content"]/*'/>
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Content;
    /// <include file='CRYPT_TIME_STAMP_REQUEST_INFO.xml' path='doc/member[@name="CRYPT_TIME_STAMP_REQUEST_INFO.cAttribute"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAttribute;
    /// <include file='CRYPT_TIME_STAMP_REQUEST_INFO.xml' path='doc/member[@name="CRYPT_TIME_STAMP_REQUEST_INFO.rgAttribute"]/*'/>
    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAttribute;
}