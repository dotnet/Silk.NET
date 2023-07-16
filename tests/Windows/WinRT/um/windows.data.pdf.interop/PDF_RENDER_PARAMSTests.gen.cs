// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "PDF_RENDER_PARAMS"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class PDF_RENDER_PARAMSTests
{
    /// <summary>Validates that the <see cref = "PDF_RENDER_PARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PDF_RENDER_PARAMS>(), Is.EqualTo(sizeof(PDF_RENDER_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "PDF_RENDER_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PDF_RENDER_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PDF_RENDER_PARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PDF_RENDER_PARAMS), Is.EqualTo(44));
    }
}