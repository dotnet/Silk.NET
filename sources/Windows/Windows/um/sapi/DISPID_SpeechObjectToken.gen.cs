// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken"]/*'/>
public enum DISPID_SpeechObjectToken
{
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTId"]/*'/>
    DISPID_SOTId = 1,
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTDataKey"]/*'/>
    DISPID_SOTDataKey = (DISPID_SOTId + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTCategory"]/*'/>
    DISPID_SOTCategory = (DISPID_SOTDataKey + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTGetDescription"]/*'/>
    DISPID_SOTGetDescription = (DISPID_SOTCategory + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTSetId"]/*'/>
    DISPID_SOTSetId = (DISPID_SOTGetDescription + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTGetAttribute"]/*'/>
    DISPID_SOTGetAttribute = (DISPID_SOTSetId + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTCreateInstance"]/*'/>
    DISPID_SOTCreateInstance = (DISPID_SOTGetAttribute + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTRemove"]/*'/>
    DISPID_SOTRemove = (DISPID_SOTCreateInstance + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTGetStorageFileName"]/*'/>
    DISPID_SOTGetStorageFileName = (DISPID_SOTRemove + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTRemoveStorageFileName"]/*'/>
    DISPID_SOTRemoveStorageFileName = (DISPID_SOTGetStorageFileName + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTIsUISupported"]/*'/>
    DISPID_SOTIsUISupported = (DISPID_SOTRemoveStorageFileName + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTDisplayUI"]/*'/>
    DISPID_SOTDisplayUI = (DISPID_SOTIsUISupported + 1),
    /// <include file='DISPID_SpeechObjectToken.xml' path='doc/member[@name="DISPID_SpeechObjectToken.DISPID_SOTMatchesAttributes"]/*'/>
    DISPID_SOTMatchesAttributes = (DISPID_SOTDisplayUI + 1),
}