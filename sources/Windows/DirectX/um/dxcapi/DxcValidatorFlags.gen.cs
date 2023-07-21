// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace Silk.NET.DirectX;

public static partial class DxcValidatorFlags
{
    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_Default = 0;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_InPlaceEdit = 1;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_RootSignatureOnly = 2;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_ModuleOnly = 4;

    [NativeTypeName("const UINT32")]
    public const uint DxcValidatorFlags_ValidMask = 0x7;
}
