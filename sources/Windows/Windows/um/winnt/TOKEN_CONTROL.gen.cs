// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOKEN_CONTROL.xml' path='doc/member[@name="TOKEN_CONTROL"]/*'/>
public partial struct TOKEN_CONTROL
{
    /// <include file='TOKEN_CONTROL.xml' path='doc/member[@name="TOKEN_CONTROL.TokenId"]/*'/>
    public LUID TokenId;
    /// <include file='TOKEN_CONTROL.xml' path='doc/member[@name="TOKEN_CONTROL.AuthenticationId"]/*'/>
    public LUID AuthenticationId;
    /// <include file='TOKEN_CONTROL.xml' path='doc/member[@name="TOKEN_CONTROL.ModifiedId"]/*'/>
    public LUID ModifiedId;
    /// <include file='TOKEN_CONTROL.xml' path='doc/member[@name="TOKEN_CONTROL.TokenSource"]/*'/>
    public TOKEN_SOURCE TokenSource;
}