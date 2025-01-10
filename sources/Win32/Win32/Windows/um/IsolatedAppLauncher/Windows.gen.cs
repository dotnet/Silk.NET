// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IsolatedAppLauncher.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("shcore", ExactSpelling = true)]
    [Obsolete(
        "IsProcessInWDAGContainer is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public static extern HRESULT IsProcessInWDAGContainer(
        [NativeTypeName("PVOID")] void* Reserved,
        BOOL* isProcessInWDAGContainer
    );

    [DllImport("shcore", ExactSpelling = true)]
    [Obsolete(
        "IsProcessInIsolatedContainer is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public static extern HRESULT IsProcessInIsolatedContainer(BOOL* isProcessInIsolatedContainer);
}
