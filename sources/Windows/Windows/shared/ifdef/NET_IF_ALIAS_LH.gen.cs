// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NET_IF_ALIAS_LH.xml' path='doc/member[@name="NET_IF_ALIAS_LH"]/*'/>
public partial struct NET_IF_ALIAS_LH
{
    /// <include file='NET_IF_ALIAS_LH.xml' path='doc/member[@name="NET_IF_ALIAS_LH.ifAliasLength"]/*'/>
    public ushort ifAliasLength;
    /// <include file='NET_IF_ALIAS_LH.xml' path='doc/member[@name="NET_IF_ALIAS_LH.ifAliasOffset"]/*'/>
    public ushort ifAliasOffset;
}