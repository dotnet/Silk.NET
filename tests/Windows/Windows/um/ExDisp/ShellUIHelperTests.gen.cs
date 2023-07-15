// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ShellUIHelper"/> struct.</summary>
public static unsafe partial class ShellUIHelperTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ShellUIHelper"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ShellUIHelper).GUID, Is.EqualTo(IID_ShellUIHelper));
    }

    /// <summary>Validates that the <see cref = "ShellUIHelper"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShellUIHelper>(), Is.EqualTo(sizeof(ShellUIHelper)));
    }

    /// <summary>Validates that the <see cref = "ShellUIHelper"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShellUIHelper).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ShellUIHelper"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShellUIHelper), Is.EqualTo(1));
    }
}