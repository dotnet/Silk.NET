// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MSV1_0_LM20_LOGON_PROFILE
{
    public MSV1_0_PROFILE_BUFFER_TYPE MessageType;
    public LARGE_INTEGER KickOffTime;
    public LARGE_INTEGER LogoffTime;

    [NativeTypeName("ULONG")]
    public uint UserFlags;

    [NativeTypeName("UCHAR[16]")]
    public _UserSessionKey_e__FixedBuffer UserSessionKey;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    [NativeTypeName("UCHAR[8]")]
    public _LanmanSessionKey_e__FixedBuffer LanmanSessionKey;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonServer;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserParameters;

    [InlineArray(16)]
    public partial struct _UserSessionKey_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _LanmanSessionKey_e__FixedBuffer
    {
        public byte e0;
    }
}
