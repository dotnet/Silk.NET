// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION"]/*'/>
public partial struct DEVICE_DSM_DEFINITION
{
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.Action"]/*'/>
    [NativeTypeName("DEVICE_DSM_ACTION")]
    public uint Action;
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.SingleRange"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SingleRange;
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.ParameterBlockAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ParameterBlockAlignment;
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.ParameterBlockLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ParameterBlockLength;
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.HasOutput"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte HasOutput;
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.OutputBlockAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OutputBlockAlignment;
    /// <include file='DEVICE_DSM_DEFINITION.xml' path='doc/member[@name="DEVICE_DSM_DEFINITION.OutputBlockLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OutputBlockLength;
}