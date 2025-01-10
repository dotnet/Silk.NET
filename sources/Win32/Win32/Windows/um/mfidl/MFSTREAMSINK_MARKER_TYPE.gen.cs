// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MFSTREAMSINK_MARKER_TYPE
{
    MFSTREAMSINK_MARKER_DEFAULT = 0,
    MFSTREAMSINK_MARKER_ENDOFSEGMENT = (MFSTREAMSINK_MARKER_DEFAULT + 1),
    MFSTREAMSINK_MARKER_TICK = (MFSTREAMSINK_MARKER_ENDOFSEGMENT + 1),
    MFSTREAMSINK_MARKER_EVENT = (MFSTREAMSINK_MARKER_TICK + 1),
}
