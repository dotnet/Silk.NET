// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CSPLATFORM.xml' path='doc/member[@name="CSPLATFORM"]/*' />
public partial struct CSPLATFORM
{
    /// <include file='CSPLATFORM.xml' path='doc/member[@name="CSPLATFORM.dwPlatformId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPlatformId;

    /// <include file='CSPLATFORM.xml' path='doc/member[@name="CSPLATFORM.dwVersionHi"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersionHi;

    /// <include file='CSPLATFORM.xml' path='doc/member[@name="CSPLATFORM.dwVersionLo"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersionLo;

    /// <include file='CSPLATFORM.xml' path='doc/member[@name="CSPLATFORM.dwProcessorArch"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProcessorArch;
}
