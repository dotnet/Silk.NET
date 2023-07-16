// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='READYSTATE.xml' path='doc/member[@name="READYSTATE"]/*'/>
public enum READYSTATE
{
    /// <include file='READYSTATE.xml' path='doc/member[@name="READYSTATE.READYSTATE_UNINITIALIZED"]/*'/>
    READYSTATE_UNINITIALIZED = 0,
    /// <include file='READYSTATE.xml' path='doc/member[@name="READYSTATE.READYSTATE_LOADING"]/*'/>
    READYSTATE_LOADING = 1,
    /// <include file='READYSTATE.xml' path='doc/member[@name="READYSTATE.READYSTATE_LOADED"]/*'/>
    READYSTATE_LOADED = 2,
    /// <include file='READYSTATE.xml' path='doc/member[@name="READYSTATE.READYSTATE_INTERACTIVE"]/*'/>
    READYSTATE_INTERACTIVE = 3,
    /// <include file='READYSTATE.xml' path='doc/member[@name="READYSTATE.READYSTATE_COMPLETE"]/*'/>
    READYSTATE_COMPLETE = 4,
}