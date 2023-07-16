// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FileSaveDialog"/> struct.</summary>
public static unsafe partial class FileSaveDialogTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "FileSaveDialog"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(FileSaveDialog).GUID, Is.EqualTo(IID_FileSaveDialog));
    }

    /// <summary>Validates that the <see cref = "FileSaveDialog"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FileSaveDialog>(), Is.EqualTo(sizeof(FileSaveDialog)));
    }

    /// <summary>Validates that the <see cref = "FileSaveDialog"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FileSaveDialog).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FileSaveDialog"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FileSaveDialog), Is.EqualTo(1));
    }
}