// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fci.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR"]/*'/>
public enum FCIERROR
{
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_NONE"]/*'/>
    FCIERR_NONE,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_OPEN_SRC"]/*'/>
    FCIERR_OPEN_SRC,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_READ_SRC"]/*'/>
    FCIERR_READ_SRC,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_ALLOC_FAIL"]/*'/>
    FCIERR_ALLOC_FAIL,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_TEMP_FILE"]/*'/>
    FCIERR_TEMP_FILE,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_BAD_COMPR_TYPE"]/*'/>
    FCIERR_BAD_COMPR_TYPE,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_CAB_FILE"]/*'/>
    FCIERR_CAB_FILE,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_USER_ABORT"]/*'/>
    FCIERR_USER_ABORT,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_MCI_FAIL"]/*'/>
    FCIERR_MCI_FAIL,
    /// <include file='FCIERROR.xml' path='doc/member[@name="FCIERROR.FCIERR_CAB_FORMAT_LIMIT"]/*'/>
    FCIERR_CAB_FORMAT_LIMIT,
}