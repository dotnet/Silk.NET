// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS"]/*'/>
public enum _MFP_CREDENTIAL_FLAGS
{
    /// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS.MFP_CREDENTIAL_PROMPT"]/*'/>
    MFP_CREDENTIAL_PROMPT = 0x1,
    /// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS.MFP_CREDENTIAL_SAVE"]/*'/>
    MFP_CREDENTIAL_SAVE = 0x2,
    /// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS.MFP_CREDENTIAL_DO_NOT_CACHE"]/*'/>
    MFP_CREDENTIAL_DO_NOT_CACHE = 0x4,
    /// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS.MFP_CREDENTIAL_CLEAR_TEXT"]/*'/>
    MFP_CREDENTIAL_CLEAR_TEXT = 0x8,
    /// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS.MFP_CREDENTIAL_PROXY"]/*'/>
    MFP_CREDENTIAL_PROXY = 0x10,
    /// <include file='_MFP_CREDENTIAL_FLAGS.xml' path='doc/member[@name="_MFP_CREDENTIAL_FLAGS.MFP_CREDENTIAL_LOGGED_ON_USER"]/*'/>
    MFP_CREDENTIAL_LOGGED_ON_USER = 0x20,
}