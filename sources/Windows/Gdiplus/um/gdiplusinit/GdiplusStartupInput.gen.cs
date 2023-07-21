// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus;

/// <include file='GdiplusStartupInput.xml' path='doc/member[@name="GdiplusStartupInput"]/*' />
public unsafe partial struct GdiplusStartupInput
{
    /// <include file='GdiplusStartupInput.xml' path='doc/member[@name="GdiplusStartupInput.GdiplusVersion"]/*' />
    [NativeTypeName("UINT32")]
    public uint GdiplusVersion;

    /// <include file='GdiplusStartupInput.xml' path='doc/member[@name="GdiplusStartupInput.DebugEventCallback"]/*' />
    [NativeTypeName("Gdiplus::DebugEventProc")]
    public delegate* unmanaged<DebugEventLevel, sbyte*, void> DebugEventCallback;

    /// <include file='GdiplusStartupInput.xml' path='doc/member[@name="GdiplusStartupInput.SuppressBackgroundThread"]/*' />
    public BOOL SuppressBackgroundThread;

    /// <include file='GdiplusStartupInput.xml' path='doc/member[@name="GdiplusStartupInput.SuppressExternalCodecs"]/*' />
    public BOOL SuppressExternalCodecs;

    public GdiplusStartupInput([NativeTypeName("Gdiplus::DebugEventProc")] [Optional] delegate* unmanaged<DebugEventLevel, sbyte*, void> debugEventCallback, [Optional] BOOL suppressBackgroundThread, [Optional] BOOL suppressExternalCodecs)
    {
        GdiplusVersion = 1;
        DebugEventCallback = debugEventCallback;
        SuppressBackgroundThread = suppressBackgroundThread;
        SuppressExternalCodecs = suppressExternalCodecs;
    }
}
