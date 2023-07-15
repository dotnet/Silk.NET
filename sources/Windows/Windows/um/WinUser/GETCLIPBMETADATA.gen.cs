// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GETCLIPBMETADATA.xml' path='doc/member[@name="GETCLIPBMETADATA"]/*'/>
public partial struct GETCLIPBMETADATA
{
    /// <include file='GETCLIPBMETADATA.xml' path='doc/member[@name="GETCLIPBMETADATA.Version"]/*'/>
    public uint Version;
    /// <include file='GETCLIPBMETADATA.xml' path='doc/member[@name="GETCLIPBMETADATA.IsDelayRendered"]/*'/>
    public BOOL IsDelayRendered;
    /// <include file='GETCLIPBMETADATA.xml' path='doc/member[@name="GETCLIPBMETADATA.IsSynthetic"]/*'/>
    public BOOL IsSynthetic;
}