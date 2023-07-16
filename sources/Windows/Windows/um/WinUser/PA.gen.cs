// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PA
{
    [NativeTypeName("#define PA_ACTIVATE MA_ACTIVATE")]
    public const int PA_ACTIVATE = 1;
    [NativeTypeName("#define PA_NOACTIVATE MA_NOACTIVATE")]
    public const int PA_NOACTIVATE = 3;
}