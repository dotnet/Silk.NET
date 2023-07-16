// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_BOUND_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_BOUND_IMPORT_DESCRIPTOR"]/*'/>
public partial struct IMAGE_BOUND_IMPORT_DESCRIPTOR
{
    /// <include file='IMAGE_BOUND_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_BOUND_IMPORT_DESCRIPTOR.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGE_BOUND_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_BOUND_IMPORT_DESCRIPTOR.OffsetModuleName"]/*'/>
    [NativeTypeName("WORD")]
    public ushort OffsetModuleName;
    /// <include file='IMAGE_BOUND_IMPORT_DESCRIPTOR.xml' path='doc/member[@name="IMAGE_BOUND_IMPORT_DESCRIPTOR.NumberOfModuleForwarderRefs"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NumberOfModuleForwarderRefs;
}