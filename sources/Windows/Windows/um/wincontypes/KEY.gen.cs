// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class KEY
{
    [NativeTypeName("#define KEY_EVENT 0x0001")]
    public const int KEY_EVENT = 0x0001;
}