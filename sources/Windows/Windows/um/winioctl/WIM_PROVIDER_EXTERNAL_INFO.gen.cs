// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO"]/*'/>
public unsafe partial struct WIM_PROVIDER_EXTERNAL_INFO
{
    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.DataSourceId"]/*'/>
    public LARGE_INTEGER DataSourceId;
    /// <include file='WIM_PROVIDER_EXTERNAL_INFO.xml' path='doc/member[@name="WIM_PROVIDER_EXTERNAL_INFO.ResourceHash"]/*'/>
    [NativeTypeName("BYTE[20]")]
    public fixed byte ResourceHash[20];
}