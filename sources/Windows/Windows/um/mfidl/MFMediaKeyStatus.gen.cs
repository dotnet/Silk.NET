// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MFMediaKeyStatus.xml' path='doc/member[@name="MFMediaKeyStatus"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct MFMediaKeyStatus
{
    /// <include file='MFMediaKeyStatus.xml' path='doc/member[@name="MFMediaKeyStatus.pbKeyId"]/*'/>
    public byte* pbKeyId;
    /// <include file='MFMediaKeyStatus.xml' path='doc/member[@name="MFMediaKeyStatus.cbKeyId"]/*'/>
    public uint cbKeyId;
    /// <include file='MFMediaKeyStatus.xml' path='doc/member[@name="MFMediaKeyStatus.eMediaKeyStatus"]/*'/>
    public MF_MEDIAKEY_STATUS eMediaKeyStatus;
}