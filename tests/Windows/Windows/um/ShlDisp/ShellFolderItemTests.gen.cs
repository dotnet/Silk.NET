// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ShellFolderItem"/> struct.</summary>
public static unsafe partial class ShellFolderItemTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ShellFolderItem"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ShellFolderItem).GUID, Is.EqualTo(IID_ShellFolderItem));
    }

    /// <summary>Validates that the <see cref = "ShellFolderItem"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShellFolderItem>(), Is.EqualTo(sizeof(ShellFolderItem)));
    }

    /// <summary>Validates that the <see cref = "ShellFolderItem"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShellFolderItem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ShellFolderItem"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShellFolderItem), Is.EqualTo(1));
    }
}