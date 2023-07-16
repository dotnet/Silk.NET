// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='TPM_DEVICE_INFO.xml' path='doc/member[@name="TPM_DEVICE_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct TPM_DEVICE_INFO
{
    /// <include file='TPM_DEVICE_INFO.xml' path='doc/member[@name="TPM_DEVICE_INFO.structVersion"]/*'/>
    [NativeTypeName("UINT32")]
    public uint structVersion;
    /// <include file='TPM_DEVICE_INFO.xml' path='doc/member[@name="TPM_DEVICE_INFO.tpmVersion"]/*'/>
    [NativeTypeName("UINT32")]
    public uint tpmVersion;
    /// <include file='TPM_DEVICE_INFO.xml' path='doc/member[@name="TPM_DEVICE_INFO.tpmInterfaceType"]/*'/>
    [NativeTypeName("UINT32")]
    public uint tpmInterfaceType;
    /// <include file='TPM_DEVICE_INFO.xml' path='doc/member[@name="TPM_DEVICE_INFO.tpmImpRevision"]/*'/>
    [NativeTypeName("UINT32")]
    public uint tpmImpRevision;
}