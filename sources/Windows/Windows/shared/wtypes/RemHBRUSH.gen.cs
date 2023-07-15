// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RemHBRUSH.xml' path='doc/member[@name="RemHBRUSH"]/*'/>
public unsafe partial struct RemHBRUSH
{
    /// <include file='RemHBRUSH.xml' path='doc/member[@name="RemHBRUSH.cbData"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbData;
    /// <include file='RemHBRUSH.xml' path='doc/member[@name="RemHBRUSH.data"]/*'/>
    [NativeTypeName("byte[1]")]
    public fixed byte data[1];
}