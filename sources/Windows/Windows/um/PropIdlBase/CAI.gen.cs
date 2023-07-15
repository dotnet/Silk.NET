// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CAI.xml' path='doc/member[@name="CAI"]/*'/>
public unsafe partial struct CAI
{
    /// <include file='CAI.xml' path='doc/member[@name="CAI.cElems"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElems;
    /// <include file='CAI.xml' path='doc/member[@name="CAI.pElems"]/*'/>
    public short* pElems;
}