// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR"]/*'/>
public enum MSITRANSFORM_ERROR
{
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_ADDEXISTINGROW"]/*'/>
    MSITRANSFORM_ERROR_ADDEXISTINGROW = 0x00000001,
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_DELMISSINGROW"]/*'/>
    MSITRANSFORM_ERROR_DELMISSINGROW = 0x00000002,
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_ADDEXISTINGTABLE"]/*'/>
    MSITRANSFORM_ERROR_ADDEXISTINGTABLE = 0x00000004,
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_DELMISSINGTABLE"]/*'/>
    MSITRANSFORM_ERROR_DELMISSINGTABLE = 0x00000008,
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_UPDATEMISSINGROW"]/*'/>
    MSITRANSFORM_ERROR_UPDATEMISSINGROW = 0x00000010,
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_CHANGECODEPAGE"]/*'/>
    MSITRANSFORM_ERROR_CHANGECODEPAGE = 0x00000020,
    /// <include file='MSITRANSFORM_ERROR.xml' path='doc/member[@name="MSITRANSFORM_ERROR.MSITRANSFORM_ERROR_VIEWTRANSFORM"]/*'/>
    MSITRANSFORM_ERROR_VIEWTRANSFORM = 0x00000100,
}