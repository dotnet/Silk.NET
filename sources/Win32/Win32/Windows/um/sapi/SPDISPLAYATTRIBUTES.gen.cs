// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPDISPLAYATTRIBUTES
{
    SPAF_ONE_TRAILING_SPACE = 0x2,
    SPAF_TWO_TRAILING_SPACES = 0x4,
    SPAF_CONSUME_LEADING_SPACES = 0x8,
    SPAF_BUFFER_POSITION = 0x10,
    SPAF_ALL = 0x1f,
    SPAF_USER_SPECIFIED = 0x80,
}
