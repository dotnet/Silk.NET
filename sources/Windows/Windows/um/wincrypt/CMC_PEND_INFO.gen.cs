// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMC_PEND_INFO.xml' path='doc/member[@name="CMC_PEND_INFO"]/*'/>
public partial struct CMC_PEND_INFO
{
    /// <include file='CMC_PEND_INFO.xml' path='doc/member[@name="CMC_PEND_INFO.PendToken"]/*'/>
    public CRYPT_DATA_BLOB PendToken;
    /// <include file='CMC_PEND_INFO.xml' path='doc/member[@name="CMC_PEND_INFO.PendTime"]/*'/>
    public FILETIME PendTime;
}