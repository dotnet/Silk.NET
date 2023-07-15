// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64"]/*'/>
public unsafe partial struct STACKFRAME64
{
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.AddrPC"]/*'/>
    public ADDRESS64 AddrPC;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.AddrReturn"]/*'/>
    public ADDRESS64 AddrReturn;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.AddrFrame"]/*'/>
    public ADDRESS64 AddrFrame;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.AddrStack"]/*'/>
    public ADDRESS64 AddrStack;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.AddrBStore"]/*'/>
    public ADDRESS64 AddrBStore;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.FuncTableEntry"]/*'/>
    [NativeTypeName("PVOID")]
    public void* FuncTableEntry;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.Params"]/*'/>
    [NativeTypeName("DWORD64[4]")]
    public fixed ulong Params[4];
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.Far"]/*'/>
    public BOOL Far;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.Virtual"]/*'/>
    public BOOL Virtual;
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.Reserved"]/*'/>
    [NativeTypeName("DWORD64[3]")]
    public fixed ulong Reserved[3];
    /// <include file='STACKFRAME64.xml' path='doc/member[@name="STACKFRAME64.KdHelp"]/*'/>
    public KDHELP64 KdHelp;
}