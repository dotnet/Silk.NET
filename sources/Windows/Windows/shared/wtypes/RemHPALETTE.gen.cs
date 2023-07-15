// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RemHPALETTE.xml' path='doc/member[@name="RemHPALETTE"]/*'/>
public unsafe partial struct RemHPALETTE
{
    /// <include file='RemHPALETTE.xml' path='doc/member[@name="RemHPALETTE.cbData"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbData;
    /// <include file='RemHPALETTE.xml' path='doc/member[@name="RemHPALETTE.data"]/*'/>
    [NativeTypeName("byte[1]")]
    public fixed byte data[1];
}