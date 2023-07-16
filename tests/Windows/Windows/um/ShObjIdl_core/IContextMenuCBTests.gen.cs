// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IContextMenuCB"/> struct.</summary>
public static unsafe partial class IContextMenuCBTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContextMenuCB"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IContextMenuCB).GUID, Is.EqualTo(IID_IContextMenuCB));
    }

    /// <summary>Validates that the <see cref = "IContextMenuCB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IContextMenuCB>(), Is.EqualTo(sizeof(IContextMenuCB)));
    }

    /// <summary>Validates that the <see cref = "IContextMenuCB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContextMenuCB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContextMenuCB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContextMenuCB), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContextMenuCB), Is.EqualTo(4));
        }
    }
}