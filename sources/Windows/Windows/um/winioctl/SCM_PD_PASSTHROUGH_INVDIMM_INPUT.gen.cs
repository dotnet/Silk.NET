// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT"]/*'/>
public unsafe partial struct SCM_PD_PASSTHROUGH_INVDIMM_INPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT.Opcode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Opcode;
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT.OpcodeParametersLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OpcodeParametersLength;
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_INPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_INPUT.OpcodeParameters"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte OpcodeParameters[1];
}