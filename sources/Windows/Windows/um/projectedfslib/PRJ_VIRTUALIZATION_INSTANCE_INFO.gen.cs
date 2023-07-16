// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_VIRTUALIZATION_INSTANCE_INFO.xml' path='doc/member[@name="PRJ_VIRTUALIZATION_INSTANCE_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_VIRTUALIZATION_INSTANCE_INFO
{
    /// <include file='PRJ_VIRTUALIZATION_INSTANCE_INFO.xml' path='doc/member[@name="PRJ_VIRTUALIZATION_INSTANCE_INFO.InstanceID"]/*'/>
    public Guid InstanceID;
    /// <include file='PRJ_VIRTUALIZATION_INSTANCE_INFO.xml' path='doc/member[@name="PRJ_VIRTUALIZATION_INSTANCE_INFO.WriteAlignment"]/*'/>
    [NativeTypeName("UINT32")]
    public uint WriteAlignment;
}