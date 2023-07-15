// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='POINTER_FEEDBACK_MODE.xml' path='doc/member[@name="POINTER_FEEDBACK_MODE"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public enum POINTER_FEEDBACK_MODE
{
    /// <include file='POINTER_FEEDBACK_MODE.xml' path='doc/member[@name="POINTER_FEEDBACK_MODE.POINTER_FEEDBACK_DEFAULT"]/*'/>
    POINTER_FEEDBACK_DEFAULT = 1,
    /// <include file='POINTER_FEEDBACK_MODE.xml' path='doc/member[@name="POINTER_FEEDBACK_MODE.POINTER_FEEDBACK_INDIRECT"]/*'/>
    POINTER_FEEDBACK_INDIRECT = 2,
    /// <include file='POINTER_FEEDBACK_MODE.xml' path='doc/member[@name="POINTER_FEEDBACK_MODE.POINTER_FEEDBACK_NONE"]/*'/>
    POINTER_FEEDBACK_NONE = 3,
}