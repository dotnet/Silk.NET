// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM"]/*'/>
public unsafe partial struct SYNCMGRPROGRESSITEM
{
    /// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM.mask"]/*'/>
    public uint mask;
    /// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM.lpcStatusText"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpcStatusText;
    /// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM.dwStatusType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatusType;
    /// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM.iProgValue"]/*'/>
    public int iProgValue;
    /// <include file='SYNCMGRPROGRESSITEM.xml' path='doc/member[@name="SYNCMGRPROGRESSITEM.iMaxValue"]/*'/>
    public int iMaxValue;
}