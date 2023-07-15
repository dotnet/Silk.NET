// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='tagBANDSITECID.xml' path='doc/member[@name="tagBANDSITECID"]/*'/>
public enum tagBANDSITECID
{
    /// <include file='tagBANDSITECID.xml' path='doc/member[@name="tagBANDSITECID.BSID_BANDADDED"]/*'/>
    BSID_BANDADDED = 0,
    /// <include file='tagBANDSITECID.xml' path='doc/member[@name="tagBANDSITECID.BSID_BANDREMOVED"]/*'/>
    BSID_BANDREMOVED = (BSID_BANDADDED + 1),
}