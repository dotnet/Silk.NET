// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='SCM_PD_PASSTHROUGH_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INPUT"]/*'/>
public unsafe partial struct SCM_PD_PASSTHROUGH_INPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_PASSTHROUGH_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_PASSTHROUGH_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INPUT.ProtocolGuid"]/*'/>
    public Guid ProtocolGuid;
    /// <include file='SCM_PD_PASSTHROUGH_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INPUT.DataSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSize;
    /// <include file='SCM_PD_PASSTHROUGH_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INPUT.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}