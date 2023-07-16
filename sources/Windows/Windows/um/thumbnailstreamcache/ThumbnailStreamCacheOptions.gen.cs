// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='ThumbnailStreamCacheOptions.xml' path='doc/member[@name="ThumbnailStreamCacheOptions"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum ThumbnailStreamCacheOptions
{
    /// <include file='ThumbnailStreamCacheOptions.xml' path='doc/member[@name="ThumbnailStreamCacheOptions.ExtractIfNotCached"]/*'/>
    ExtractIfNotCached = 0,
    /// <include file='ThumbnailStreamCacheOptions.xml' path='doc/member[@name="ThumbnailStreamCacheOptions.ReturnOnlyIfCached"]/*'/>
    ReturnOnlyIfCached = 0x1,
    /// <include file='ThumbnailStreamCacheOptions.xml' path='doc/member[@name="ThumbnailStreamCacheOptions.ResizeThumbnail"]/*'/>
    ResizeThumbnail = 0x2,
    /// <include file='ThumbnailStreamCacheOptions.xml' path='doc/member[@name="ThumbnailStreamCacheOptions.AllowSmallerSize"]/*'/>
    AllowSmallerSize = 0x4,
}