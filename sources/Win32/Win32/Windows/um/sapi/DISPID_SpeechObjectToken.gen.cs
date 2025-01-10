// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechObjectToken
{
    DISPID_SOTId = 1,
    DISPID_SOTDataKey = (DISPID_SOTId + 1),
    DISPID_SOTCategory = (DISPID_SOTDataKey + 1),
    DISPID_SOTGetDescription = (DISPID_SOTCategory + 1),
    DISPID_SOTSetId = (DISPID_SOTGetDescription + 1),
    DISPID_SOTGetAttribute = (DISPID_SOTSetId + 1),
    DISPID_SOTCreateInstance = (DISPID_SOTGetAttribute + 1),
    DISPID_SOTRemove = (DISPID_SOTCreateInstance + 1),
    DISPID_SOTGetStorageFileName = (DISPID_SOTRemove + 1),
    DISPID_SOTRemoveStorageFileName = (DISPID_SOTGetStorageFileName + 1),
    DISPID_SOTIsUISupported = (DISPID_SOTRemoveStorageFileName + 1),
    DISPID_SOTDisplayUI = (DISPID_SOTIsUISupported + 1),
    DISPID_SOTMatchesAttributes = (DISPID_SOTDisplayUI + 1),
}
