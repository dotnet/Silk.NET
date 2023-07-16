// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_STARTVIRTUALIZING_OPTIONS.xml' path='doc/member[@name="PRJ_STARTVIRTUALIZING_OPTIONS"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public unsafe partial struct PRJ_STARTVIRTUALIZING_OPTIONS
{
    /// <include file='PRJ_STARTVIRTUALIZING_OPTIONS.xml' path='doc/member[@name="PRJ_STARTVIRTUALIZING_OPTIONS.Flags"]/*'/>
    public PRJ_STARTVIRTUALIZING_FLAGS Flags;
    /// <include file='PRJ_STARTVIRTUALIZING_OPTIONS.xml' path='doc/member[@name="PRJ_STARTVIRTUALIZING_OPTIONS.PoolThreadCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint PoolThreadCount;
    /// <include file='PRJ_STARTVIRTUALIZING_OPTIONS.xml' path='doc/member[@name="PRJ_STARTVIRTUALIZING_OPTIONS.ConcurrentThreadCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ConcurrentThreadCount;
    /// <include file='PRJ_STARTVIRTUALIZING_OPTIONS.xml' path='doc/member[@name="PRJ_STARTVIRTUALIZING_OPTIONS.NotificationMappings"]/*'/>
    public PRJ_NOTIFICATION_MAPPING* NotificationMappings;
    /// <include file='PRJ_STARTVIRTUALIZING_OPTIONS.xml' path='doc/member[@name="PRJ_STARTVIRTUALIZING_OPTIONS.NotificationMappingsCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint NotificationMappingsCount;
}