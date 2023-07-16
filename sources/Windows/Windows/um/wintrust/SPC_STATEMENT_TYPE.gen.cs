// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPC_STATEMENT_TYPE.xml' path='doc/member[@name="SPC_STATEMENT_TYPE"]/*'/>
public unsafe partial struct SPC_STATEMENT_TYPE
{
    /// <include file='SPC_STATEMENT_TYPE.xml' path='doc/member[@name="SPC_STATEMENT_TYPE.cKeyPurposeId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cKeyPurposeId;
    /// <include file='SPC_STATEMENT_TYPE.xml' path='doc/member[@name="SPC_STATEMENT_TYPE.rgpszKeyPurposeId"]/*'/>
    [NativeTypeName("LPSTR *")]
    public sbyte** rgpszKeyPurposeId;
}