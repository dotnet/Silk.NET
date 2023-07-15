// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO"]/*'/>
public partial struct CRYPTNET_URL_CACHE_PRE_FETCH_INFO
{
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.dwObjectType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObjectType;
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.dwError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwError;
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.ThisUpdateTime"]/*'/>
    public FILETIME ThisUpdateTime;
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.NextUpdateTime"]/*'/>
    public FILETIME NextUpdateTime;
    /// <include file='CRYPTNET_URL_CACHE_PRE_FETCH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_PRE_FETCH_INFO.PublishTime"]/*'/>
    public FILETIME PublishTime;
}