// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='HTMLStyleSheetRulesAppliedCollection.xml' path='doc/member[@name="HTMLStyleSheetRulesAppliedCollection"]/*'/>
[Guid("EB36F845-2395-4719-B85C-D0D80E184BD9")]
public unsafe partial struct HTMLStyleSheetRulesAppliedCollection : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_HTMLStyleSheetRulesAppliedCollection));
}