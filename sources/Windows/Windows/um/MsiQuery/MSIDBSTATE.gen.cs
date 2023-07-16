// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSIDBSTATE.xml' path='doc/member[@name="MSIDBSTATE"]/*'/>
public enum MSIDBSTATE
{
    /// <include file='MSIDBSTATE.xml' path='doc/member[@name="MSIDBSTATE.MSIDBSTATE_ERROR"]/*'/>
    MSIDBSTATE_ERROR = -1,
    /// <include file='MSIDBSTATE.xml' path='doc/member[@name="MSIDBSTATE.MSIDBSTATE_READ"]/*'/>
    MSIDBSTATE_READ = 0,
    /// <include file='MSIDBSTATE.xml' path='doc/member[@name="MSIDBSTATE.MSIDBSTATE_WRITE"]/*'/>
    MSIDBSTATE_WRITE = 1,
}