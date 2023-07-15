// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WOF_EXTERNAL_INFO.xml' path='doc/member[@name="WOF_EXTERNAL_INFO"]/*'/>
public partial struct WOF_EXTERNAL_INFO
{
    /// <include file='WOF_EXTERNAL_INFO.xml' path='doc/member[@name="WOF_EXTERNAL_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='WOF_EXTERNAL_INFO.xml' path='doc/member[@name="WOF_EXTERNAL_INFO.Provider"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Provider;
}