// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MEMORY_RESOURCE_NOTIFICATION_TYPE.xml' path='doc/member[@name="MEMORY_RESOURCE_NOTIFICATION_TYPE"]/*'/>
public enum MEMORY_RESOURCE_NOTIFICATION_TYPE
{
    /// <include file='MEMORY_RESOURCE_NOTIFICATION_TYPE.xml' path='doc/member[@name="MEMORY_RESOURCE_NOTIFICATION_TYPE.LowMemoryResourceNotification"]/*'/>
    LowMemoryResourceNotification,
    /// <include file='MEMORY_RESOURCE_NOTIFICATION_TYPE.xml' path='doc/member[@name="MEMORY_RESOURCE_NOTIFICATION_TYPE.HighMemoryResourceNotification"]/*'/>
    HighMemoryResourceNotification,
}