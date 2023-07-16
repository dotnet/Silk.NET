// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
public static partial class D3D11
{
    [NativeTypeName("#define D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS _HRESULT_TYPEDEF_(0x887C0001L)")]
    public const int D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS = unchecked((int)(0x887C0001));
    [NativeTypeName("#define D3D11_ERROR_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x887C0002L)")]
    public const int D3D11_ERROR_FILE_NOT_FOUND = unchecked((int)(0x887C0002));
    [NativeTypeName("#define D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS _HRESULT_TYPEDEF_(0x887C0003L)")]
    public const int D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS = unchecked((int)(0x887C0003));
    [NativeTypeName("#define D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD _HRESULT_TYPEDEF_(0x887C0004L)")]
    public const int D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD = unchecked((int)(0x887C0004));
}