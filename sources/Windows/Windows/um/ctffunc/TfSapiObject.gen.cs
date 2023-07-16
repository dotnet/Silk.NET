// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject"]/*'/>
public enum TfSapiObject
{
    /// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject.GETIF_RESMGR"]/*'/>
    GETIF_RESMGR = 0,
    /// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject.GETIF_RECOCONTEXT"]/*'/>
    GETIF_RECOCONTEXT = 0x1,
    /// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject.GETIF_RECOGNIZER"]/*'/>
    GETIF_RECOGNIZER = 0x2,
    /// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject.GETIF_VOICE"]/*'/>
    GETIF_VOICE = 0x3,
    /// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject.GETIF_DICTGRAM"]/*'/>
    GETIF_DICTGRAM = 0x4,
    /// <include file='TfSapiObject.xml' path='doc/member[@name="TfSapiObject.GETIF_RECOGNIZERNOINIT"]/*'/>
    GETIF_RECOGNIZERNOINIT = 0x5,
}