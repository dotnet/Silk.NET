// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SOLE_AUTHENTICATION_LIST.xml' path='doc/member[@name="SOLE_AUTHENTICATION_LIST"]/*'/>
public unsafe partial struct SOLE_AUTHENTICATION_LIST
{
    /// <include file='SOLE_AUTHENTICATION_LIST.xml' path='doc/member[@name="SOLE_AUTHENTICATION_LIST.cAuthInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAuthInfo;
    /// <include file='SOLE_AUTHENTICATION_LIST.xml' path='doc/member[@name="SOLE_AUTHENTICATION_LIST.aAuthInfo"]/*'/>
    public SOLE_AUTHENTICATION_INFO* aAuthInfo;
}