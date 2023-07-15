// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using static TerraFX.Interop.WinRT.RO_ERROR_REPORTING_FLAGS;

namespace TerraFX.Interop.WinRT;
/// <include file='RoErrorReportingFlags.xml' path='doc/member[@name="RoErrorReportingFlags"]/*'/>
[Flags]
public enum RoErrorReportingFlags
{
    /// <include file='RoErrorReportingFlags.xml' path='doc/member[@name="RoErrorReportingFlags.None"]/*'/>
    None = RO_ERROR_REPORTING_NONE,
    /// <include file='RoErrorReportingFlags.xml' path='doc/member[@name="RoErrorReportingFlags.SuppressExceptions"]/*'/>
    SuppressExceptions = RO_ERROR_REPORTING_SUPPRESSEXCEPTIONS,
    /// <include file='RoErrorReportingFlags.xml' path='doc/member[@name="RoErrorReportingFlags.ForceExceptions"]/*'/>
    ForceExceptions = RO_ERROR_REPORTING_FORCEEXCEPTIONS,
    /// <include file='RoErrorReportingFlags.xml' path='doc/member[@name="RoErrorReportingFlags.UseSetErrorInfo"]/*'/>
    UseSetErrorInfo = RO_ERROR_REPORTING_USESETERRORINFO,
    /// <include file='RoErrorReportingFlags.xml' path='doc/member[@name="RoErrorReportingFlags.SuppressSetErrorInfo"]/*'/>
    SuppressSetErrorInfo = RO_ERROR_REPORTING_SUPPRESSSETERRORINFO,
}