// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_SYNCMGRITEMNAME ( 128 )")]
    public const int MAX_SYNCMGRITEMNAME = (128);
    [NativeTypeName("#define MAX_SYNCMGRHANDLERNAME ( 32 )")]
    public const int MAX_SYNCMGRHANDLERNAME = (32);
}