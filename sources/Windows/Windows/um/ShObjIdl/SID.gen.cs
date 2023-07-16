// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
public partial struct SID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid SID_SCommandBarState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x5C,
                0xAA,
                0x9E,
                0xB9,
                0x50,
                0x38,
                0x00,
                0x44,
                0xBC,
                0x33,
                0x2C,
                0xE5,
                0x34,
                0x04,
                0x8B,
                0xF8
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define SID_WizardSite IID_IWizardSite")]
    public static ref readonly Guid SID_WizardSite => ref IID_IWizardSite;

    [NativeTypeName("#define SID_WebWizardHost IID_IWebWizardExtension")]
    public static ref readonly Guid SID_WebWizardHost => ref IID_IWebWizardExtension;

    [NativeTypeName("#define SID_CDWizardHost IID_ICDBurnExt")]
    public static ref readonly Guid SID_CDWizardHost => ref IID_ICDBurnExt;

    [NativeTypeName("#define SID_EnumerableView IID_IEnumerableView")]
    public static ref readonly Guid SID_EnumerableView => ref IID_IEnumerableView;

    [NativeTypeName("#define SID_SBandHost IID_IBandHost")]
    public static ref readonly Guid SID_SBandHost => ref IID_IBandHost;

    [NativeTypeName("#define SID_PublishingWizard CLSID_PublishingWizard")]
    public static ref readonly Guid SID_PublishingWizard => ref CLSID_PublishingWizard;
}