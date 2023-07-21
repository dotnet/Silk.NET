// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateFX"]/*' />
    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern HRESULT CreateFX([NativeTypeName("const IID &")] Guid* clsid, IUnknown** pEffect, [NativeTypeName("const void *")] void* pInitDat = null, [NativeTypeName("UINT32")] uint InitDataByteSize = 0);
}
