// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CONVERT10
{
    [NativeTypeName("#define CONVERT10_E_FIRST 0x800401C0L")]
    public const uint CONVERT10_E_FIRST = 0x800401C0;
    [NativeTypeName("#define CONVERT10_E_LAST 0x800401CFL")]
    public const uint CONVERT10_E_LAST = 0x800401CF;
    [NativeTypeName("#define CONVERT10_S_FIRST 0x000401C0L")]
    public const int CONVERT10_S_FIRST = 0x000401C0;
    [NativeTypeName("#define CONVERT10_S_LAST 0x000401CFL")]
    public const int CONVERT10_S_LAST = 0x000401CF;
    [NativeTypeName("#define CONVERT10_E_OLESTREAM_GET _HRESULT_TYPEDEF_(0x800401C0L)")]
    public const int CONVERT10_E_OLESTREAM_GET = unchecked((int)(0x800401C0));
    [NativeTypeName("#define CONVERT10_E_OLESTREAM_PUT _HRESULT_TYPEDEF_(0x800401C1L)")]
    public const int CONVERT10_E_OLESTREAM_PUT = unchecked((int)(0x800401C1));
    [NativeTypeName("#define CONVERT10_E_OLESTREAM_FMT _HRESULT_TYPEDEF_(0x800401C2L)")]
    public const int CONVERT10_E_OLESTREAM_FMT = unchecked((int)(0x800401C2));
    [NativeTypeName("#define CONVERT10_E_OLESTREAM_BITMAP_TO_DIB _HRESULT_TYPEDEF_(0x800401C3L)")]
    public const int CONVERT10_E_OLESTREAM_BITMAP_TO_DIB = unchecked((int)(0x800401C3));
    [NativeTypeName("#define CONVERT10_E_STG_FMT _HRESULT_TYPEDEF_(0x800401C4L)")]
    public const int CONVERT10_E_STG_FMT = unchecked((int)(0x800401C4));
    [NativeTypeName("#define CONVERT10_E_STG_NO_STD_STREAM _HRESULT_TYPEDEF_(0x800401C5L)")]
    public const int CONVERT10_E_STG_NO_STD_STREAM = unchecked((int)(0x800401C5));
    [NativeTypeName("#define CONVERT10_E_STG_DIB_TO_BITMAP _HRESULT_TYPEDEF_(0x800401C6L)")]
    public const int CONVERT10_E_STG_DIB_TO_BITMAP = unchecked((int)(0x800401C6));
    [NativeTypeName("#define CONVERT10_S_NO_PRESENTATION _HRESULT_TYPEDEF_(0x000401C0L)")]
    public const int CONVERT10_S_NO_PRESENTATION = ((int)(0x000401C0));
}