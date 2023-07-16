// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define FACILTIY_MUI_ERROR_CODE 0xB")]
    public const int FACILTIY_MUI_ERROR_CODE = 0xB;
    [NativeTypeName("#define EPT_NT_INVALID_ENTRY ((NTSTATUS)0xC0020034L)")]
    public const int EPT_NT_INVALID_ENTRY = unchecked((int)(0xC0020034));
    [NativeTypeName("#define EPT_NT_CANT_PERFORM_OP ((NTSTATUS)0xC0020035L)")]
    public const int EPT_NT_CANT_PERFORM_OP = unchecked((int)(0xC0020035));
    [NativeTypeName("#define EPT_NT_NOT_REGISTERED ((NTSTATUS)0xC0020036L)")]
    public const int EPT_NT_NOT_REGISTERED = unchecked((int)(0xC0020036));
    [NativeTypeName("#define EPT_NT_CANT_CREATE ((NTSTATUS)0xC002004CL)")]
    public const int EPT_NT_CANT_CREATE = unchecked((int)(0xC002004C));
}