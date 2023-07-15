// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_ACCESS_DESCRIPTION.xml' path='doc/member[@name="CERT_ACCESS_DESCRIPTION"]/*'/>
public unsafe partial struct CERT_ACCESS_DESCRIPTION
{
    /// <include file='CERT_ACCESS_DESCRIPTION.xml' path='doc/member[@name="CERT_ACCESS_DESCRIPTION.pszAccessMethod"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszAccessMethod;
    /// <include file='CERT_ACCESS_DESCRIPTION.xml' path='doc/member[@name="CERT_ACCESS_DESCRIPTION.AccessLocation"]/*'/>
    public CERT_ALT_NAME_ENTRY AccessLocation;
}