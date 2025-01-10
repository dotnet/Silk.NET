// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class E
{
    [NativeTypeName("#define E_PREVIEWHANDLER_DRM_FAIL _HRESULT_TYPEDEF_(0x86420001L)")]
    public const int E_PREVIEWHANDLER_DRM_FAIL = unchecked((int)(0x86420001));

    [NativeTypeName("#define E_PREVIEWHANDLER_NOAUTH _HRESULT_TYPEDEF_(0x86420002L)")]
    public const int E_PREVIEWHANDLER_NOAUTH = unchecked((int)(0x86420002));

    [NativeTypeName("#define E_PREVIEWHANDLER_NOTFOUND _HRESULT_TYPEDEF_(0x86420003L)")]
    public const int E_PREVIEWHANDLER_NOTFOUND = unchecked((int)(0x86420003));

    [NativeTypeName("#define E_PREVIEWHANDLER_CORRUPT _HRESULT_TYPEDEF_(0x86420004L)")]
    public const int E_PREVIEWHANDLER_CORRUPT = unchecked((int)(0x86420004));
}
