// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MSV1_0_LM20_LOGON
{
    public MSV1_0_LOGON_SUBMIT_TYPE MessageType;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING LogonDomainName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING UserName;

    [NativeTypeName("UNICODE_STRING")]
    public LSA_UNICODE_STRING Workstation;

    [NativeTypeName("UCHAR[8]")]
    public _ChallengeToClient_e__FixedBuffer ChallengeToClient;

    [NativeTypeName("STRING")]
    public LSA_STRING CaseSensitiveChallengeResponse;

    [NativeTypeName("STRING")]
    public LSA_STRING CaseInsensitiveChallengeResponse;

    [NativeTypeName("ULONG")]
    public uint ParameterControl;

    [InlineArray(8)]
    public partial struct _ChallengeToClient_e__FixedBuffer
    {
        public byte e0;
    }
}
