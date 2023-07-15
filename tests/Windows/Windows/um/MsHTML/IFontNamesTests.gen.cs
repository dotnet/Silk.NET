// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IFontNames"/> struct.</summary>
public static unsafe partial class IFontNamesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFontNames"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFontNames).GUID, Is.EqualTo(IID_IFontNames));
    }

    /// <summary>Validates that the <see cref = "IFontNames"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFontNames>(), Is.EqualTo(sizeof(IFontNames)));
    }

    /// <summary>Validates that the <see cref = "IFontNames"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFontNames).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFontNames"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFontNames), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFontNames), Is.EqualTo(4));
        }
    }
}