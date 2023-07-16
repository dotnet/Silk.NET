// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA
{
    /// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.TaskIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TaskIndex;
    /// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.ClassName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort ClassName[260];
    /// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.BasePriority"]/*'/>
    [NativeTypeName("LONG")]
    public int BasePriority;
}