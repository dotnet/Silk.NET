// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/coml2api.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class STGFMT
{
    [NativeTypeName("#define STGFMT_STORAGE 0")]
    public const int STGFMT_STORAGE = 0;

    [NativeTypeName("#define STGFMT_NATIVE 1")]
    public const int STGFMT_NATIVE = 1;

    [NativeTypeName("#define STGFMT_FILE 3")]
    public const int STGFMT_FILE = 3;

    [NativeTypeName("#define STGFMT_ANY 4")]
    public const int STGFMT_ANY = 4;

    [NativeTypeName("#define STGFMT_DOCFILE 5")]
    public const int STGFMT_DOCFILE = 5;

    [NativeTypeName("#define STGFMT_DOCUMENT 0")]
    public const int STGFMT_DOCUMENT = 0;
}
