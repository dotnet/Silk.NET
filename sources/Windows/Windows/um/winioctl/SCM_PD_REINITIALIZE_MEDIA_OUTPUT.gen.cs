// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_REINITIALIZE_MEDIA_OUTPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_OUTPUT"]/*'/>
public partial struct SCM_PD_REINITIALIZE_MEDIA_OUTPUT
{
    /// <include file='SCM_PD_REINITIALIZE_MEDIA_OUTPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_OUTPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_REINITIALIZE_MEDIA_OUTPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_REINITIALIZE_MEDIA_OUTPUT.xml' path='doc/member[@name="SCM_PD_REINITIALIZE_MEDIA_OUTPUT.Status"]/*'/>
    public SCM_PD_MEDIA_REINITIALIZATION_STATUS Status;
}