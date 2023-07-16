// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BNSTATE.xml' path='doc/member[@name="BNSTATE"]/*'/>
public enum BNSTATE
{
    /// <include file='BNSTATE.xml' path='doc/member[@name="BNSTATE.BNS_NORMAL"]/*'/>
    BNS_NORMAL = 0,
    /// <include file='BNSTATE.xml' path='doc/member[@name="BNSTATE.BNS_BEGIN_NAVIGATE"]/*'/>
    BNS_BEGIN_NAVIGATE = 1,
    /// <include file='BNSTATE.xml' path='doc/member[@name="BNSTATE.BNS_NAVIGATE"]/*'/>
    BNS_NAVIGATE = 2,
}