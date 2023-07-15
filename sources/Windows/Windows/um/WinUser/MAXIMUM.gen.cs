// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static unsafe partial class MAXIMUM
{
    [NativeTypeName("#define MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID MAKEINTRESOURCE(16 /*inclusive*/)")]
    public static ushort* MAXIMUM_RESERVED_MANIFEST_RESOURCE_ID => ((ushort*)((nuint)((ushort)(16))));
}