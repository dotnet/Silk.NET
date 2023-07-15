// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT"]/*'/>
public enum BANNER_NOTIFICATION_EVENT
{
    /// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT.BNE_Rendered"]/*'/>
    BNE_Rendered = 0,
    /// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT.BNE_Hovered"]/*'/>
    BNE_Hovered = (BNE_Rendered + 1),
    /// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT.BNE_Closed"]/*'/>
    BNE_Closed = (BNE_Hovered + 1),
    /// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT.BNE_Dismissed"]/*'/>
    BNE_Dismissed = (BNE_Closed + 1),
    /// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT.BNE_Button1Clicked"]/*'/>
    BNE_Button1Clicked = (BNE_Dismissed + 1),
    /// <include file='BANNER_NOTIFICATION_EVENT.xml' path='doc/member[@name="BANNER_NOTIFICATION_EVENT.BNE_Button2Clicked"]/*'/>
    BNE_Button2Clicked = (BNE_Button1Clicked + 1),
}