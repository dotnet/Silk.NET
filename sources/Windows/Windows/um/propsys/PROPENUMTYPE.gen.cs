// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROPENUMTYPE.xml' path='doc/member[@name="PROPENUMTYPE"]/*'/>
public enum PROPENUMTYPE
{
    /// <include file='PROPENUMTYPE.xml' path='doc/member[@name="PROPENUMTYPE.PET_DISCRETEVALUE"]/*'/>
    PET_DISCRETEVALUE = 0,
    /// <include file='PROPENUMTYPE.xml' path='doc/member[@name="PROPENUMTYPE.PET_RANGEDVALUE"]/*'/>
    PET_RANGEDVALUE = 1,
    /// <include file='PROPENUMTYPE.xml' path='doc/member[@name="PROPENUMTYPE.PET_DEFAULTVALUE"]/*'/>
    PET_DEFAULTVALUE = 2,
    /// <include file='PROPENUMTYPE.xml' path='doc/member[@name="PROPENUMTYPE.PET_ENDRANGE"]/*'/>
    PET_ENDRANGE = 3,
}