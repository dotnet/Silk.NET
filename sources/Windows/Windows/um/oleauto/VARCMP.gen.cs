// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class VARCMP
{
    [NativeTypeName("#define VARCMP_LT 0")]
    public const int VARCMP_LT = 0;
    [NativeTypeName("#define VARCMP_EQ 1")]
    public const int VARCMP_EQ = 1;
    [NativeTypeName("#define VARCMP_GT 2")]
    public const int VARCMP_GT = 2;
    [NativeTypeName("#define VARCMP_NULL 3")]
    public const int VARCMP_NULL = 3;
}