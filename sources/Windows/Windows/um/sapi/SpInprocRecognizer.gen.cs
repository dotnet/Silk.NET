// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows;

/// <include file='SpInprocRecognizer.xml' path='doc/member[@name="SpInprocRecognizer"]/*' />
[Guid("41B89B6B-9399-11D2-9623-00C04F8EE628")]
public unsafe partial struct SpInprocRecognizer : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_SpInprocRecognizer));
}
