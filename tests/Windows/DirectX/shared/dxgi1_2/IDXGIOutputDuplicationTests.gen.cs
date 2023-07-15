// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDXGIOutputDuplication"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDXGIOutputDuplicationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDXGIOutputDuplication"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXGIOutputDuplication).GUID, Is.EqualTo(IID_IDXGIOutputDuplication));
    }

    /// <summary>Validates that the <see cref = "IDXGIOutputDuplication"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXGIOutputDuplication>(), Is.EqualTo(sizeof(IDXGIOutputDuplication)));
    }

    /// <summary>Validates that the <see cref = "IDXGIOutputDuplication"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXGIOutputDuplication).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDXGIOutputDuplication"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXGIOutputDuplication), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXGIOutputDuplication), Is.EqualTo(4));
        }
    }
}