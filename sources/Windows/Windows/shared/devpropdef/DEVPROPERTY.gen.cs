// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVPROPERTY.xml' path='doc/member[@name="DEVPROPERTY"]/*'/>
public unsafe partial struct DEVPROPERTY
{
    /// <include file='DEVPROPERTY.xml' path='doc/member[@name="DEVPROPERTY.CompKey"]/*'/>
    public DEVPROPCOMPKEY CompKey;
    /// <include file='DEVPROPERTY.xml' path='doc/member[@name="DEVPROPERTY.Type"]/*'/>
    [NativeTypeName("DEVPROPTYPE")]
    public uint Type;
    /// <include file='DEVPROPERTY.xml' path='doc/member[@name="DEVPROPERTY.BufferSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BufferSize;
    /// <include file='DEVPROPERTY.xml' path='doc/member[@name="DEVPROPERTY.Buffer"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Buffer;
}