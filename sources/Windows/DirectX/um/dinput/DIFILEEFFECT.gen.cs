// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='DIFILEEFFECT.xml' path='doc/member[@name="DIFILEEFFECT"]/*'/>
public unsafe partial struct DIFILEEFFECT
{
    /// <include file='DIFILEEFFECT.xml' path='doc/member[@name="DIFILEEFFECT.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIFILEEFFECT.xml' path='doc/member[@name="DIFILEEFFECT.GuidEffect"]/*'/>
    public Guid GuidEffect;
    /// <include file='DIFILEEFFECT.xml' path='doc/member[@name="DIFILEEFFECT.lpDiEffect"]/*'/>
    [NativeTypeName("LPCDIEFFECT")]
    public DIEFFECT_DX6* lpDiEffect;
    /// <include file='DIFILEEFFECT.xml' path='doc/member[@name="DIFILEEFFECT.szFriendlyName"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte szFriendlyName[260];
}