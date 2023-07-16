// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFNETSOURCE_CACHE_STATE.xml' path='doc/member[@name="MFNETSOURCE_CACHE_STATE"]/*'/>
public enum MFNETSOURCE_CACHE_STATE
{
    /// <include file='MFNETSOURCE_CACHE_STATE.xml' path='doc/member[@name="MFNETSOURCE_CACHE_STATE.MFNETSOURCE_CACHE_UNAVAILABLE"]/*'/>
    MFNETSOURCE_CACHE_UNAVAILABLE = 0,
    /// <include file='MFNETSOURCE_CACHE_STATE.xml' path='doc/member[@name="MFNETSOURCE_CACHE_STATE.MFNETSOURCE_CACHE_ACTIVE_WRITING"]/*'/>
    MFNETSOURCE_CACHE_ACTIVE_WRITING = (MFNETSOURCE_CACHE_UNAVAILABLE + 1),
    /// <include file='MFNETSOURCE_CACHE_STATE.xml' path='doc/member[@name="MFNETSOURCE_CACHE_STATE.MFNETSOURCE_CACHE_ACTIVE_COMPLETE"]/*'/>
    MFNETSOURCE_CACHE_ACTIVE_COMPLETE = (MFNETSOURCE_CACHE_ACTIVE_WRITING + 1),
}