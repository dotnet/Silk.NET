// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/profileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SuppressGCTransition]
    public static extern BOOL QueryPerformanceCounter(LARGE_INTEGER* lpPerformanceCount);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SuppressGCTransition]
    public static extern BOOL QueryPerformanceFrequency(LARGE_INTEGER* lpFrequency);
}
