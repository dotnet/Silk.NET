// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3DCOMPILER_STRIP_FLAGS
{
    D3DCOMPILER_STRIP_REFLECTION_DATA = 0x00000001,
    D3DCOMPILER_STRIP_DEBUG_INFO = 0x00000002,
    D3DCOMPILER_STRIP_TEST_BLOBS = 0x00000004,
    D3DCOMPILER_STRIP_PRIVATE_DATA = 0x00000008,
    D3DCOMPILER_STRIP_ROOT_SIGNATURE = 0x00000010,
    D3DCOMPILER_STRIP_FORCE_DWORD = 0x7fffffff,
}
