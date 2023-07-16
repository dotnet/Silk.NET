// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/davclnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DAV_CALLBACK_CRED.xml' path='doc/member[@name="DAV_CALLBACK_CRED"]/*'/>
public partial struct DAV_CALLBACK_CRED
{
    /// <include file='DAV_CALLBACK_CRED.xml' path='doc/member[@name="DAV_CALLBACK_CRED.AuthBlob"]/*'/>
    public DAV_CALLBACK_AUTH_BLOB AuthBlob;
    /// <include file='DAV_CALLBACK_CRED.xml' path='doc/member[@name="DAV_CALLBACK_CRED.UNPBlob"]/*'/>
    public DAV_CALLBACK_AUTH_UNP UNPBlob;
    /// <include file='DAV_CALLBACK_CRED.xml' path='doc/member[@name="DAV_CALLBACK_CRED.bAuthBlobValid"]/*'/>
    public BOOL bAuthBlobValid;
    /// <include file='DAV_CALLBACK_CRED.xml' path='doc/member[@name="DAV_CALLBACK_CRED.bSave"]/*'/>
    public BOOL bSave;
}