// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DispatcherQueue.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPATCHERQUEUE_THREAD_APARTMENTTYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_APARTMENTTYPE"]/*' />
public enum DISPATCHERQUEUE_THREAD_APARTMENTTYPE
{
    /// <include file='DISPATCHERQUEUE_THREAD_APARTMENTTYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_APARTMENTTYPE.DQTAT_COM_NONE"]/*' />
    DQTAT_COM_NONE = 0,

    /// <include file='DISPATCHERQUEUE_THREAD_APARTMENTTYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_APARTMENTTYPE.DQTAT_COM_ASTA"]/*' />
    DQTAT_COM_ASTA = 1,

    /// <include file='DISPATCHERQUEUE_THREAD_APARTMENTTYPE.xml' path='doc/member[@name="DISPATCHERQUEUE_THREAD_APARTMENTTYPE.DQTAT_COM_STA"]/*' />
    DQTAT_COM_STA = 2,
}
