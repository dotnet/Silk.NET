// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDMLOperatorInitializer"/> struct.</summary>
public static unsafe partial class IDMLOperatorInitializerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDMLOperatorInitializer"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLOperatorInitializer).GUID, Is.EqualTo(IID_IDMLOperatorInitializer));
    }

    /// <summary>Validates that the <see cref = "IDMLOperatorInitializer"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDMLOperatorInitializer>(), Is.EqualTo(sizeof(IDMLOperatorInitializer)));
    }

    /// <summary>Validates that the <see cref = "IDMLOperatorInitializer"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDMLOperatorInitializer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDMLOperatorInitializer"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDMLOperatorInitializer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDMLOperatorInitializer), Is.EqualTo(4));
        }
    }
}