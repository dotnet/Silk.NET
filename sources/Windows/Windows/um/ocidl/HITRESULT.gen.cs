// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HITRESULT.xml' path='doc/member[@name="HITRESULT"]/*'/>
public enum HITRESULT
{
    /// <include file='HITRESULT.xml' path='doc/member[@name="HITRESULT.HITRESULT_OUTSIDE"]/*'/>
    HITRESULT_OUTSIDE = 0,
    /// <include file='HITRESULT.xml' path='doc/member[@name="HITRESULT.HITRESULT_TRANSPARENT"]/*'/>
    HITRESULT_TRANSPARENT = 1,
    /// <include file='HITRESULT.xml' path='doc/member[@name="HITRESULT.HITRESULT_CLOSE"]/*'/>
    HITRESULT_CLOSE = 2,
    /// <include file='HITRESULT.xml' path='doc/member[@name="HITRESULT.HITRESULT_HIT"]/*'/>
    HITRESULT_HIT = 3,
}