// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG"]/*'/>
public enum DISPIDSPRG
{
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGId"]/*'/>
    DISPID_SRGId = 1,
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGRecoContext"]/*'/>
    DISPID_SRGRecoContext = (DISPID_SRGId + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGState"]/*'/>
    DISPID_SRGState = (DISPID_SRGRecoContext + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGRules"]/*'/>
    DISPID_SRGRules = (DISPID_SRGState + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGReset"]/*'/>
    DISPID_SRGReset = (DISPID_SRGRules + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCommit"]/*'/>
    DISPID_SRGCommit = (DISPID_SRGReset + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdLoadFromFile"]/*'/>
    DISPID_SRGCmdLoadFromFile = (DISPID_SRGCommit + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdLoadFromObject"]/*'/>
    DISPID_SRGCmdLoadFromObject = (DISPID_SRGCmdLoadFromFile + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdLoadFromResource"]/*'/>
    DISPID_SRGCmdLoadFromResource = (DISPID_SRGCmdLoadFromObject + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdLoadFromMemory"]/*'/>
    DISPID_SRGCmdLoadFromMemory = (DISPID_SRGCmdLoadFromResource + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdLoadFromProprietaryGrammar"]/*'/>
    DISPID_SRGCmdLoadFromProprietaryGrammar = (DISPID_SRGCmdLoadFromMemory + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdSetRuleState"]/*'/>
    DISPID_SRGCmdSetRuleState = (DISPID_SRGCmdLoadFromProprietaryGrammar + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGCmdSetRuleIdState"]/*'/>
    DISPID_SRGCmdSetRuleIdState = (DISPID_SRGCmdSetRuleState + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGDictationLoad"]/*'/>
    DISPID_SRGDictationLoad = (DISPID_SRGCmdSetRuleIdState + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGDictationUnload"]/*'/>
    DISPID_SRGDictationUnload = (DISPID_SRGDictationLoad + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGDictationSetState"]/*'/>
    DISPID_SRGDictationSetState = (DISPID_SRGDictationUnload + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGSetWordSequenceData"]/*'/>
    DISPID_SRGSetWordSequenceData = (DISPID_SRGDictationSetState + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGSetTextSelection"]/*'/>
    DISPID_SRGSetTextSelection = (DISPID_SRGSetWordSequenceData + 1),
    /// <include file='DISPIDSPRG.xml' path='doc/member[@name="DISPIDSPRG.DISPID_SRGIsPronounceable"]/*'/>
    DISPID_SRGIsPronounceable = (DISPID_SRGSetTextSelection + 1),
}