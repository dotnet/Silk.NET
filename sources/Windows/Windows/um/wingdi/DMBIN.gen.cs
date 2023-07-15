// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DMBIN
{
    [NativeTypeName("#define DMBIN_FIRST DMBIN_UPPER")]
    public const int DMBIN_FIRST = 1;
    [NativeTypeName("#define DMBIN_UPPER 1")]
    public const int DMBIN_UPPER = 1;
    [NativeTypeName("#define DMBIN_ONLYONE 1")]
    public const int DMBIN_ONLYONE = 1;
    [NativeTypeName("#define DMBIN_LOWER 2")]
    public const int DMBIN_LOWER = 2;
    [NativeTypeName("#define DMBIN_MIDDLE 3")]
    public const int DMBIN_MIDDLE = 3;
    [NativeTypeName("#define DMBIN_MANUAL 4")]
    public const int DMBIN_MANUAL = 4;
    [NativeTypeName("#define DMBIN_ENVELOPE 5")]
    public const int DMBIN_ENVELOPE = 5;
    [NativeTypeName("#define DMBIN_ENVMANUAL 6")]
    public const int DMBIN_ENVMANUAL = 6;
    [NativeTypeName("#define DMBIN_AUTO 7")]
    public const int DMBIN_AUTO = 7;
    [NativeTypeName("#define DMBIN_TRACTOR 8")]
    public const int DMBIN_TRACTOR = 8;
    [NativeTypeName("#define DMBIN_SMALLFMT 9")]
    public const int DMBIN_SMALLFMT = 9;
    [NativeTypeName("#define DMBIN_LARGEFMT 10")]
    public const int DMBIN_LARGEFMT = 10;
    [NativeTypeName("#define DMBIN_LARGECAPACITY 11")]
    public const int DMBIN_LARGECAPACITY = 11;
    [NativeTypeName("#define DMBIN_CASSETTE 14")]
    public const int DMBIN_CASSETTE = 14;
    [NativeTypeName("#define DMBIN_FORMSOURCE 15")]
    public const int DMBIN_FORMSOURCE = 15;
    [NativeTypeName("#define DMBIN_LAST DMBIN_FORMSOURCE")]
    public const int DMBIN_LAST = 15;
    [NativeTypeName("#define DMBIN_USER 256")]
    public const int DMBIN_USER = 256;
}