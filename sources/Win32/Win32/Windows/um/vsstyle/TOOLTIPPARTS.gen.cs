// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TOOLTIPPARTS
{
    TTP_STANDARD = 1,
    TTP_STANDARDTITLE = 2,
    TTP_BALLOON = 3,
    TTP_BALLOONTITLE = 4,
    TTP_CLOSE = 5,
    TTP_BALLOONSTEM = 6,
    TTP_WRENCH = 7,
}
