// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

public partial struct SID
{
    [NativeTypeName("#define SID_SOleUndoManager IID_IOleUndoManager")]
    public static ref readonly Guid SID_SOleUndoManager => ref IID_IOleUndoManager;
}
