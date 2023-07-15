// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT"]/*'/>
public unsafe partial struct WOW64_CONTEXT
{
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.ContextFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ContextFlags;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Dr0"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dr0;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Dr1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dr1;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Dr2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dr2;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Dr3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dr3;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Dr6"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dr6;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Dr7"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dr7;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.FloatSave"]/*'/>
    public WOW64_FLOATING_SAVE_AREA FloatSave;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.SegGs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SegGs;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.SegFs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SegFs;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.SegEs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SegEs;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.SegDs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SegDs;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Edi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Edi;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Esi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Esi;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Ebx"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Ebx;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Edx"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Edx;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Ecx"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Ecx;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Eax"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Eax;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Ebp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Ebp;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Eip"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Eip;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.SegCs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SegCs;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.EFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EFlags;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.Esp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Esp;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.SegSs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SegSs;
    /// <include file='WOW64_CONTEXT.xml' path='doc/member[@name="WOW64_CONTEXT.ExtendedRegisters"]/*'/>
    [NativeTypeName("BYTE[512]")]
    public fixed byte ExtendedRegisters[512];
}