// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags"]/*'/>
public enum MFVideoFlags
{
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_PAD_TO_Mask"]/*'/>
    MFVideoFlag_PAD_TO_Mask = (0x1 | 0x2),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_PAD_TO_None"]/*'/>
    MFVideoFlag_PAD_TO_None = (0 * 0x1),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_PAD_TO_4x3"]/*'/>
    MFVideoFlag_PAD_TO_4x3 = (1 * 0x1),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_PAD_TO_16x9"]/*'/>
    MFVideoFlag_PAD_TO_16x9 = (2 * 0x1),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_SrcContentHintMask"]/*'/>
    MFVideoFlag_SrcContentHintMask = ((0x4 | 0x8) | 0x10),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_SrcContentHintNone"]/*'/>
    MFVideoFlag_SrcContentHintNone = (0 * 0x4),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_SrcContentHint16x9"]/*'/>
    MFVideoFlag_SrcContentHint16x9 = (1 * 0x4),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_SrcContentHint235_1"]/*'/>
    MFVideoFlag_SrcContentHint235_1 = (2 * 0x4),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_AnalogProtected"]/*'/>
    MFVideoFlag_AnalogProtected = 0x20,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_DigitallyProtected"]/*'/>
    MFVideoFlag_DigitallyProtected = 0x40,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_ProgressiveContent"]/*'/>
    MFVideoFlag_ProgressiveContent = 0x80,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_FieldRepeatCountMask"]/*'/>
    MFVideoFlag_FieldRepeatCountMask = ((0x100 | 0x200) | 0x400),
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_FieldRepeatCountShift"]/*'/>
    MFVideoFlag_FieldRepeatCountShift = 8,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_ProgressiveSeqReset"]/*'/>
    MFVideoFlag_ProgressiveSeqReset = 0x800,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_PanScanEnabled"]/*'/>
    MFVideoFlag_PanScanEnabled = 0x20000,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_LowerFieldFirst"]/*'/>
    MFVideoFlag_LowerFieldFirst = 0x40000,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlag_BottomUpLinearRep"]/*'/>
    MFVideoFlag_BottomUpLinearRep = 0x80000,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlags_DXVASurface"]/*'/>
    MFVideoFlags_DXVASurface = 0x100000,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlags_RenderTargetSurface"]/*'/>
    MFVideoFlags_RenderTargetSurface = 0x400000,
    /// <include file='MFVideoFlags.xml' path='doc/member[@name="MFVideoFlags.MFVideoFlags_ForceQWORD"]/*'/>
    MFVideoFlags_ForceQWORD = 0x7fffffff,
}