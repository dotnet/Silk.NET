// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXCEPTION_DEBUG_INFO.xml' path='doc/member[@name="EXCEPTION_DEBUG_INFO"]/*'/>
public partial struct EXCEPTION_DEBUG_INFO
{
    /// <include file='EXCEPTION_DEBUG_INFO.xml' path='doc/member[@name="EXCEPTION_DEBUG_INFO.ExceptionRecord"]/*'/>
    public EXCEPTION_RECORD ExceptionRecord;
    /// <include file='EXCEPTION_DEBUG_INFO.xml' path='doc/member[@name="EXCEPTION_DEBUG_INFO.dwFirstChance"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFirstChance;
}