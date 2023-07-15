// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCP_ESTATS_REC_RW_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_RW_v0"]/*'/>
public partial struct TCP_ESTATS_REC_RW_v0
{
    /// <include file='TCP_ESTATS_REC_RW_v0.xml' path='doc/member[@name="TCP_ESTATS_REC_RW_v0.EnableCollection"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte EnableCollection;
}