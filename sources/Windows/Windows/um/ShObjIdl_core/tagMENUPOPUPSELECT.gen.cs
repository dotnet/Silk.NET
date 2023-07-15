// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT"]/*'/>
public enum tagMENUPOPUPSELECT
{
    /// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT.MPOS_EXECUTE"]/*'/>
    MPOS_EXECUTE = 0,
    /// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT.MPOS_FULLCANCEL"]/*'/>
    MPOS_FULLCANCEL = (MPOS_EXECUTE + 1),
    /// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT.MPOS_CANCELLEVEL"]/*'/>
    MPOS_CANCELLEVEL = (MPOS_FULLCANCEL + 1),
    /// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT.MPOS_SELECTLEFT"]/*'/>
    MPOS_SELECTLEFT = (MPOS_CANCELLEVEL + 1),
    /// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT.MPOS_SELECTRIGHT"]/*'/>
    MPOS_SELECTRIGHT = (MPOS_SELECTLEFT + 1),
    /// <include file='tagMENUPOPUPSELECT.xml' path='doc/member[@name="tagMENUPOPUPSELECT.MPOS_CHILDTRACKING"]/*'/>
    MPOS_CHILDTRACKING = (MPOS_SELECTRIGHT + 1),
}