// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_DVDCOPYSTATE.xml' path='doc/member[@name="AM_DVDCOPYSTATE"]/*'/>
public enum AM_DVDCOPYSTATE
{
    /// <include file='AM_DVDCOPYSTATE.xml' path='doc/member[@name="AM_DVDCOPYSTATE.AM_DVDCOPYSTATE_INITIALIZE"]/*'/>
    AM_DVDCOPYSTATE_INITIALIZE = 0,
    /// <include file='AM_DVDCOPYSTATE.xml' path='doc/member[@name="AM_DVDCOPYSTATE.AM_DVDCOPYSTATE_INITIALIZE_TITLE"]/*'/>
    AM_DVDCOPYSTATE_INITIALIZE_TITLE = 1,
    /// <include file='AM_DVDCOPYSTATE.xml' path='doc/member[@name="AM_DVDCOPYSTATE.AM_DVDCOPYSTATE_AUTHENTICATION_NOT_REQUIRED"]/*'/>
    AM_DVDCOPYSTATE_AUTHENTICATION_NOT_REQUIRED = 2,
    /// <include file='AM_DVDCOPYSTATE.xml' path='doc/member[@name="AM_DVDCOPYSTATE.AM_DVDCOPYSTATE_AUTHENTICATION_REQUIRED"]/*'/>
    AM_DVDCOPYSTATE_AUTHENTICATION_REQUIRED = 3,
    /// <include file='AM_DVDCOPYSTATE.xml' path='doc/member[@name="AM_DVDCOPYSTATE.AM_DVDCOPYSTATE_DONE"]/*'/>
    AM_DVDCOPYSTATE_DONE = 4,
}