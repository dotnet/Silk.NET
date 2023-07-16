// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPFILEMODE.xml' path='doc/member[@name="SPFILEMODE"]/*'/>
public enum SPFILEMODE
{
    /// <include file='SPFILEMODE.xml' path='doc/member[@name="SPFILEMODE.SPFM_OPEN_READONLY"]/*'/>
    SPFM_OPEN_READONLY = 0,
    /// <include file='SPFILEMODE.xml' path='doc/member[@name="SPFILEMODE.SPFM_OPEN_READWRITE"]/*'/>
    SPFM_OPEN_READWRITE = (SPFM_OPEN_READONLY + 1),
    /// <include file='SPFILEMODE.xml' path='doc/member[@name="SPFILEMODE.SPFM_CREATE"]/*'/>
    SPFM_CREATE = (SPFM_OPEN_READWRITE + 1),
    /// <include file='SPFILEMODE.xml' path='doc/member[@name="SPFILEMODE.SPFM_CREATE_ALWAYS"]/*'/>
    SPFM_CREATE_ALWAYS = (SPFM_CREATE + 1),
    /// <include file='SPFILEMODE.xml' path='doc/member[@name="SPFILEMODE.SPFM_NUM_MODES"]/*'/>
    SPFM_NUM_MODES = (SPFM_CREATE_ALWAYS + 1),
}