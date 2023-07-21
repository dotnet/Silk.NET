// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WRITE_CACHE_CHANGE.xml' path='doc/member[@name="WRITE_CACHE_CHANGE"]/*' />
public enum WRITE_CACHE_CHANGE
{
    /// <include file='WRITE_CACHE_CHANGE.xml' path='doc/member[@name="WRITE_CACHE_CHANGE.WriteCacheChangeUnknown"]/*' />
    WriteCacheChangeUnknown,

    /// <include file='WRITE_CACHE_CHANGE.xml' path='doc/member[@name="WRITE_CACHE_CHANGE.WriteCacheNotChangeable"]/*' />
    WriteCacheNotChangeable,

    /// <include file='WRITE_CACHE_CHANGE.xml' path='doc/member[@name="WRITE_CACHE_CHANGE.WriteCacheChangeable"]/*' />
    WriteCacheChangeable,
}
