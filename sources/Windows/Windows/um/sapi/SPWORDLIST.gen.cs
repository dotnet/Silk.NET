// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPWORDLIST.xml' path='doc/member[@name="SPWORDLIST"]/*'/>
public unsafe partial struct SPWORDLIST
{
    /// <include file='SPWORDLIST.xml' path='doc/member[@name="SPWORDLIST.ulSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSize;
    /// <include file='SPWORDLIST.xml' path='doc/member[@name="SPWORDLIST.pvBuffer"]/*'/>
    public byte* pvBuffer;
    /// <include file='SPWORDLIST.xml' path='doc/member[@name="SPWORDLIST.pFirstWord"]/*'/>
    public SPWORD* pFirstWord;
}