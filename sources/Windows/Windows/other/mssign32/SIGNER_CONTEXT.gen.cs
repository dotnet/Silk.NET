// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
namespace Silk.NET.Windows;

/// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT"]/*'/>
public unsafe partial struct SIGNER_CONTEXT
{
    /// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT.cbBlob"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbBlob;

    /// <include file='SIGNER_CONTEXT.xml' path='doc/member[@name="SIGNER_CONTEXT.pbBlob"]/*'/>

    public byte* pbBlob;
}
