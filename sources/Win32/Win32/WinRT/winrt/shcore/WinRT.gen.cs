// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/shcore.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CreateRandomAccessStreamOnFile(
        [NativeTypeName("PCWSTR")] ushort* filePath,
        [NativeTypeName("DWORD")] uint accessMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CreateRandomAccessStreamOverStream(
        IStream stream,
        BSOS_OPTIONS options,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CreateStreamOverRandomAccessStream(
        IUnknown randomAccessStream,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );
}
