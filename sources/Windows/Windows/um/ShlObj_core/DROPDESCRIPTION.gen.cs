// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DROPDESCRIPTION
{
    /// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION.type"]/*'/>
    public DROPIMAGETYPE type;
    /// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION.szMessage"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szMessage[260];
    /// <include file='DROPDESCRIPTION.xml' path='doc/member[@name="DROPDESCRIPTION.szInsert"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szInsert[260];
}