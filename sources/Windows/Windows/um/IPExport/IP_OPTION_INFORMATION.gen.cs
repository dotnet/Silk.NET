// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IP_OPTION_INFORMATION.xml' path='doc/member[@name="IP_OPTION_INFORMATION"]/*' />
public unsafe partial struct IP_OPTION_INFORMATION
{
    /// <include file='IP_OPTION_INFORMATION.xml' path='doc/member[@name="IP_OPTION_INFORMATION.Ttl"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Ttl;

    /// <include file='IP_OPTION_INFORMATION.xml' path='doc/member[@name="IP_OPTION_INFORMATION.Tos"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Tos;

    /// <include file='IP_OPTION_INFORMATION.xml' path='doc/member[@name="IP_OPTION_INFORMATION.Flags"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Flags;

    /// <include file='IP_OPTION_INFORMATION.xml' path='doc/member[@name="IP_OPTION_INFORMATION.OptionsSize"]/*' />
    [NativeTypeName("UCHAR")]
    public byte OptionsSize;

    /// <include file='IP_OPTION_INFORMATION.xml' path='doc/member[@name="IP_OPTION_INFORMATION.OptionsData"]/*' />
    [NativeTypeName("PUCHAR")]
    public byte* OptionsData;
}
