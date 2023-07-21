// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public unsafe partial struct IMAGE_DOS_HEADER
{
    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_magic"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_magic;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cblp"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_cblp;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cp"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_cp;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_crlc"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_crlc;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cparhdr"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_cparhdr;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_minalloc"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_minalloc;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_maxalloc"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_maxalloc;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_ss"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_ss;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_sp"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_sp;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_csum"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_csum;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_ip"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_ip;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_cs"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_cs;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_lfarlc"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_lfarlc;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_ovno"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_ovno;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_res"]/*' />
    [NativeTypeName("WORD[4]")]
    public fixed ushort e_res[4];

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_oemid"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_oemid;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_oeminfo"]/*' />
    [NativeTypeName("WORD")]
    public ushort e_oeminfo;

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_res2"]/*' />
    [NativeTypeName("WORD[10]")]
    public fixed ushort e_res2[10];

    /// <include file='IMAGE_DOS_HEADER.xml' path='doc/member[@name="IMAGE_DOS_HEADER.e_lfanew"]/*' />
    [NativeTypeName("LONG")]
    public int e_lfanew;
}
