// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPCOMMITFLAGS.xml' path='doc/member[@name="SPCOMMITFLAGS"]/*'/>
public enum SPCOMMITFLAGS
{
    /// <include file='SPCOMMITFLAGS.xml' path='doc/member[@name="SPCOMMITFLAGS.SPCF_NONE"]/*'/>
    SPCF_NONE = 0,
    /// <include file='SPCOMMITFLAGS.xml' path='doc/member[@name="SPCOMMITFLAGS.SPCF_ADD_TO_USER_LEXICON"]/*'/>
    SPCF_ADD_TO_USER_LEXICON = (1 << 0),
    /// <include file='SPCOMMITFLAGS.xml' path='doc/member[@name="SPCOMMITFLAGS.SPCF_DEFINITE_CORRECTION"]/*'/>
    SPCF_DEFINITE_CORRECTION = (1 << 1),
}