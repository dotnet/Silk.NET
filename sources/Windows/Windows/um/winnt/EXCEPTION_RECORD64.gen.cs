// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64"]/*'/>
public unsafe partial struct EXCEPTION_RECORD64
{
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.ExceptionCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.ExceptionFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionFlags;
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.ExceptionRecord"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong ExceptionRecord;
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.ExceptionAddress"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong ExceptionAddress;
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.NumberParameters"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberParameters;
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.__unusedAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint __unusedAlignment;
    /// <include file='EXCEPTION_RECORD64.xml' path='doc/member[@name="EXCEPTION_RECORD64.ExceptionInformation"]/*'/>
    [NativeTypeName("DWORD64[15]")]
    public fixed ulong ExceptionInformation[15];
}