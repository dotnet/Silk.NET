// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPRUNSTATE.xml' path='doc/member[@name="SPRUNSTATE"]/*'/>
public enum SPRUNSTATE
{
    /// <include file='SPRUNSTATE.xml' path='doc/member[@name="SPRUNSTATE.SPRS_DONE"]/*'/>
    SPRS_DONE = (1 << 0),
    /// <include file='SPRUNSTATE.xml' path='doc/member[@name="SPRUNSTATE.SPRS_IS_SPEAKING"]/*'/>
    SPRS_IS_SPEAKING = (1 << 1),
}