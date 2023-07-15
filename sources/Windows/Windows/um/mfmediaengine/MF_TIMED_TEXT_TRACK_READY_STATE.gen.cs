// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_TIMED_TEXT_TRACK_READY_STATE.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_READY_STATE"]/*'/>
public enum MF_TIMED_TEXT_TRACK_READY_STATE
{
    /// <include file='MF_TIMED_TEXT_TRACK_READY_STATE.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_READY_STATE.MF_TIMED_TEXT_TRACK_READY_STATE_NONE"]/*'/>
    MF_TIMED_TEXT_TRACK_READY_STATE_NONE = 0,
    /// <include file='MF_TIMED_TEXT_TRACK_READY_STATE.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_READY_STATE.MF_TIMED_TEXT_TRACK_READY_STATE_LOADING"]/*'/>
    MF_TIMED_TEXT_TRACK_READY_STATE_LOADING = (MF_TIMED_TEXT_TRACK_READY_STATE_NONE + 1),
    /// <include file='MF_TIMED_TEXT_TRACK_READY_STATE.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_READY_STATE.MF_TIMED_TEXT_TRACK_READY_STATE_LOADED"]/*'/>
    MF_TIMED_TEXT_TRACK_READY_STATE_LOADED = (MF_TIMED_TEXT_TRACK_READY_STATE_LOADING + 1),
    /// <include file='MF_TIMED_TEXT_TRACK_READY_STATE.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_READY_STATE.MF_TIMED_TEXT_TRACK_READY_STATE_ERROR"]/*'/>
    MF_TIMED_TEXT_TRACK_READY_STATE_ERROR = (MF_TIMED_TEXT_TRACK_READY_STATE_LOADED + 1),
}