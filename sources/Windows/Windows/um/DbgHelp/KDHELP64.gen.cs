// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64"]/*'/>
public unsafe partial struct KDHELP64
{
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.Thread"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Thread;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.ThCallbackStack"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ThCallbackStack;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.ThCallbackBStore"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ThCallbackBStore;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.NextCallback"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NextCallback;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.FramePointer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FramePointer;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.KiCallUserMode"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong KiCallUserMode;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.KeUserCallbackDispatcher"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong KeUserCallbackDispatcher;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.SystemRangeStart"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong SystemRangeStart;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.KiUserExceptionDispatcher"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong KiUserExceptionDispatcher;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.StackBase"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong StackBase;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.StackLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong StackLimit;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.BuildVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BuildVersion;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.RetpolineStubFunctionTableSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RetpolineStubFunctionTableSize;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.RetpolineStubFunctionTable"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong RetpolineStubFunctionTable;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.RetpolineStubOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RetpolineStubOffset;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.RetpolineStubSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RetpolineStubSize;
    /// <include file='KDHELP64.xml' path='doc/member[@name="KDHELP64.Reserved0"]/*'/>
    [NativeTypeName("DWORD64[2]")]
    public fixed ulong Reserved0[2];
}