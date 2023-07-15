// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DispatcherQueue.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPATCHERQUEUE_THREAD_TYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_TYPE"]/*'/>
public enum DISPATCHERQUEUE_THREAD_TYPE
{
    /// <include file='DISPATCHERQUEUE_THREAD_TYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_TYPE.DQTYPE_THREAD_DEDICATED"]/*'/>
    DQTYPE_THREAD_DEDICATED = 1,
    /// <include file='DISPATCHERQUEUE_THREAD_TYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_TYPE.DQTYPE_THREAD_CURRENT"]/*'/>
    DQTYPE_THREAD_CURRENT = 2,
}