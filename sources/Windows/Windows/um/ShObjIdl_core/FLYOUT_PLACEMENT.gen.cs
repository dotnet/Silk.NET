// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FLYOUT_PLACEMENT.xml' path='doc/member[@name="FLYOUT_PLACEMENT"]/*'/>
public enum FLYOUT_PLACEMENT
{
    /// <include file='FLYOUT_PLACEMENT.xml' path='doc/member[@name="FLYOUT_PLACEMENT.FP_DEFAULT"]/*'/>
    FP_DEFAULT = 0,
    /// <include file='FLYOUT_PLACEMENT.xml' path='doc/member[@name="FLYOUT_PLACEMENT.FP_ABOVE"]/*'/>
    FP_ABOVE = (FP_DEFAULT + 1),
    /// <include file='FLYOUT_PLACEMENT.xml' path='doc/member[@name="FLYOUT_PLACEMENT.FP_BELOW"]/*'/>
    FP_BELOW = (FP_ABOVE + 1),
    /// <include file='FLYOUT_PLACEMENT.xml' path='doc/member[@name="FLYOUT_PLACEMENT.FP_LEFT"]/*'/>
    FP_LEFT = (FP_BELOW + 1),
    /// <include file='FLYOUT_PLACEMENT.xml' path='doc/member[@name="FLYOUT_PLACEMENT.FP_RIGHT"]/*'/>
    FP_RIGHT = (FP_LEFT + 1),
}