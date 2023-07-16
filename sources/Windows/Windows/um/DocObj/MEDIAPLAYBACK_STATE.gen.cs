// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MEDIAPLAYBACK_STATE.xml' path='doc/member[@name="MEDIAPLAYBACK_STATE"]/*'/>
public enum MEDIAPLAYBACK_STATE
{
    /// <include file='MEDIAPLAYBACK_STATE.xml' path='doc/member[@name="MEDIAPLAYBACK_STATE.MEDIAPLAYBACK_RESUME"]/*'/>
    MEDIAPLAYBACK_RESUME = 0,
    /// <include file='MEDIAPLAYBACK_STATE.xml' path='doc/member[@name="MEDIAPLAYBACK_STATE.MEDIAPLAYBACK_PAUSE"]/*'/>
    MEDIAPLAYBACK_PAUSE = 1,
    /// <include file='MEDIAPLAYBACK_STATE.xml' path='doc/member[@name="MEDIAPLAYBACK_STATE.MEDIAPLAYBACK_PAUSE_AND_SUSPEND"]/*'/>
    MEDIAPLAYBACK_PAUSE_AND_SUSPEND = 2,
    /// <include file='MEDIAPLAYBACK_STATE.xml' path='doc/member[@name="MEDIAPLAYBACK_STATE.MEDIAPLAYBACK_RESUME_FROM_SUSPEND"]/*'/>
    MEDIAPLAYBACK_RESUME_FROM_SUSPEND = 3,
}