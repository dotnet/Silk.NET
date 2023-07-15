// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TOKEN_PRIMARY_GROUP.xml' path='doc/member[@name="TOKEN_PRIMARY_GROUP"]/*'/>
public unsafe partial struct TOKEN_PRIMARY_GROUP
{
    /// <include file='TOKEN_PRIMARY_GROUP.xml' path='doc/member[@name="TOKEN_PRIMARY_GROUP.PrimaryGroup"]/*'/>
    [NativeTypeName("PSID")]
    public void* PrimaryGroup;
}