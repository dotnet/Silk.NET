// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN_SPUB_TRUSTED_PUBLISHER_DATA.xml' path='doc/member[@name="WIN_SPUB_TRUSTED_PUBLISHER_DATA"]/*'/>
public unsafe partial struct WIN_SPUB_TRUSTED_PUBLISHER_DATA
{
    /// <include file='WIN_SPUB_TRUSTED_PUBLISHER_DATA.xml' path='doc/member[@name="WIN_SPUB_TRUSTED_PUBLISHER_DATA.hClientToken"]/*'/>
    public HANDLE hClientToken;
    /// <include file='WIN_SPUB_TRUSTED_PUBLISHER_DATA.xml' path='doc/member[@name="WIN_SPUB_TRUSTED_PUBLISHER_DATA.lpCertificate"]/*'/>
    [NativeTypeName("LPWIN_CERTIFICATE")]
    public WIN_CERTIFICATE* lpCertificate;
}