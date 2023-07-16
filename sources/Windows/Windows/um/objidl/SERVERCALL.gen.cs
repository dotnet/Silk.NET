// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SERVERCALL.xml' path='doc/member[@name="SERVERCALL"]/*'/>
public enum SERVERCALL
{
    /// <include file='SERVERCALL.xml' path='doc/member[@name="SERVERCALL.SERVERCALL_ISHANDLED"]/*'/>
    SERVERCALL_ISHANDLED = 0,
    /// <include file='SERVERCALL.xml' path='doc/member[@name="SERVERCALL.SERVERCALL_REJECTED"]/*'/>
    SERVERCALL_REJECTED = 1,
    /// <include file='SERVERCALL.xml' path='doc/member[@name="SERVERCALL.SERVERCALL_RETRYLATER"]/*'/>
    SERVERCALL_RETRYLATER = 2,
}