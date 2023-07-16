// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class ENABLE
{
    [NativeTypeName("#define ENABLE_TLS_CLIENT_EARLY_START 0x00000001")]
    public const int ENABLE_TLS_CLIENT_EARLY_START = 0x00000001;
}