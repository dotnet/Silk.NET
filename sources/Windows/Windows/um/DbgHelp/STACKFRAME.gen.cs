// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME"]/*'/>
public unsafe partial struct STACKFRAME
{
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrPC"]/*'/>
    public ADDRESS AddrPC;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrReturn"]/*'/>
    public ADDRESS AddrReturn;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrFrame"]/*'/>
    public ADDRESS AddrFrame;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrStack"]/*'/>
    public ADDRESS AddrStack;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.FuncTableEntry"]/*'/>
    [NativeTypeName("PVOID")]
    public void* FuncTableEntry;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Params"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint Params[4];
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Far"]/*'/>
    public BOOL Far;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Virtual"]/*'/>
    public BOOL Virtual;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.Reserved"]/*'/>
    [NativeTypeName("DWORD[3]")]
    public fixed uint Reserved[3];
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.KdHelp"]/*'/>
    public KDHELP KdHelp;
    /// <include file='STACKFRAME.xml' path='doc/member[@name="STACKFRAME.AddrBStore"]/*'/>
    public ADDRESS AddrBStore;
}