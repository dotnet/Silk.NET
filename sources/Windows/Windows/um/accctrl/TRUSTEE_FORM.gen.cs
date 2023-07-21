// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRUSTEE_FORM.xml' path='doc/member[@name="TRUSTEE_FORM"]/*' />
public enum TRUSTEE_FORM
{
    /// <include file='TRUSTEE_FORM.xml' path='doc/member[@name="TRUSTEE_FORM.TRUSTEE_IS_SID"]/*' />
    TRUSTEE_IS_SID,

    /// <include file='TRUSTEE_FORM.xml' path='doc/member[@name="TRUSTEE_FORM.TRUSTEE_IS_NAME"]/*' />
    TRUSTEE_IS_NAME,

    /// <include file='TRUSTEE_FORM.xml' path='doc/member[@name="TRUSTEE_FORM.TRUSTEE_BAD_FORM"]/*' />
    TRUSTEE_BAD_FORM,

    /// <include file='TRUSTEE_FORM.xml' path='doc/member[@name="TRUSTEE_FORM.TRUSTEE_IS_OBJECTS_AND_SID"]/*' />
    TRUSTEE_IS_OBJECTS_AND_SID,

    /// <include file='TRUSTEE_FORM.xml' path='doc/member[@name="TRUSTEE_FORM.TRUSTEE_IS_OBJECTS_AND_NAME"]/*' />
    TRUSTEE_IS_OBJECTS_AND_NAME,
}
