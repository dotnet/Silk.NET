// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_EXTENDED_OPTIONS.xml' path='doc/member[@name="IMAGEHLP_EXTENDED_OPTIONS"]/*'/>
public enum IMAGEHLP_EXTENDED_OPTIONS
{
    /// <include file='IMAGEHLP_EXTENDED_OPTIONS.xml' path='doc/member[@name="IMAGEHLP_EXTENDED_OPTIONS.SYMOPT_EX_DISABLEACCESSTIMEUPDATE"]/*'/>
    SYMOPT_EX_DISABLEACCESSTIMEUPDATE,
    /// <include file='IMAGEHLP_EXTENDED_OPTIONS.xml' path='doc/member[@name="IMAGEHLP_EXTENDED_OPTIONS.SYMOPT_EX_LASTVALIDDEBUGDIRECTORY"]/*'/>
    SYMOPT_EX_LASTVALIDDEBUGDIRECTORY,
    /// <include file='IMAGEHLP_EXTENDED_OPTIONS.xml' path='doc/member[@name="IMAGEHLP_EXTENDED_OPTIONS.SYMOPT_EX_NOIMPLICITPATTERNSEARCH"]/*'/>
    SYMOPT_EX_NOIMPLICITPATTERNSEARCH,
    /// <include file='IMAGEHLP_EXTENDED_OPTIONS.xml' path='doc/member[@name="IMAGEHLP_EXTENDED_OPTIONS.SYMOPT_EX_NEVERLOADSYMBOLS"]/*'/>
    SYMOPT_EX_NEVERLOADSYMBOLS,
    /// <include file='IMAGEHLP_EXTENDED_OPTIONS.xml' path='doc/member[@name="IMAGEHLP_EXTENDED_OPTIONS.SYMOPT_EX_MAX"]/*'/>
    SYMOPT_EX_MAX,
}