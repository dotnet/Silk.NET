// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPBOOKMARKOPTIONS.xml' path='doc/member[@name="SPBOOKMARKOPTIONS"]/*'/>
public enum SPBOOKMARKOPTIONS
{
    /// <include file='SPBOOKMARKOPTIONS.xml' path='doc/member[@name="SPBOOKMARKOPTIONS.SPBO_NONE"]/*'/>
    SPBO_NONE = 0,
    /// <include file='SPBOOKMARKOPTIONS.xml' path='doc/member[@name="SPBOOKMARKOPTIONS.SPBO_PAUSE"]/*'/>
    SPBO_PAUSE = (1 << 0),
    /// <include file='SPBOOKMARKOPTIONS.xml' path='doc/member[@name="SPBOOKMARKOPTIONS.SPBO_AHEAD"]/*'/>
    SPBO_AHEAD = (1 << 1),
    /// <include file='SPBOOKMARKOPTIONS.xml' path='doc/member[@name="SPBOOKMARKOPTIONS.SPBO_TIME_UNITS"]/*'/>
    SPBO_TIME_UNITS = (1 << 2),
}