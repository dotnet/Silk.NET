// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPIDSPTSI.xml' path='doc/member[@name="DISPIDSPTSI"]/*'/>
public enum DISPIDSPTSI
{
    /// <include file='DISPIDSPTSI.xml' path='doc/member[@name="DISPIDSPTSI.DISPIDSPTSI_ActiveOffset"]/*'/>
    DISPIDSPTSI_ActiveOffset = 1,
    /// <include file='DISPIDSPTSI.xml' path='doc/member[@name="DISPIDSPTSI.DISPIDSPTSI_ActiveLength"]/*'/>
    DISPIDSPTSI_ActiveLength = (DISPIDSPTSI_ActiveOffset + 1),
    /// <include file='DISPIDSPTSI.xml' path='doc/member[@name="DISPIDSPTSI.DISPIDSPTSI_SelectionOffset"]/*'/>
    DISPIDSPTSI_SelectionOffset = (DISPIDSPTSI_ActiveLength + 1),
    /// <include file='DISPIDSPTSI.xml' path='doc/member[@name="DISPIDSPTSI.DISPIDSPTSI_SelectionLength"]/*'/>
    DISPIDSPTSI_SelectionLength = (DISPIDSPTSI_SelectionOffset + 1),
}