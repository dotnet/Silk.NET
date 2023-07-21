// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oobenotification.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterWaitUntilOOBECompleted"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterWaitUntilOOBECompleted([NativeTypeName("OOBE_COMPLETED_CALLBACK")] delegate* unmanaged<void*, void> OOBECompletedCallback, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PVOID *")] void** WaitHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterWaitUntilOOBECompleted"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterWaitUntilOOBECompleted([NativeTypeName("PVOID")] void* WaitHandle);
}
