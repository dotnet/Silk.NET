// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPFILEMODE
{
    SPFM_OPEN_READONLY = 0,
    SPFM_OPEN_READWRITE = (SPFM_OPEN_READONLY + 1),
    SPFM_CREATE = (SPFM_OPEN_READWRITE + 1),
    SPFM_CREATE_ALWAYS = (SPFM_CREATE + 1),
    SPFM_NUM_MODES = (SPFM_CREATE_ALWAYS + 1),
}
