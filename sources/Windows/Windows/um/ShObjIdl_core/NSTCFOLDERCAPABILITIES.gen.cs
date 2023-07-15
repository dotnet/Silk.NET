// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NSTCFOLDERCAPABILITIES.xml' path='doc/member[@name="NSTCFOLDERCAPABILITIES"]/*'/>
public enum NSTCFOLDERCAPABILITIES
{
    /// <include file='NSTCFOLDERCAPABILITIES.xml' path='doc/member[@name="NSTCFOLDERCAPABILITIES.NSTCFC_NONE"]/*'/>
    NSTCFC_NONE = 0,
    /// <include file='NSTCFOLDERCAPABILITIES.xml' path='doc/member[@name="NSTCFOLDERCAPABILITIES.NSTCFC_PINNEDITEMFILTERING"]/*'/>
    NSTCFC_PINNEDITEMFILTERING = 0x1,
    /// <include file='NSTCFOLDERCAPABILITIES.xml' path='doc/member[@name="NSTCFOLDERCAPABILITIES.NSTCFC_DELAY_REGISTER_NOTIFY"]/*'/>
    NSTCFC_DELAY_REGISTER_NOTIFY = 0x2,
}