// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define STRICT 1")]
    public const int STRICT = 1;
    [NativeTypeName("#define FALSE 0")]
    public const int FALSE = 0;
    [NativeTypeName("#define TRUE 1")]
    public const int TRUE = 1;
}