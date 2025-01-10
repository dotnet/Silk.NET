// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DISPID_SpeechBaseStream
{
    DISPID_SBSFormat = 1,
    DISPID_SBSRead = (DISPID_SBSFormat + 1),
    DISPID_SBSWrite = (DISPID_SBSRead + 1),
    DISPID_SBSSeek = (DISPID_SBSWrite + 1),
}
