// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED"]/*'/>
public unsafe partial struct SCH_CRED
{
    /// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED.cCreds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCreds;
    /// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED.paSecret"]/*'/>
    [NativeTypeName("PVOID *")]
    public void** paSecret;
    /// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED.paPublic"]/*'/>
    [NativeTypeName("PVOID *")]
    public void** paPublic;
    /// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED.cMappers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cMappers;
    /// <include file='SCH_CRED.xml' path='doc/member[@name="SCH_CRED.aphMappers"]/*'/>
    [NativeTypeName("struct _HMAPPER **")]
    public IntPtr* aphMappers;
}