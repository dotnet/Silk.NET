// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOKEN_DEFAULT_DACL.xml' path='doc/member[@name="TOKEN_DEFAULT_DACL"]/*'/>
public unsafe partial struct TOKEN_DEFAULT_DACL
{
    /// <include file='TOKEN_DEFAULT_DACL.xml' path='doc/member[@name="TOKEN_DEFAULT_DACL.DefaultDacl"]/*'/>
    [NativeTypeName("PACL")]
    public ACL* DefaultDacl;
}