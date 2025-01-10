// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum IURL_SETURL_FLAGS
{
    IURL_SETURL_FL_GUESS_PROTOCOL = 0x0001,
    IURL_SETURL_FL_USE_DEFAULT_PROTOCOL = 0x0002,
}
