// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='STORAGE_OFFLOAD_WRITE_OUTPUT.xml' path='doc/member[@name="STORAGE_OFFLOAD_WRITE_OUTPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct STORAGE_OFFLOAD_WRITE_OUTPUT
{
    /// <include file='STORAGE_OFFLOAD_WRITE_OUTPUT.xml' path='doc/member[@name="STORAGE_OFFLOAD_WRITE_OUTPUT.OffloadWriteFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OffloadWriteFlags;
    /// <include file='STORAGE_OFFLOAD_WRITE_OUTPUT.xml' path='doc/member[@name="STORAGE_OFFLOAD_WRITE_OUTPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='STORAGE_OFFLOAD_WRITE_OUTPUT.xml' path='doc/member[@name="STORAGE_OFFLOAD_WRITE_OUTPUT.LengthCopied"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LengthCopied;
}