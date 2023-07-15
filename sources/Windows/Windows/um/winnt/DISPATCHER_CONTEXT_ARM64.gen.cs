// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64"]/*'/>
public unsafe partial struct DISPATCHER_CONTEXT_ARM64
{
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.ControlPc"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint ControlPc;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.ImageBase"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint ImageBase;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.FunctionEntry"]/*'/>
    [NativeTypeName("PARM64_RUNTIME_FUNCTION")]
    public IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionEntry;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.EstablisherFrame"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint EstablisherFrame;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.TargetPc"]/*'/>
    [NativeTypeName("ULONG_PTR")]
    public nuint TargetPc;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.ContextRecord"]/*'/>
    [NativeTypeName("PARM64_NT_CONTEXT")]
    public ARM64_NT_CONTEXT* ContextRecord;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.LanguageHandler"]/*'/>
    [NativeTypeName("PEXCEPTION_ROUTINE")]
    public delegate* unmanaged<EXCEPTION_RECORD*, void*, void*, void*, int> LanguageHandler;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.HandlerData"]/*'/>
    [NativeTypeName("PVOID")]
    public void* HandlerData;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.HistoryTable"]/*'/>
    [NativeTypeName("struct _UNWIND_HISTORY_TABLE *")]
    public UNWIND_HISTORY_TABLE* HistoryTable;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.ScopeIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ScopeIndex;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.ControlPcIsUnwound"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ControlPcIsUnwound;
    /// <include file='DISPATCHER_CONTEXT_ARM64.xml' path='doc/member[@name="DISPATCHER_CONTEXT_ARM64.NonVolatileRegisters"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* NonVolatileRegisters;
}