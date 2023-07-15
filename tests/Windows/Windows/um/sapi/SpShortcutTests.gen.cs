// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SpShortcut"/> struct.</summary>
public static unsafe partial class SpShortcutTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SpShortcut"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SpShortcut).GUID, Is.EqualTo(CLSID_SpShortcut));
    }

    /// <summary>Validates that the <see cref = "SpShortcut"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpShortcut>(), Is.EqualTo(sizeof(SpShortcut)));
    }

    /// <summary>Validates that the <see cref = "SpShortcut"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpShortcut).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpShortcut"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpShortcut), Is.EqualTo(1));
    }
}