// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_GUID_CHARS 38")]
    public const int MAX_GUID_CHARS = 38;
    [NativeTypeName("#define MAX_FEATURE_CHARS 38")]
    public const int MAX_FEATURE_CHARS = 38;
}