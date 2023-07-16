// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='CODECAPI_GUID_AVEncCommonFormatVCD.xml' path='doc/member[@name="CODECAPI_GUID_AVEncCommonFormatVCD"]/*'/>
[Guid("95035BF7-9D90-40FF-AD5C-5CF8CF71CA1D")]
public unsafe partial struct CODECAPI_GUID_AVEncCommonFormatVCD : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_GUID_AVEncCommonFormatVCD));
}