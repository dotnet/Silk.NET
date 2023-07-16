// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE"]/*'/>
public unsafe partial struct MSV1_0_NTLM3_RESPONSE
{
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.Response"]/*'/>
    [NativeTypeName("UCHAR[16]")]
    public fixed byte Response[16];
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.RespType"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte RespType;
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.HiRespType"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte HiRespType;
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.Flags"]/*'/>
    public ushort Flags;
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.MsgWord"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MsgWord;
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.TimeStamp"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TimeStamp;
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.ChallengeFromClient"]/*'/>
    [NativeTypeName("UCHAR[8]")]
    public fixed byte ChallengeFromClient[8];
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.AvPairsOff"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AvPairsOff;
    /// <include file='MSV1_0_NTLM3_RESPONSE.xml' path='doc/member[@name="MSV1_0_NTLM3_RESPONSE.Buffer"]/*'/>
    [NativeTypeName("UCHAR[1]")]
    public fixed byte Buffer[1];
}