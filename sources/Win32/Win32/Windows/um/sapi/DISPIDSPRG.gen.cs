// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPIDSPRG
{
    DISPID_SRGId = 1,
    DISPID_SRGRecoContext = (DISPID_SRGId + 1),
    DISPID_SRGState = (DISPID_SRGRecoContext + 1),
    DISPID_SRGRules = (DISPID_SRGState + 1),
    DISPID_SRGReset = (DISPID_SRGRules + 1),
    DISPID_SRGCommit = (DISPID_SRGReset + 1),
    DISPID_SRGCmdLoadFromFile = (DISPID_SRGCommit + 1),
    DISPID_SRGCmdLoadFromObject = (DISPID_SRGCmdLoadFromFile + 1),
    DISPID_SRGCmdLoadFromResource = (DISPID_SRGCmdLoadFromObject + 1),
    DISPID_SRGCmdLoadFromMemory = (DISPID_SRGCmdLoadFromResource + 1),
    DISPID_SRGCmdLoadFromProprietaryGrammar = (DISPID_SRGCmdLoadFromMemory + 1),
    DISPID_SRGCmdSetRuleState = (DISPID_SRGCmdLoadFromProprietaryGrammar + 1),
    DISPID_SRGCmdSetRuleIdState = (DISPID_SRGCmdSetRuleState + 1),
    DISPID_SRGDictationLoad = (DISPID_SRGCmdSetRuleIdState + 1),
    DISPID_SRGDictationUnload = (DISPID_SRGDictationLoad + 1),
    DISPID_SRGDictationSetState = (DISPID_SRGDictationUnload + 1),
    DISPID_SRGSetWordSequenceData = (DISPID_SRGDictationSetState + 1),
    DISPID_SRGSetTextSelection = (DISPID_SRGSetWordSequenceData + 1),
    DISPID_SRGIsPronounceable = (DISPID_SRGSetTextSelection + 1),
}
