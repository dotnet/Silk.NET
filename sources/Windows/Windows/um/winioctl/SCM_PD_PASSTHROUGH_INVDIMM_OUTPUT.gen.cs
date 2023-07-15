// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT"]/*'/>
public unsafe partial struct SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT
{
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.GeneralStatus"]/*'/>
    [NativeTypeName("WORD")]
    public ushort GeneralStatus;
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.ExtendedStatus"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ExtendedStatus;
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.OutputDataLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OutputDataLength;
    /// <include file='SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.xml' path='doc/member[@name="SCM_PD_PASSTHROUGH_INVDIMM_OUTPUT.OutputData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte OutputData[1];
}