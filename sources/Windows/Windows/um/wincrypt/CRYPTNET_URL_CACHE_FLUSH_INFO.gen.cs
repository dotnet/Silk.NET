// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPTNET_URL_CACHE_FLUSH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_FLUSH_INFO"]/*'/>
public partial struct CRYPTNET_URL_CACHE_FLUSH_INFO
{
    /// <include file='CRYPTNET_URL_CACHE_FLUSH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_FLUSH_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CRYPTNET_URL_CACHE_FLUSH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_FLUSH_INFO.dwExemptSeconds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExemptSeconds;
    /// <include file='CRYPTNET_URL_CACHE_FLUSH_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_FLUSH_INFO.ExpireTime"]/*'/>
    public FILETIME ExpireTime;
}