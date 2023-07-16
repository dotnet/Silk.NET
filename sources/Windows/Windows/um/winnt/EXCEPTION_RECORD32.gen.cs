// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32"]/*'/>
public unsafe partial struct EXCEPTION_RECORD32
{
    /// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32.ExceptionCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;
    /// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32.ExceptionFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionFlags;
    /// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32.ExceptionRecord"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionRecord;
    /// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32.ExceptionAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionAddress;
    /// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32.NumberParameters"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberParameters;
    /// <include file='EXCEPTION_RECORD32.xml' path='doc/member[@name="EXCEPTION_RECORD32.ExceptionInformation"]/*'/>
    [NativeTypeName("DWORD[15]")]
    public fixed uint ExceptionInformation[15];
}