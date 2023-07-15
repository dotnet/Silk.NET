// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TASKLINKSTATES.xml' path='doc/member[@name="TASKLINKSTATES"]/*'/>
public enum TASKLINKSTATES
{
    /// <include file='TASKLINKSTATES.xml' path='doc/member[@name="TASKLINKSTATES.CPTL_NORMAL"]/*'/>
    CPTL_NORMAL = 1,
    /// <include file='TASKLINKSTATES.xml' path='doc/member[@name="TASKLINKSTATES.CPTL_HOT"]/*'/>
    CPTL_HOT = 2,
    /// <include file='TASKLINKSTATES.xml' path='doc/member[@name="TASKLINKSTATES.CPTL_PRESSED"]/*'/>
    CPTL_PRESSED = 3,
    /// <include file='TASKLINKSTATES.xml' path='doc/member[@name="TASKLINKSTATES.CPTL_DISABLED"]/*'/>
    CPTL_DISABLED = 4,
    /// <include file='TASKLINKSTATES.xml' path='doc/member[@name="TASKLINKSTATES.CPTL_PAGE"]/*'/>
    CPTL_PAGE = 5,
}