// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class E
{
    [NativeTypeName("#define E_NOTFOUND HRESULT_FROM_WIN32(ERROR_NOT_FOUND)")]
    public const int E_NOTFOUND = -2147023728;
    [NativeTypeName("#define E_UNSUPPORTED_TYPE HRESULT_FROM_WIN32(ERROR_UNSUPPORTED_TYPE)")]
    public const int E_UNSUPPORTED_TYPE = -2147023266;
}