// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

public static partial class GUID
{
    [NativeTypeName("#define GUID_CLASS_COMPORT GUID_DEVINTERFACE_COMPORT")]
    public static ref readonly Guid GUID_CLASS_COMPORT => ref GUID_DEVINTERFACE_COMPORT;

    [NativeTypeName("#define GUID_SERENUM_BUS_ENUMERATOR GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR")]
    public static ref readonly Guid GUID_SERENUM_BUS_ENUMERATOR => ref GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR;
}
