// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KDHELP.xml' path='doc/member[@name="KDHELP"]/*'/>
public unsafe partial struct KDHELP
{
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.Thread"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Thread;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.ThCallbackStack"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ThCallbackStack;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.NextCallback"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NextCallback;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.FramePointer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FramePointer;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.KiCallUserMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint KiCallUserMode;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.KeUserCallbackDispatcher"]/*'/>
    [NativeTypeName("DWORD")]
    public uint KeUserCallbackDispatcher;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.SystemRangeStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SystemRangeStart;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.ThCallbackBStore"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ThCallbackBStore;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.KiUserExceptionDispatcher"]/*'/>
    [NativeTypeName("DWORD")]
    public uint KiUserExceptionDispatcher;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.StackBase"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StackBase;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.StackLimit"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StackLimit;
    /// <include file='KDHELP.xml' path='doc/member[@name="KDHELP.Reserved"]/*'/>
    [NativeTypeName("DWORD[5]")]
    public fixed uint Reserved[5];
}