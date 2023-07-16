// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EDGE_GESTURE_KIND.xml' path='doc/member[@name="EDGE_GESTURE_KIND"]/*'/>
public enum EDGE_GESTURE_KIND
{
    /// <include file='EDGE_GESTURE_KIND.xml' path='doc/member[@name="EDGE_GESTURE_KIND.EGK_TOUCH"]/*'/>
    EGK_TOUCH = 0,
    /// <include file='EDGE_GESTURE_KIND.xml' path='doc/member[@name="EDGE_GESTURE_KIND.EGK_KEYBOARD"]/*'/>
    EGK_KEYBOARD = (EGK_TOUCH + 1),
    /// <include file='EDGE_GESTURE_KIND.xml' path='doc/member[@name="EDGE_GESTURE_KIND.EGK_MOUSE"]/*'/>
    EGK_MOUSE = (EGK_KEYBOARD + 1),
}