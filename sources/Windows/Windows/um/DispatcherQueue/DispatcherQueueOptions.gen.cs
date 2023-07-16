// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DispatcherQueue.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DispatcherQueueOptions.xml' path='doc/member[@name="DispatcherQueueOptions"]/*'/>
public partial struct DispatcherQueueOptions
{
    /// <include file='DispatcherQueueOptions.xml' path='doc/member[@name="DispatcherQueueOptions.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DispatcherQueueOptions.xml' path='doc/member[@name="DispatcherQueueOptions.threadType"]/*'/>
    public DISPATCHERQUEUE_THREAD_TYPE threadType;
    /// <include file='DispatcherQueueOptions.xml' path='doc/member[@name="DispatcherQueueOptions.apartmentType"]/*'/>
    public DISPATCHERQUEUE_THREAD_APARTMENTTYPE apartmentType;
}