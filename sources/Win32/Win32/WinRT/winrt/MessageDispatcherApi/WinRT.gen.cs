// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/MessageDispatcherApi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoSetMessageDispatcher(
        [NativeTypeName("PMessageDispatcher")] IMessageDispatcher pMessageDispatcher
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern void CoHandlePriorityEventsFromMessagePump();
}
