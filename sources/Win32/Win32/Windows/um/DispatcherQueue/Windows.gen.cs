// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DispatcherQueue.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("coremessaging", ExactSpelling = true)]
    public static extern HRESULT CreateDispatcherQueueController(
        DispatcherQueueOptions options,
        [NativeTypeName("PDISPATCHERQUEUECONTROLLER *")]
            IDispatcherQueueController* dispatcherQueueController
    );
}
