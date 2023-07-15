// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPAUDIOSTATE.xml' path='doc/member[@name="SPAUDIOSTATE"]/*'/>
public enum SPAUDIOSTATE
{
    /// <include file='SPAUDIOSTATE.xml' path='doc/member[@name="SPAUDIOSTATE.SPAS_CLOSED"]/*'/>
    SPAS_CLOSED = 0,
    /// <include file='SPAUDIOSTATE.xml' path='doc/member[@name="SPAUDIOSTATE.SPAS_STOP"]/*'/>
    SPAS_STOP = (SPAS_CLOSED + 1),
    /// <include file='SPAUDIOSTATE.xml' path='doc/member[@name="SPAUDIOSTATE.SPAS_PAUSE"]/*'/>
    SPAS_PAUSE = (SPAS_STOP + 1),
    /// <include file='SPAUDIOSTATE.xml' path='doc/member[@name="SPAUDIOSTATE.SPAS_RUN"]/*'/>
    SPAS_RUN = (SPAS_PAUSE + 1),
}