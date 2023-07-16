// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY"]/*'/>
public partial struct STORAGE_WRITE_CACHE_PROPERTY
{
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.WriteCacheType"]/*'/>
    public WRITE_CACHE_TYPE WriteCacheType;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.WriteCacheEnabled"]/*'/>
    public WRITE_CACHE_ENABLE WriteCacheEnabled;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.WriteCacheChangeable"]/*'/>
    public WRITE_CACHE_CHANGE WriteCacheChangeable;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.WriteThroughSupported"]/*'/>
    public WRITE_THROUGH WriteThroughSupported;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.FlushCacheSupported"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte FlushCacheSupported;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.UserDefinedPowerProtection"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte UserDefinedPowerProtection;
    /// <include file='STORAGE_WRITE_CACHE_PROPERTY.xml' path='doc/member[@name="STORAGE_WRITE_CACHE_PROPERTY.NVCacheEnabled"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte NVCacheEnabled;
}