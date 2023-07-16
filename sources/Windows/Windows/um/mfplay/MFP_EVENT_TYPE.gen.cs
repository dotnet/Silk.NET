// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE"]/*'/>
public enum MFP_EVENT_TYPE
{
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_PLAY"]/*'/>
    MFP_EVENT_TYPE_PLAY = 0,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_PAUSE"]/*'/>
    MFP_EVENT_TYPE_PAUSE = 1,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_STOP"]/*'/>
    MFP_EVENT_TYPE_STOP = 2,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_POSITION_SET"]/*'/>
    MFP_EVENT_TYPE_POSITION_SET = 3,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_RATE_SET"]/*'/>
    MFP_EVENT_TYPE_RATE_SET = 4,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_MEDIAITEM_CREATED"]/*'/>
    MFP_EVENT_TYPE_MEDIAITEM_CREATED = 5,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_MEDIAITEM_SET"]/*'/>
    MFP_EVENT_TYPE_MEDIAITEM_SET = 6,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_FRAME_STEP"]/*'/>
    MFP_EVENT_TYPE_FRAME_STEP = 7,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_MEDIAITEM_CLEARED"]/*'/>
    MFP_EVENT_TYPE_MEDIAITEM_CLEARED = 8,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_MF"]/*'/>
    MFP_EVENT_TYPE_MF = 9,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_ERROR"]/*'/>
    MFP_EVENT_TYPE_ERROR = 10,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_PLAYBACK_ENDED"]/*'/>
    MFP_EVENT_TYPE_PLAYBACK_ENDED = 11,
    /// <include file='MFP_EVENT_TYPE.xml' path='doc/member[@name="MFP_EVENT_TYPE.MFP_EVENT_TYPE_ACQUIRE_USER_CREDENTIAL"]/*'/>
    MFP_EVENT_TYPE_ACQUIRE_USER_CREDENTIAL = 12,
}