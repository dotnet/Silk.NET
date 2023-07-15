// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TF_PRESERVEDKEY.xml' path='doc/member[@name="TF_PRESERVEDKEY"]/*'/>
public partial struct TF_PRESERVEDKEY
{
    /// <include file='TF_PRESERVEDKEY.xml' path='doc/member[@name="TF_PRESERVEDKEY.uVKey"]/*'/>
    public uint uVKey;
    /// <include file='TF_PRESERVEDKEY.xml' path='doc/member[@name="TF_PRESERVEDKEY.uModifiers"]/*'/>
    public uint uModifiers;
}