// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechGrammarRule
{
    DISPID_SGRAttributes = 1,
    DISPID_SGRInitialState = (DISPID_SGRAttributes + 1),
    DISPID_SGRName = (DISPID_SGRInitialState + 1),
    DISPID_SGRId = (DISPID_SGRName + 1),
    DISPID_SGRClear = (DISPID_SGRId + 1),
    DISPID_SGRAddResource = (DISPID_SGRClear + 1),
    DISPID_SGRAddState = (DISPID_SGRAddResource + 1),
}
