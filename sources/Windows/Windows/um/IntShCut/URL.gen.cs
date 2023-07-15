// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class URL
{
    [NativeTypeName("#define URL_E_INVALID_SYNTAX MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1001)")]
    public const int URL_E_INVALID_SYNTAX = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1001))));
    [NativeTypeName("#define URL_E_UNREGISTERED_PROTOCOL MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1002)")]
    public const int URL_E_UNREGISTERED_PROTOCOL = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1002))));
}