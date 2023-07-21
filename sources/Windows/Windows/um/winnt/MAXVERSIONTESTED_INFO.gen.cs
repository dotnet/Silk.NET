// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MAXVERSIONTESTED_INFO.xml' path='doc/member[@name="MAXVERSIONTESTED_INFO"]/*' />
public partial struct MAXVERSIONTESTED_INFO
{
    /// <include file='MAXVERSIONTESTED_INFO.xml' path='doc/member[@name="MAXVERSIONTESTED_INFO.MaxVersionTested"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MaxVersionTested;
}
