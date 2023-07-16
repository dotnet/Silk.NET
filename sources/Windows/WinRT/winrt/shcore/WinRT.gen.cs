// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/shcore.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CreateRandomAccessStreamOnFile"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    public static extern HRESULT CreateRandomAccessStreamOnFile([NativeTypeName("PCWSTR")] ushort* filePath, [NativeTypeName("DWORD")] uint accessMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CreateRandomAccessStreamOverStream"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    public static extern HRESULT CreateRandomAccessStreamOverStream(IStream* stream, BSOS_OPTIONS options, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.CreateStreamOverRandomAccessStream"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    public static extern HRESULT CreateStreamOverRandomAccessStream(IUnknown* randomAccessStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
}