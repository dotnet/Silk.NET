// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DxcVersionInfoFlags
{
    [NativeTypeName("const UINT32")]
    public const uint DxcVersionInfoFlags_None = 0;

    [NativeTypeName("const UINT32")]
    public const uint DxcVersionInfoFlags_Debug = 1;

    [NativeTypeName("const UINT32")]
    public const uint DxcVersionInfoFlags_Internal = 2;
}
