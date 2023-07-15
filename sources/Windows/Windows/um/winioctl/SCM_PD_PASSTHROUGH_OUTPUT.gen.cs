// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT"]/*'/>
public unsafe partial struct SCM_PD_PASSTHROUGH_OUTPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.ProtocolGuid"]/*'/>
    public Guid ProtocolGuid;
    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.DataSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSize;
    /// <include file='SCM_PD_PASSTHROUGH_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_OUTPUT.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}