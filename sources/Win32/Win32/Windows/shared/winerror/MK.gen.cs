// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MK
{
    [NativeTypeName("#define MK_E_FIRST 0x800401E0L")]
    public const uint MK_E_FIRST = 0x800401E0;

    [NativeTypeName("#define MK_E_LAST 0x800401EFL")]
    public const uint MK_E_LAST = 0x800401EF;

    [NativeTypeName("#define MK_S_FIRST 0x000401E0L")]
    public const int MK_S_FIRST = 0x000401E0;

    [NativeTypeName("#define MK_S_LAST 0x000401EFL")]
    public const int MK_S_LAST = 0x000401EF;

    [NativeTypeName("#define MK_E_CONNECTMANUALLY _HRESULT_TYPEDEF_(0x800401E0L)")]
    public const int MK_E_CONNECTMANUALLY = unchecked((int)(0x800401E0));

    [NativeTypeName("#define MK_E_EXCEEDEDDEADLINE _HRESULT_TYPEDEF_(0x800401E1L)")]
    public const int MK_E_EXCEEDEDDEADLINE = unchecked((int)(0x800401E1));

    [NativeTypeName("#define MK_E_NEEDGENERIC _HRESULT_TYPEDEF_(0x800401E2L)")]
    public const int MK_E_NEEDGENERIC = unchecked((int)(0x800401E2));

    [NativeTypeName("#define MK_E_UNAVAILABLE _HRESULT_TYPEDEF_(0x800401E3L)")]
    public const int MK_E_UNAVAILABLE = unchecked((int)(0x800401E3));

    [NativeTypeName("#define MK_E_SYNTAX _HRESULT_TYPEDEF_(0x800401E4L)")]
    public const int MK_E_SYNTAX = unchecked((int)(0x800401E4));

    [NativeTypeName("#define MK_E_NOOBJECT _HRESULT_TYPEDEF_(0x800401E5L)")]
    public const int MK_E_NOOBJECT = unchecked((int)(0x800401E5));

    [NativeTypeName("#define MK_E_INVALIDEXTENSION _HRESULT_TYPEDEF_(0x800401E6L)")]
    public const int MK_E_INVALIDEXTENSION = unchecked((int)(0x800401E6));

    [NativeTypeName(
        "#define MK_E_INTERMEDIATEINTERFACENOTSUPPORTED _HRESULT_TYPEDEF_(0x800401E7L)"
    )]
    public const int MK_E_INTERMEDIATEINTERFACENOTSUPPORTED = unchecked((int)(0x800401E7));

    [NativeTypeName("#define MK_E_NOTBINDABLE _HRESULT_TYPEDEF_(0x800401E8L)")]
    public const int MK_E_NOTBINDABLE = unchecked((int)(0x800401E8));

    [NativeTypeName("#define MK_E_NOTBOUND _HRESULT_TYPEDEF_(0x800401E9L)")]
    public const int MK_E_NOTBOUND = unchecked((int)(0x800401E9));

    [NativeTypeName("#define MK_E_CANTOPENFILE _HRESULT_TYPEDEF_(0x800401EAL)")]
    public const int MK_E_CANTOPENFILE = unchecked((int)(0x800401EA));

    [NativeTypeName("#define MK_E_MUSTBOTHERUSER _HRESULT_TYPEDEF_(0x800401EBL)")]
    public const int MK_E_MUSTBOTHERUSER = unchecked((int)(0x800401EB));

    [NativeTypeName("#define MK_E_NOINVERSE _HRESULT_TYPEDEF_(0x800401ECL)")]
    public const int MK_E_NOINVERSE = unchecked((int)(0x800401EC));

    [NativeTypeName("#define MK_E_NOSTORAGE _HRESULT_TYPEDEF_(0x800401EDL)")]
    public const int MK_E_NOSTORAGE = unchecked((int)(0x800401ED));

    [NativeTypeName("#define MK_E_NOPREFIX _HRESULT_TYPEDEF_(0x800401EEL)")]
    public const int MK_E_NOPREFIX = unchecked((int)(0x800401EE));

    [NativeTypeName("#define MK_E_ENUMERATION_FAILED _HRESULT_TYPEDEF_(0x800401EFL)")]
    public const int MK_E_ENUMERATION_FAILED = unchecked((int)(0x800401EF));

    [NativeTypeName("#define MK_S_REDUCED_TO_SELF _HRESULT_TYPEDEF_(0x000401E2L)")]
    public const int MK_S_REDUCED_TO_SELF = ((int)(0x000401E2));

    [NativeTypeName("#define MK_S_ME _HRESULT_TYPEDEF_(0x000401E4L)")]
    public const int MK_S_ME = ((int)(0x000401E4));

    [NativeTypeName("#define MK_S_HIM _HRESULT_TYPEDEF_(0x000401E5L)")]
    public const int MK_S_HIM = ((int)(0x000401E5));

    [NativeTypeName("#define MK_S_US _HRESULT_TYPEDEF_(0x000401E6L)")]
    public const int MK_S_US = ((int)(0x000401E6));

    [NativeTypeName("#define MK_S_MONIKERALREADYREGISTERED _HRESULT_TYPEDEF_(0x000401E7L)")]
    public const int MK_S_MONIKERALREADYREGISTERED = ((int)(0x000401E7));

    [NativeTypeName("#define MK_E_NO_NORMALIZED _HRESULT_TYPEDEF_(0x80080007L)")]
    public const int MK_E_NO_NORMALIZED = unchecked((int)(0x80080007));
}
