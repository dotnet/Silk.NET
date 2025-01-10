// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFVideoFlags
{
    MFVideoFlag_PAD_TO_Mask = (0x1 | 0x2),
    MFVideoFlag_PAD_TO_None = (0 * 0x1),
    MFVideoFlag_PAD_TO_4x3 = (1 * 0x1),
    MFVideoFlag_PAD_TO_16x9 = (2 * 0x1),
    MFVideoFlag_SrcContentHintMask = ((0x4 | 0x8) | 0x10),
    MFVideoFlag_SrcContentHintNone = (0 * 0x4),
    MFVideoFlag_SrcContentHint16x9 = (1 * 0x4),
    MFVideoFlag_SrcContentHint235_1 = (2 * 0x4),
    MFVideoFlag_AnalogProtected = 0x20,
    MFVideoFlag_DigitallyProtected = 0x40,
    MFVideoFlag_ProgressiveContent = 0x80,
    MFVideoFlag_FieldRepeatCountMask = ((0x100 | 0x200) | 0x400),
    MFVideoFlag_FieldRepeatCountShift = 8,
    MFVideoFlag_ProgressiveSeqReset = 0x800,
    MFVideoFlag_PanScanEnabled = 0x20000,
    MFVideoFlag_LowerFieldFirst = 0x40000,
    MFVideoFlag_BottomUpLinearRep = 0x80000,
    MFVideoFlags_DXVASurface = 0x100000,
    MFVideoFlags_RenderTargetSurface = 0x400000,
    MFVideoFlags_ForceQWORD = 0x7fffffff,
}
