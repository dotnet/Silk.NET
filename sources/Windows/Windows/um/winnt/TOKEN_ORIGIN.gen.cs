// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOKEN_ORIGIN.xml' path='doc/member[@name="TOKEN_ORIGIN"]/*'/>
public partial struct TOKEN_ORIGIN
{
    /// <include file='TOKEN_ORIGIN.xml' path='doc/member[@name="TOKEN_ORIGIN.OriginatingLogonSession"]/*'/>
    public LUID OriginatingLogonSession;
}