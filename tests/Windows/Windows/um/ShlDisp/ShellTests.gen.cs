// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Shell"/> struct.</summary>
public static unsafe partial class ShellTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "Shell"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(Shell).GUID, Is.EqualTo(IID_Shell));
    }

    /// <summary>Validates that the <see cref = "Shell"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Shell>(), Is.EqualTo(sizeof(Shell)));
    }

    /// <summary>Validates that the <see cref = "Shell"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Shell).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Shell"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Shell), Is.EqualTo(1));
    }
}