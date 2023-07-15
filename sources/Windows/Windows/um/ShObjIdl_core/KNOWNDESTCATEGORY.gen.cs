// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KNOWNDESTCATEGORY.xml' path='doc/member[@name="KNOWNDESTCATEGORY"]/*'/>
public enum KNOWNDESTCATEGORY
{
    /// <include file='KNOWNDESTCATEGORY.xml' path='doc/member[@name="KNOWNDESTCATEGORY.KDC_FREQUENT"]/*'/>
    KDC_FREQUENT = 1,
    /// <include file='KNOWNDESTCATEGORY.xml' path='doc/member[@name="KNOWNDESTCATEGORY.KDC_RECENT"]/*'/>
    KDC_RECENT = (KDC_FREQUENT + 1),
}