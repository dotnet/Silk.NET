// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PSS_HANDLE_TRACE_INFORMATION.xml' path='doc/member[@name="PSS_HANDLE_TRACE_INFORMATION"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct PSS_HANDLE_TRACE_INFORMATION
{
    /// <include file='PSS_HANDLE_TRACE_INFORMATION.xml' path='doc/member[@name="PSS_HANDLE_TRACE_INFORMATION.SectionHandle"]/*'/>
    public HANDLE SectionHandle;
    /// <include file='PSS_HANDLE_TRACE_INFORMATION.xml' path='doc/member[@name="PSS_HANDLE_TRACE_INFORMATION.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
}