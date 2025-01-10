// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT CreatePresentationFactory(
        IUnknown d3dDevice,
        [NativeTypeName("const IID &")] Guid* riid,
        void** presentationFactory
    );
}
