// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE"]/*'/>
public partial struct TF_INPUTPROCESSORPROFILE
{
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.dwProfileType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProfileType;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.langid"]/*'/>
    [NativeTypeName("LANGID")]
    public ushort langid;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.guidProfile"]/*'/>
    public Guid guidProfile;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.catid"]/*'/>
    public Guid catid;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.hklSubstitute"]/*'/>
    public HKL hklSubstitute;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.dwCaps"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.hkl"]/*'/>
    public HKL hkl;
    /// <include file='TF_INPUTPROCESSORPROFILE.xml' path='doc/member[@name="TF_INPUTPROCESSORPROFILE.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}