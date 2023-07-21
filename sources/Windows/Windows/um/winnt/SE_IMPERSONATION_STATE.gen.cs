// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SE_IMPERSONATION_STATE.xml' path='doc/member[@name="SE_IMPERSONATION_STATE"]/*' />
public unsafe partial struct SE_IMPERSONATION_STATE
{
    /// <include file='SE_IMPERSONATION_STATE.xml' path='doc/member[@name="SE_IMPERSONATION_STATE.Token"]/*' />
    [NativeTypeName("PACCESS_TOKEN")]
    public void* Token;

    /// <include file='SE_IMPERSONATION_STATE.xml' path='doc/member[@name="SE_IMPERSONATION_STATE.CopyOnOpen"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte CopyOnOpen;

    /// <include file='SE_IMPERSONATION_STATE.xml' path='doc/member[@name="SE_IMPERSONATION_STATE.EffectiveOnly"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte EffectiveOnly;

    /// <include file='SE_IMPERSONATION_STATE.xml' path='doc/member[@name="SE_IMPERSONATION_STATE.Level"]/*' />
    public SECURITY_IMPERSONATION_LEVEL Level;
}
