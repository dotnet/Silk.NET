// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PACKAGE
{
    [NativeTypeName("#define PACKAGE_PROPERTY_FRAMEWORK 0x00000001")]
    public const int PACKAGE_PROPERTY_FRAMEWORK = 0x00000001;

    [NativeTypeName("#define PACKAGE_PROPERTY_RESOURCE 0x00000002")]
    public const int PACKAGE_PROPERTY_RESOURCE = 0x00000002;

    [NativeTypeName("#define PACKAGE_PROPERTY_BUNDLE 0x00000004")]
    public const int PACKAGE_PROPERTY_BUNDLE = 0x00000004;

    [NativeTypeName("#define PACKAGE_PROPERTY_OPTIONAL 0x00000008")]
    public const int PACKAGE_PROPERTY_OPTIONAL = 0x00000008;

    [NativeTypeName("#define PACKAGE_FILTER_HEAD 0x00000010")]
    public const int PACKAGE_FILTER_HEAD = 0x00000010;

    [NativeTypeName("#define PACKAGE_FILTER_DIRECT 0x00000020")]
    public const int PACKAGE_FILTER_DIRECT = 0x00000020;

    [NativeTypeName("#define PACKAGE_FILTER_RESOURCE 0x00000040")]
    public const int PACKAGE_FILTER_RESOURCE = 0x00000040;

    [NativeTypeName("#define PACKAGE_FILTER_BUNDLE 0x00000080")]
    public const int PACKAGE_FILTER_BUNDLE = 0x00000080;

    [NativeTypeName("#define PACKAGE_INFORMATION_BASIC 0x00000000")]
    public const int PACKAGE_INFORMATION_BASIC = 0x00000000;

    [NativeTypeName("#define PACKAGE_INFORMATION_FULL 0x00000100")]
    public const int PACKAGE_INFORMATION_FULL = 0x00000100;

    [NativeTypeName("#define PACKAGE_PROPERTY_DEVELOPMENT_MODE 0x00010000")]
    public const int PACKAGE_PROPERTY_DEVELOPMENT_MODE = 0x00010000;

    [NativeTypeName("#define PACKAGE_FILTER_OPTIONAL 0x00020000")]
    public const int PACKAGE_FILTER_OPTIONAL = 0x00020000;

    [NativeTypeName("#define PACKAGE_PROPERTY_IS_IN_RELATED_SET 0x00040000")]
    public const int PACKAGE_PROPERTY_IS_IN_RELATED_SET = 0x00040000;

    [NativeTypeName("#define PACKAGE_FILTER_IS_IN_RELATED_SET PACKAGE_PROPERTY_IS_IN_RELATED_SET")]
    public const int PACKAGE_FILTER_IS_IN_RELATED_SET = 0x00040000;

    [NativeTypeName("#define PACKAGE_PROPERTY_STATIC 0x00080000")]
    public const int PACKAGE_PROPERTY_STATIC = 0x00080000;

    [NativeTypeName("#define PACKAGE_FILTER_STATIC PACKAGE_PROPERTY_STATIC")]
    public const int PACKAGE_FILTER_STATIC = 0x00080000;

    [NativeTypeName("#define PACKAGE_PROPERTY_DYNAMIC 0x00100000")]
    public const int PACKAGE_PROPERTY_DYNAMIC = 0x00100000;

    [NativeTypeName("#define PACKAGE_FILTER_DYNAMIC PACKAGE_PROPERTY_DYNAMIC")]
    public const int PACKAGE_FILTER_DYNAMIC = 0x00100000;

    [NativeTypeName("#define PACKAGE_PROPERTY_HOSTRUNTIME 0x00200000")]
    public const int PACKAGE_PROPERTY_HOSTRUNTIME = 0x00200000;

    [NativeTypeName("#define PACKAGE_FILTER_HOSTRUNTIME PACKAGE_PROPERTY_HOSTRUNTIME")]
    public const int PACKAGE_FILTER_HOSTRUNTIME = 0x00200000;

    [NativeTypeName("#define PACKAGE_FILTER_ALL_LOADED 0")]
    public const int PACKAGE_FILTER_ALL_LOADED = 0;

    [NativeTypeName("#define PACKAGE_DEPENDENCY_RANK_DEFAULT 0")]
    public const int PACKAGE_DEPENDENCY_RANK_DEFAULT = 0;
}
