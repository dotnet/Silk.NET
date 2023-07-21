// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STARTUPINFOEXW.xml' path='doc/member[@name="STARTUPINFOEXW"]/*' />
public partial struct STARTUPINFOEXW
{
    /// <include file='STARTUPINFOEXW.xml' path='doc/member[@name="STARTUPINFOEXW.StartupInfo"]/*' />
    public STARTUPINFOW StartupInfo;

    /// <include file='STARTUPINFOEXW.xml' path='doc/member[@name="STARTUPINFOEXW.lpAttributeList"]/*' />
    public LPPROC_THREAD_ATTRIBUTE_LIST lpAttributeList;
}
