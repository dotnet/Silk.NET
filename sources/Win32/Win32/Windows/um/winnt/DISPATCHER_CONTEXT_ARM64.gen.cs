// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct DISPATCHER_CONTEXT_ARM64
{
    [NativeTypeName("ULONG_PTR")]
    public nuint ControlPc;

    [NativeTypeName("ULONG_PTR")]
    public nuint ImageBase;

    [NativeTypeName("PARM64_RUNTIME_FUNCTION")]
    public IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY* FunctionEntry;

    [NativeTypeName("ULONG_PTR")]
    public nuint EstablisherFrame;

    [NativeTypeName("ULONG_PTR")]
    public nuint TargetPc;

    [NativeTypeName("PARM64_NT_CONTEXT")]
    public ARM64_NT_CONTEXT* ContextRecord;

    [NativeTypeName("PEXCEPTION_ROUTINE")]
    public delegate* unmanaged<EXCEPTION_RECORD*, void*, void*, void*, int> LanguageHandler;

    [NativeTypeName("PVOID")]
    public void* HandlerData;

    [NativeTypeName("struct _UNWIND_HISTORY_TABLE *")]
    public UNWIND_HISTORY_TABLE* HistoryTable;

    [NativeTypeName("DWORD")]
    public uint ScopeIndex;

    [NativeTypeName("BOOLEAN")]
    public byte ControlPcIsUnwound;

    [NativeTypeName("PBYTE")]
    public byte* NonVolatileRegisters;
}
