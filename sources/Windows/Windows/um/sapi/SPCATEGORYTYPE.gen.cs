// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPCATEGORYTYPE.xml' path='doc/member[@name="SPCATEGORYTYPE"]/*'/>
public enum SPCATEGORYTYPE
{
    /// <include file='SPCATEGORYTYPE.xml' path='doc/member[@name="SPCATEGORYTYPE.SPCT_COMMAND"]/*'/>
    SPCT_COMMAND = 0,
    /// <include file='SPCATEGORYTYPE.xml' path='doc/member[@name="SPCATEGORYTYPE.SPCT_DICTATION"]/*'/>
    SPCT_DICTATION = (SPCT_COMMAND + 1),
    /// <include file='SPCATEGORYTYPE.xml' path='doc/member[@name="SPCATEGORYTYPE.SPCT_SLEEP"]/*'/>
    SPCT_SLEEP = (SPCT_DICTATION + 1),
    /// <include file='SPCATEGORYTYPE.xml' path='doc/member[@name="SPCATEGORYTYPE.SPCT_SUB_COMMAND"]/*'/>
    SPCT_SUB_COMMAND = (SPCT_SLEEP + 1),
    /// <include file='SPCATEGORYTYPE.xml' path='doc/member[@name="SPCATEGORYTYPE.SPCT_SUB_DICTATION"]/*'/>
    SPCT_SUB_DICTATION = (SPCT_SUB_COMMAND + 1),
}