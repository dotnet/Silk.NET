// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/D2DErr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D2DERR
{
    [NativeTypeName("#define D2DERR_UNSUPPORTED_PIXEL_FORMAT WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT")]
    public const int D2DERR_UNSUPPORTED_PIXEL_FORMAT = unchecked((int)(0x88982F80));

    [NativeTypeName(
        "#define D2DERR_INSUFFICIENT_BUFFER HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)"
    )]
    public const int D2DERR_INSUFFICIENT_BUFFER = -2147024774;

    [NativeTypeName("#define D2DERR_FILE_NOT_FOUND HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND)")]
    public const int D2DERR_FILE_NOT_FOUND = -2147024894;
}
