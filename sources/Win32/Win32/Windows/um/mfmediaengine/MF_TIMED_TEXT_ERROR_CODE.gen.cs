// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_TIMED_TEXT_ERROR_CODE
{
    MF_TIMED_TEXT_ERROR_CODE_NOERROR = 0,
    MF_TIMED_TEXT_ERROR_CODE_FATAL = 1,
    MF_TIMED_TEXT_ERROR_CODE_DATA_FORMAT = 2,
    MF_TIMED_TEXT_ERROR_CODE_NETWORK = 3,
    MF_TIMED_TEXT_ERROR_CODE_INTERNAL = 4,
}
