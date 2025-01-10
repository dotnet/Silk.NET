// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechPhraseProperty
{
    DISPID_SPPName = 1,
    DISPID_SPPId = (DISPID_SPPName + 1),
    DISPID_SPPValue = (DISPID_SPPId + 1),
    DISPID_SPPFirstElement = (DISPID_SPPValue + 1),
    DISPID_SPPNumberOfElements = (DISPID_SPPFirstElement + 1),
    DISPID_SPPEngineConfidence = (DISPID_SPPNumberOfElements + 1),
    DISPID_SPPConfidence = (DISPID_SPPEngineConfidence + 1),
    DISPID_SPPParent = (DISPID_SPPConfidence + 1),
    DISPID_SPPChildren = (DISPID_SPPParent + 1),
}
