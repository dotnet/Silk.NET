// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DIOBJECTDATAFORMAT.xml' path='doc/member[@name="DIOBJECTDATAFORMAT"]/*'/>
public unsafe partial struct DIOBJECTDATAFORMAT
{
    /// <include file='DIOBJECTDATAFORMAT.xml' path='doc/member[@name="DIOBJECTDATAFORMAT.pguid"]/*'/>
    [NativeTypeName("const GUID *")]
    public Guid* pguid;
    /// <include file='DIOBJECTDATAFORMAT.xml' path='doc/member[@name="DIOBJECTDATAFORMAT.dwOfs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOfs;
    /// <include file='DIOBJECTDATAFORMAT.xml' path='doc/member[@name="DIOBJECTDATAFORMAT.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='DIOBJECTDATAFORMAT.xml' path='doc/member[@name="DIOBJECTDATAFORMAT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}