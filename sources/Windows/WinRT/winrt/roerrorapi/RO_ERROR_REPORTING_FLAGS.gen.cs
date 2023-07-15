// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.WinRT;
/// <include file='RO_ERROR_REPORTING_FLAGS.xml' path='doc/member[@name="RO_ERROR_REPORTING_FLAGS"]/*'/>
[Flags]
public enum RO_ERROR_REPORTING_FLAGS
{
    /// <include file='RO_ERROR_REPORTING_FLAGS.xml' path='doc/member[@name="RO_ERROR_REPORTING_FLAGS.RO_ERROR_REPORTING_NONE"]/*'/>
    RO_ERROR_REPORTING_NONE = 0x00000000,
    /// <include file='RO_ERROR_REPORTING_FLAGS.xml' path='doc/member[@name="RO_ERROR_REPORTING_FLAGS.RO_ERROR_REPORTING_SUPPRESSEXCEPTIONS"]/*'/>
    RO_ERROR_REPORTING_SUPPRESSEXCEPTIONS = 0x00000001,
    /// <include file='RO_ERROR_REPORTING_FLAGS.xml' path='doc/member[@name="RO_ERROR_REPORTING_FLAGS.RO_ERROR_REPORTING_FORCEEXCEPTIONS"]/*'/>
    RO_ERROR_REPORTING_FORCEEXCEPTIONS = 0x00000002,
    /// <include file='RO_ERROR_REPORTING_FLAGS.xml' path='doc/member[@name="RO_ERROR_REPORTING_FLAGS.RO_ERROR_REPORTING_USESETERRORINFO"]/*'/>
    RO_ERROR_REPORTING_USESETERRORINFO = 0x00000004,
    /// <include file='RO_ERROR_REPORTING_FLAGS.xml' path='doc/member[@name="RO_ERROR_REPORTING_FLAGS.RO_ERROR_REPORTING_SUPPRESSSETERRORINFO"]/*'/>
    RO_ERROR_REPORTING_SUPPRESSSETERRORINFO = 0x00000008,
}