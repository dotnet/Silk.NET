// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TASKBARPARTS
{
    TBP_BACKGROUNDBOTTOM = 1,
    TBP_BACKGROUNDRIGHT = 2,
    TBP_BACKGROUNDTOP = 3,
    TBP_BACKGROUNDLEFT = 4,
    TBP_SIZINGBARBOTTOM = 5,
    TBP_SIZINGBARRIGHT = 6,
    TBP_SIZINGBARTOP = 7,
    TBP_SIZINGBARLEFT = 8,
}
