// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='APPLICATION_VIEW_STATE.xml' path='doc/member[@name="APPLICATION_VIEW_STATE"]/*'/>
public enum APPLICATION_VIEW_STATE
{
    /// <include file='APPLICATION_VIEW_STATE.xml' path='doc/member[@name="APPLICATION_VIEW_STATE.AVS_FULLSCREEN_LANDSCAPE"]/*'/>
    AVS_FULLSCREEN_LANDSCAPE = 0,
    /// <include file='APPLICATION_VIEW_STATE.xml' path='doc/member[@name="APPLICATION_VIEW_STATE.AVS_FILLED"]/*'/>
    AVS_FILLED = (AVS_FULLSCREEN_LANDSCAPE + 1),
    /// <include file='APPLICATION_VIEW_STATE.xml' path='doc/member[@name="APPLICATION_VIEW_STATE.AVS_SNAPPED"]/*'/>
    AVS_SNAPPED = (AVS_FILLED + 1),
    /// <include file='APPLICATION_VIEW_STATE.xml' path='doc/member[@name="APPLICATION_VIEW_STATE.AVS_FULLSCREEN_PORTRAIT"]/*'/>
    AVS_FULLSCREEN_PORTRAIT = (AVS_SNAPPED + 1),
}