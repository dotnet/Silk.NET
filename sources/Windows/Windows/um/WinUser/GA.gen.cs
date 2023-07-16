// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class GA
{
    [NativeTypeName("#define GA_PARENT 1")]
    public const int GA_PARENT = 1;
    [NativeTypeName("#define GA_ROOT 2")]
    public const int GA_ROOT = 2;
    [NativeTypeName("#define GA_ROOTOWNER 3")]
    public const int GA_ROOTOWNER = 3;
}