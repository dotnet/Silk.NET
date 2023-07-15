// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WRITE_CACHE_ENABLE.xml' path='doc/member[@name="WRITE_CACHE_ENABLE"]/*'/>
public enum WRITE_CACHE_ENABLE
{
    /// <include file='WRITE_CACHE_ENABLE.xml' path='doc/member[@name="WRITE_CACHE_ENABLE.WriteCacheEnableUnknown"]/*'/>
    WriteCacheEnableUnknown,
    /// <include file='WRITE_CACHE_ENABLE.xml' path='doc/member[@name="WRITE_CACHE_ENABLE.WriteCacheDisabled"]/*'/>
    WriteCacheDisabled,
    /// <include file='WRITE_CACHE_ENABLE.xml' path='doc/member[@name="WRITE_CACHE_ENABLE.WriteCacheEnabled"]/*'/>
    WriteCacheEnabled,
}