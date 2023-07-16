// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_AV_PAIR.xml' path='doc/member[@name="MSV1_0_AV_PAIR"]/*'/>
public partial struct MSV1_0_AV_PAIR
{
    /// <include file='MSV1_0_AV_PAIR.xml' path='doc/member[@name="MSV1_0_AV_PAIR.AvId"]/*'/>
    public ushort AvId;
    /// <include file='MSV1_0_AV_PAIR.xml' path='doc/member[@name="MSV1_0_AV_PAIR.AvLen"]/*'/>
    public ushort AvLen;
}