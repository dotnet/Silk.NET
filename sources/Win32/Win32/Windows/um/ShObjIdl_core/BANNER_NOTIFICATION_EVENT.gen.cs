// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum BANNER_NOTIFICATION_EVENT
{
    BNE_Rendered = 0,
    BNE_Hovered = (BNE_Rendered + 1),
    BNE_Closed = (BNE_Hovered + 1),
    BNE_Dismissed = (BNE_Closed + 1),
    BNE_Button1Clicked = (BNE_Dismissed + 1),
    BNE_Button2Clicked = (BNE_Button1Clicked + 1),
}
