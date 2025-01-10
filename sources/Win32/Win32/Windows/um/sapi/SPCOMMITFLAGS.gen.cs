// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPCOMMITFLAGS
{
    SPCF_NONE = 0,
    SPCF_ADD_TO_USER_LEXICON = (1 << 0),
    SPCF_DEFINITE_CORRECTION = (1 << 1),
}
