// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ShellDesktop"/> struct.</summary>
public static unsafe partial class ShellDesktopTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ShellDesktop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ShellDesktop).GUID, Is.EqualTo(IID_ShellDesktop));
    }

    /// <summary>Validates that the <see cref = "ShellDesktop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShellDesktop>(), Is.EqualTo(sizeof(ShellDesktop)));
    }

    /// <summary>Validates that the <see cref = "ShellDesktop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShellDesktop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ShellDesktop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShellDesktop), Is.EqualTo(1));
    }
}