// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LOCKTYPE.xml' path='doc/member[@name="LOCKTYPE"]/*'/>
public enum LOCKTYPE
{
    /// <include file='LOCKTYPE.xml' path='doc/member[@name="LOCKTYPE.LOCK_WRITE"]/*'/>
    LOCK_WRITE = 1,
    /// <include file='LOCKTYPE.xml' path='doc/member[@name="LOCKTYPE.LOCK_EXCLUSIVE"]/*'/>
    LOCK_EXCLUSIVE = 2,
    /// <include file='LOCKTYPE.xml' path='doc/member[@name="LOCKTYPE.LOCK_ONLYONCE"]/*'/>
    LOCK_ONLYONCE = 4,
}