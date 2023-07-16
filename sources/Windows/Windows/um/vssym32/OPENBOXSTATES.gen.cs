// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OPENBOXSTATES.xml' path='doc/member[@name="OPENBOXSTATES"]/*'/>
public enum OPENBOXSTATES
{
    /// <include file='OPENBOXSTATES.xml' path='doc/member[@name="OPENBOXSTATES.SPOB_NORMAL"]/*'/>
    SPOB_NORMAL = 1,
    /// <include file='OPENBOXSTATES.xml' path='doc/member[@name="OPENBOXSTATES.SPOB_HOT"]/*'/>
    SPOB_HOT = 2,
    /// <include file='OPENBOXSTATES.xml' path='doc/member[@name="OPENBOXSTATES.SPOB_SELECTED"]/*'/>
    SPOB_SELECTED = 3,
    /// <include file='OPENBOXSTATES.xml' path='doc/member[@name="OPENBOXSTATES.SPOB_DISABLED"]/*'/>
    SPOB_DISABLED = 4,
    /// <include file='OPENBOXSTATES.xml' path='doc/member[@name="OPENBOXSTATES.SPOB_FOCUSED"]/*'/>
    SPOB_FOCUSED = 5,
}