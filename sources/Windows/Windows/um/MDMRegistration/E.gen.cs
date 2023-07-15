// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class E
{
    [NativeTypeName("#define E_DATATYPE_MISMATCH HRESULT_FROM_WIN32(ERROR_DATATYPE_MISMATCH)")]
    public const int E_DATATYPE_MISMATCH = -2147023267;
}