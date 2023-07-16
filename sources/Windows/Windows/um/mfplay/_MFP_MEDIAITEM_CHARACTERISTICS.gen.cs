// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='_MFP_MEDIAITEM_CHARACTERISTICS.xml' path='doc/member[@name="_MFP_MEDIAITEM_CHARACTERISTICS"]/*'/>
public enum _MFP_MEDIAITEM_CHARACTERISTICS
{
    /// <include file='_MFP_MEDIAITEM_CHARACTERISTICS.xml' path='doc/member[@name="_MFP_MEDIAITEM_CHARACTERISTICS.MFP_MEDIAITEM_IS_LIVE"]/*'/>
    MFP_MEDIAITEM_IS_LIVE = 0x1,
    /// <include file='_MFP_MEDIAITEM_CHARACTERISTICS.xml' path='doc/member[@name="_MFP_MEDIAITEM_CHARACTERISTICS.MFP_MEDIAITEM_CAN_SEEK"]/*'/>
    MFP_MEDIAITEM_CAN_SEEK = 0x2,
    /// <include file='_MFP_MEDIAITEM_CHARACTERISTICS.xml' path='doc/member[@name="_MFP_MEDIAITEM_CHARACTERISTICS.MFP_MEDIAITEM_CAN_PAUSE"]/*'/>
    MFP_MEDIAITEM_CAN_PAUSE = 0x4,
    /// <include file='_MFP_MEDIAITEM_CHARACTERISTICS.xml' path='doc/member[@name="_MFP_MEDIAITEM_CHARACTERISTICS.MFP_MEDIAITEM_HAS_SLOW_SEEK"]/*'/>
    MFP_MEDIAITEM_HAS_SLOW_SEEK = 0x8,
}