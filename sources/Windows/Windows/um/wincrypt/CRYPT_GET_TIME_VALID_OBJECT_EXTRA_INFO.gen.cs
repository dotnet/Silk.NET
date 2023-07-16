// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO"]/*'/>
public unsafe partial struct CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO
{
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.iDeltaCrlIndicator"]/*'/>
    public int iDeltaCrlIndicator;
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.pftCacheResync"]/*'/>
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pftCacheResync;
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.pLastSyncTime"]/*'/>
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pLastSyncTime;
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.pMaxAgeTime"]/*'/>
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pMaxAgeTime;
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.pChainPara"]/*'/>
    [NativeTypeName("PCERT_REVOCATION_CHAIN_PARA")]
    public CERT_REVOCATION_CHAIN_PARA* pChainPara;
    /// <include file='CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.xml' path='doc/member[@name="CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO.pDeltaCrlIndicator"]/*'/>
    [NativeTypeName("PCRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB* pDeltaCrlIndicator;
}