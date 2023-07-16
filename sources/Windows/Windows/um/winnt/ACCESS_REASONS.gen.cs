// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACCESS_REASONS.xml' path='doc/member[@name="ACCESS_REASONS"]/*'/>
public unsafe partial struct ACCESS_REASONS
{
    /// <include file='ACCESS_REASONS.xml' path='doc/member[@name="ACCESS_REASONS.Data"]/*'/>
    [NativeTypeName("ACCESS_REASON[32]")]
    public fixed uint Data[32];
}