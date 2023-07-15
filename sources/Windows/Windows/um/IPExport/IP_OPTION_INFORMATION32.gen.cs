// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IP_OPTION_INFORMATION32.xml' path='doc/member[@name="IP_OPTION_INFORMATION32"]/*'/>
public unsafe partial struct IP_OPTION_INFORMATION32
{
    /// <include file='IP_OPTION_INFORMATION32.xml' path='doc/member[@name="IP_OPTION_INFORMATION32.Ttl"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Ttl;
    /// <include file='IP_OPTION_INFORMATION32.xml' path='doc/member[@name="IP_OPTION_INFORMATION32.Tos"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Tos;
    /// <include file='IP_OPTION_INFORMATION32.xml' path='doc/member[@name="IP_OPTION_INFORMATION32.Flags"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Flags;
    /// <include file='IP_OPTION_INFORMATION32.xml' path='doc/member[@name="IP_OPTION_INFORMATION32.OptionsSize"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte OptionsSize;
    /// <include file='IP_OPTION_INFORMATION32.xml' path='doc/member[@name="IP_OPTION_INFORMATION32.OptionsData"]/*'/>
    [NativeTypeName("UCHAR * __ptr32")]
    public byte* OptionsData;
}