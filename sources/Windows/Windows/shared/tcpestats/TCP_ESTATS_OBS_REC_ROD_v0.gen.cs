// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCP_ESTATS_OBS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_OBS_REC_ROD_v0"]/*'/>
public partial struct TCP_ESTATS_OBS_REC_ROD_v0
{
    /// <include file='TCP_ESTATS_OBS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_OBS_REC_ROD_v0.CurRwinRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CurRwinRcvd;
    /// <include file='TCP_ESTATS_OBS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_OBS_REC_ROD_v0.MaxRwinRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaxRwinRcvd;
    /// <include file='TCP_ESTATS_OBS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_OBS_REC_ROD_v0.MinRwinRcvd"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MinRwinRcvd;
    /// <include file='TCP_ESTATS_OBS_REC_ROD_v0.xml' path='doc/member[@name="TCP_ESTATS_OBS_REC_ROD_v0.WinScaleRcvd"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte WinScaleRcvd;
}