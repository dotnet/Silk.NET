// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/MessageDispatcherApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CoSetMessageDispatcher"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoSetMessageDispatcher([NativeTypeName("PMessageDispatcher")] IMessageDispatcher* pMessageDispatcher);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CoHandlePriorityEventsFromMessagePump"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoHandlePriorityEventsFromMessagePump();
}