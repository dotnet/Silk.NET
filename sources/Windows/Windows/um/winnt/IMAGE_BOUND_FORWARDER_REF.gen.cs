// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_BOUND_FORWARDER_REF.xml' path='doc/member[@name="IMAGE_BOUND_FORWARDER_REF"]/*'/>
public partial struct IMAGE_BOUND_FORWARDER_REF
{
    /// <include file='IMAGE_BOUND_FORWARDER_REF.xml' path='doc/member[@name="IMAGE_BOUND_FORWARDER_REF.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGE_BOUND_FORWARDER_REF.xml' path='doc/member[@name="IMAGE_BOUND_FORWARDER_REF.OffsetModuleName"]/*'/>
    [NativeTypeName("WORD")]
    public ushort OffsetModuleName;
    /// <include file='IMAGE_BOUND_FORWARDER_REF.xml' path='doc/member[@name="IMAGE_BOUND_FORWARDER_REF.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
}