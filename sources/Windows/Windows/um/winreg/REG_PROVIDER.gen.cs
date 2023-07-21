// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER"]/*' />
public unsafe partial struct REG_PROVIDER
{
    /// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER.pi_R0_1val"]/*' />
    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R0_1val;

    /// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER.pi_R0_allvals"]/*' />
    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R0_allvals;

    /// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER.pi_R3_1val"]/*' />
    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R3_1val;

    /// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER.pi_R3_allvals"]/*' />
    [NativeTypeName("PQUERYHANDLER")]
    public delegate* unmanaged<void*, val_context*, uint, void*, uint*, uint, uint> pi_R3_allvals;

    /// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER.pi_flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint pi_flags;

    /// <include file='REG_PROVIDER.xml' path='doc/member[@name="REG_PROVIDER.pi_key_context"]/*' />
    [NativeTypeName("LPVOID")]
    public void* pi_key_context;
}
