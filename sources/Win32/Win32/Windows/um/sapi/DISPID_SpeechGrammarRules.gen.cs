// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechGrammarRules
{
    DISPID_SGRsCount = 1,
    DISPID_SGRsDynamic = (DISPID_SGRsCount + 1),
    DISPID_SGRsAdd = (DISPID_SGRsDynamic + 1),
    DISPID_SGRsCommit = (DISPID_SGRsAdd + 1),
    DISPID_SGRsCommitAndSave = (DISPID_SGRsCommit + 1),
    DISPID_SGRsFindRule = (DISPID_SGRsCommitAndSave + 1),
    DISPID_SGRsItem = (0),
    DISPID_SGRs_NewEnum = (-4),
}
