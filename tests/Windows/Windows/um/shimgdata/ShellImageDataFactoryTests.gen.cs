// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ShellImageDataFactory"/> struct.</summary>
public static unsafe partial class ShellImageDataFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ShellImageDataFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ShellImageDataFactory).GUID, Is.EqualTo(IID_ShellImageDataFactory));
    }

    /// <summary>Validates that the <see cref = "ShellImageDataFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShellImageDataFactory>(), Is.EqualTo(sizeof(ShellImageDataFactory)));
    }

    /// <summary>Validates that the <see cref = "ShellImageDataFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShellImageDataFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ShellImageDataFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShellImageDataFactory), Is.EqualTo(1));
    }
}