// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FLYOUTPARTS
{
    FLYOUT_HEADER = 1,
    FLYOUT_BODY = 2,
    FLYOUT_LABEL = 3,
    FLYOUT_LINK = 4,
    FLYOUT_DIVIDER = 5,
    FLYOUT_WINDOW = 6,
    FLYOUT_LINKAREA = 7,
    FLYOUT_LINKHEADER = 8,
}
