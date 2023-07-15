// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.xml' path='doc/member[@name="WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT"]/*'/>
public unsafe partial struct WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT
{
    /// <include file='WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.xml' path='doc/member[@name="WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.hClientToken"]/*'/>
    public HANDLE hClientToken;
    /// <include file='WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.xml' path='doc/member[@name="WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.SubjectType"]/*'/>
    public Guid* SubjectType;
    /// <include file='WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.xml' path='doc/member[@name="WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT.Subject"]/*'/>
    [NativeTypeName("WIN_TRUST_SUBJECT")]
    public void* Subject;
}