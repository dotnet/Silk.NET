// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.WinRT;

namespace TerraFX.Interop.Windows;
public static partial class EXCEPTION
{
    [NativeTypeName("#define EXCEPTION_RO_ORIGINATEERROR ((DWORD)((0x1 << 30) | (FACILITY_WINDOWS << 16) | 0x201))")]
    public const uint EXCEPTION_RO_ORIGINATEERROR = ((uint)((0x1 << 30) | (8 << 16) | 0x201));
    [NativeTypeName("#define EXCEPTION_RO_TRANSFORMERROR ((DWORD)((0x1 << 30) | (FACILITY_WINDOWS << 16) | 0x202))")]
    public const uint EXCEPTION_RO_TRANSFORMERROR = ((uint)((0x1 << 30) | (8 << 16) | 0x202));
}