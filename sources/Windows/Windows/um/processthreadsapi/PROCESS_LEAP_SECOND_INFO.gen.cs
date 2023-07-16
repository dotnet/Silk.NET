// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PROCESS_LEAP_SECOND_INFO.xml' path='doc/member[@name="PROCESS_LEAP_SECOND_INFO"]/*'/>
public partial struct PROCESS_LEAP_SECOND_INFO
{
    /// <include file='PROCESS_LEAP_SECOND_INFO.xml' path='doc/member[@name="PROCESS_LEAP_SECOND_INFO.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='PROCESS_LEAP_SECOND_INFO.xml' path='doc/member[@name="PROCESS_LEAP_SECOND_INFO.Reserved"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved;
}