// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType"]/*'/>
public enum IEObjectType
{
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_EVENT"]/*'/>
    IE_EPM_OBJECT_EVENT,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_MUTEX"]/*'/>
    IE_EPM_OBJECT_MUTEX,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_SEMAPHORE"]/*'/>
    IE_EPM_OBJECT_SEMAPHORE,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_SHARED_MEMORY"]/*'/>
    IE_EPM_OBJECT_SHARED_MEMORY,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_WAITABLE_TIMER"]/*'/>
    IE_EPM_OBJECT_WAITABLE_TIMER,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_FILE"]/*'/>
    IE_EPM_OBJECT_FILE,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_NAMED_PIPE"]/*'/>
    IE_EPM_OBJECT_NAMED_PIPE,
    /// <include file='IEObjectType.xml' path='doc/member[@name="IEObjectType.IE_EPM_OBJECT_REGISTRY"]/*'/>
    IE_EPM_OBJECT_REGISTRY,
}