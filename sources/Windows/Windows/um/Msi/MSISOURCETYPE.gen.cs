// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSISOURCETYPE.xml' path='doc/member[@name="MSISOURCETYPE"]/*'/>
public enum MSISOURCETYPE
{
    /// <include file='MSISOURCETYPE.xml' path='doc/member[@name="MSISOURCETYPE.MSISOURCETYPE_UNKNOWN"]/*'/>
    MSISOURCETYPE_UNKNOWN = 0x00000000,
    /// <include file='MSISOURCETYPE.xml' path='doc/member[@name="MSISOURCETYPE.MSISOURCETYPE_NETWORK"]/*'/>
    MSISOURCETYPE_NETWORK = 0x00000001,
    /// <include file='MSISOURCETYPE.xml' path='doc/member[@name="MSISOURCETYPE.MSISOURCETYPE_URL"]/*'/>
    MSISOURCETYPE_URL = 0x00000002,
    /// <include file='MSISOURCETYPE.xml' path='doc/member[@name="MSISOURCETYPE.MSISOURCETYPE_MEDIA"]/*'/>
    MSISOURCETYPE_MEDIA = 0x00000004,
}