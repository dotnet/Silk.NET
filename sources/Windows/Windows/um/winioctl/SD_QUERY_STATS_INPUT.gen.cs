// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SD_QUERY_STATS_INPUT.xml' path='doc/member[@name="SD_QUERY_STATS_INPUT"]/*'/>
public partial struct SD_QUERY_STATS_INPUT
{
    /// <include file='SD_QUERY_STATS_INPUT.xml' path='doc/member[@name="SD_QUERY_STATS_INPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}