// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SCHEME
{
    [NativeTypeName("#define SCHEME_DISPLAY 0x0001")]
    public const int SCHEME_DISPLAY = 0x0001;
    [NativeTypeName("#define SCHEME_EDIT 0x0002")]
    public const int SCHEME_EDIT = 0x0002;
    [NativeTypeName("#define SCHEME_LOCAL 0x0004")]
    public const int SCHEME_LOCAL = 0x0004;
    [NativeTypeName("#define SCHEME_GLOBAL 0x0008")]
    public const int SCHEME_GLOBAL = 0x0008;
    [NativeTypeName("#define SCHEME_REFRESH 0x0010")]
    public const int SCHEME_REFRESH = 0x0010;
    [NativeTypeName("#define SCHEME_UPDATE 0x0020")]
    public const int SCHEME_UPDATE = 0x0020;
    [NativeTypeName("#define SCHEME_DONOTUSE 0x0040")]
    public const int SCHEME_DONOTUSE = 0x0040;
    [NativeTypeName("#define SCHEME_CREATE 0x0080")]
    public const int SCHEME_CREATE = 0x0080;
}