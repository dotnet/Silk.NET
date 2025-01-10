// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _MFP_MEDIAITEM_CHARACTERISTICS
{
    MFP_MEDIAITEM_IS_LIVE = 0x1,
    MFP_MEDIAITEM_CAN_SEEK = 0x2,
    MFP_MEDIAITEM_CAN_PAUSE = 0x4,
    MFP_MEDIAITEM_HAS_SLOW_SEEK = 0x8,
}
