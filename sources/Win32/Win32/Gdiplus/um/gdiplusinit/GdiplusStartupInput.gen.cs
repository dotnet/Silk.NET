// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct GdiplusStartupInput
{
    [NativeTypeName("UINT32")]
    public uint GdiplusVersion;

    [NativeTypeName("Gdiplus::DebugEventProc")]
    public delegate* unmanaged<DebugEventLevel, sbyte*, void> DebugEventCallback;
    public BOOL SuppressBackgroundThread;
    public BOOL SuppressExternalCodecs;

    public GdiplusStartupInput(
        [NativeTypeName("Gdiplus::DebugEventProc")]
        [Optional]
            delegate* unmanaged<DebugEventLevel, sbyte*, void> debugEventCallback,
        [Optional] BOOL suppressBackgroundThread,
        [Optional] BOOL suppressExternalCodecs
    )
    {
        GdiplusVersion = 1;
        DebugEventCallback = debugEventCallback;
        SuppressBackgroundThread = suppressBackgroundThread;
        SuppressExternalCodecs = suppressExternalCodecs;
    }
}
