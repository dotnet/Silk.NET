// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IQueryAssociations"/> struct.</summary>
public static unsafe partial class IQueryAssociationsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IQueryAssociations"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IQueryAssociations).GUID, Is.EqualTo(IID_IQueryAssociations));
    }

    /// <summary>Validates that the <see cref = "IQueryAssociations"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IQueryAssociations>(), Is.EqualTo(sizeof(IQueryAssociations)));
    }

    /// <summary>Validates that the <see cref = "IQueryAssociations"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IQueryAssociations).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IQueryAssociations"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IQueryAssociations), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IQueryAssociations), Is.EqualTo(4));
        }
    }
}