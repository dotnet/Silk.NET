// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
public static partial class DCOMPOSITION
{
    [NativeTypeName("#define DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED _HRESULT_TYPEDEF_(0x88980800L)")]
    public const int DCOMPOSITION_ERROR_WINDOW_ALREADY_COMPOSED = unchecked((int)(0x88980800));
    [NativeTypeName("#define DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED _HRESULT_TYPEDEF_(0x88980801L)")]
    public const int DCOMPOSITION_ERROR_SURFACE_BEING_RENDERED = unchecked((int)(0x88980801));
    [NativeTypeName("#define DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED _HRESULT_TYPEDEF_(0x88980802L)")]
    public const int DCOMPOSITION_ERROR_SURFACE_NOT_BEING_RENDERED = unchecked((int)(0x88980802));
}