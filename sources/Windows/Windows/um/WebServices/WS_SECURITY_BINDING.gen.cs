// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_SECURITY_BINDING.xml' path='doc/member[@name="WS_SECURITY_BINDING"]/*'/>
public unsafe partial struct WS_SECURITY_BINDING
{
    /// <include file='WS_SECURITY_BINDING.xml' path='doc/member[@name="WS_SECURITY_BINDING.bindingType"]/*'/>
    public WS_SECURITY_BINDING_TYPE bindingType;
    /// <include file='WS_SECURITY_BINDING.xml' path='doc/member[@name="WS_SECURITY_BINDING.properties"]/*'/>
    public WS_SECURITY_BINDING_PROPERTY* properties;
    /// <include file='WS_SECURITY_BINDING.xml' path='doc/member[@name="WS_SECURITY_BINDING.propertyCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint propertyCount;
}