// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_HEAP_PROPERTY_ID.xml' path='doc/member[@name="WS_HEAP_PROPERTY_ID"]/*'/>
public enum WS_HEAP_PROPERTY_ID
{
    /// <include file='WS_HEAP_PROPERTY_ID.xml' path='doc/member[@name="WS_HEAP_PROPERTY_ID.WS_HEAP_PROPERTY_MAX_SIZE"]/*'/>
    WS_HEAP_PROPERTY_MAX_SIZE = 0,
    /// <include file='WS_HEAP_PROPERTY_ID.xml' path='doc/member[@name="WS_HEAP_PROPERTY_ID.WS_HEAP_PROPERTY_TRIM_SIZE"]/*'/>
    WS_HEAP_PROPERTY_TRIM_SIZE = 1,
    /// <include file='WS_HEAP_PROPERTY_ID.xml' path='doc/member[@name="WS_HEAP_PROPERTY_ID.WS_HEAP_PROPERTY_REQUESTED_SIZE"]/*'/>
    WS_HEAP_PROPERTY_REQUESTED_SIZE = 2,
    /// <include file='WS_HEAP_PROPERTY_ID.xml' path='doc/member[@name="WS_HEAP_PROPERTY_ID.WS_HEAP_PROPERTY_ACTUAL_SIZE"]/*'/>
    WS_HEAP_PROPERTY_ACTUAL_SIZE = 3,
}