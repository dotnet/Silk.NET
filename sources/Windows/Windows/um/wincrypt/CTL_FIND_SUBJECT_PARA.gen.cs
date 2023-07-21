// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CTL_FIND_SUBJECT_PARA.xml' path='doc/member[@name="CTL_FIND_SUBJECT_PARA"]/*' />
public unsafe partial struct CTL_FIND_SUBJECT_PARA
{
    /// <include file='CTL_FIND_SUBJECT_PARA.xml' path='doc/member[@name="CTL_FIND_SUBJECT_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CTL_FIND_SUBJECT_PARA.xml' path='doc/member[@name="CTL_FIND_SUBJECT_PARA.pUsagePara"]/*' />
    [NativeTypeName("PCTL_FIND_USAGE_PARA")]
    public CTL_FIND_USAGE_PARA* pUsagePara;

    /// <include file='CTL_FIND_SUBJECT_PARA.xml' path='doc/member[@name="CTL_FIND_SUBJECT_PARA.dwSubjectType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSubjectType;

    /// <include file='CTL_FIND_SUBJECT_PARA.xml' path='doc/member[@name="CTL_FIND_SUBJECT_PARA.pvSubject"]/*' />
    public void* pvSubject;
}
