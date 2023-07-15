// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_PIN_NAME 128")]
    public const int MAX_PIN_NAME = 128;
    [NativeTypeName("#define MAX_FILTER_NAME 128")]
    public const int MAX_FILTER_NAME = 128;
}