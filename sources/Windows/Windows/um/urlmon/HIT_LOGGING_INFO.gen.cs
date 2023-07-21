// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HIT_LOGGING_INFO.xml' path='doc/member[@name="HIT_LOGGING_INFO"]/*' />
public unsafe partial struct HIT_LOGGING_INFO
{
    /// <include file='HIT_LOGGING_INFO.xml' path='doc/member[@name="HIT_LOGGING_INFO.dwStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStructSize;

    /// <include file='HIT_LOGGING_INFO.xml' path='doc/member[@name="HIT_LOGGING_INFO.lpszLoggedUrlName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpszLoggedUrlName;

    /// <include file='HIT_LOGGING_INFO.xml' path='doc/member[@name="HIT_LOGGING_INFO.StartTime"]/*' />
    public SYSTEMTIME StartTime;

    /// <include file='HIT_LOGGING_INFO.xml' path='doc/member[@name="HIT_LOGGING_INFO.EndTime"]/*' />
    public SYSTEMTIME EndTime;

    /// <include file='HIT_LOGGING_INFO.xml' path='doc/member[@name="HIT_LOGGING_INFO.lpszExtendedInfo"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpszExtendedInfo;
}
