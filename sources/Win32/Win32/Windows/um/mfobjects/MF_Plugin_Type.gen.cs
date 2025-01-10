// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_Plugin_Type
{
    MF_Plugin_Type_MFT = 0,
    MF_Plugin_Type_MediaSource = 1,
    MF_Plugin_Type_MFT_MatchOutputType = 2,
    MF_Plugin_Type_Other = unchecked((int)((uint)(-1))),
}
