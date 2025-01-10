// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TfSapiObject
{
    GETIF_RESMGR = 0,
    GETIF_RECOCONTEXT = 0x1,
    GETIF_RECOGNIZER = 0x2,
    GETIF_VOICE = 0x3,
    GETIF_DICTGRAM = 0x4,
    GETIF_RECOGNIZERNOINIT = 0x5,
}
