// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SAMPR_ENCRYPTED_USER_PASSWORD.xml' path='doc/member[@name="SAMPR_ENCRYPTED_USER_PASSWORD"]/*'/>
public unsafe partial struct SAMPR_ENCRYPTED_USER_PASSWORD
{
    /// <include file='SAMPR_ENCRYPTED_USER_PASSWORD.xml' path='doc/member[@name="SAMPR_ENCRYPTED_USER_PASSWORD.Buffer"]/*'/>
    [NativeTypeName("UCHAR[516]")]
    public fixed byte Buffer[516];
}