// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IEnumTfProperties"/> struct.</summary>
public static unsafe partial class IEnumTfPropertiesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEnumTfProperties"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumTfProperties).GUID, Is.EqualTo(IID_IEnumTfProperties));
    }

    /// <summary>Validates that the <see cref = "IEnumTfProperties"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumTfProperties>(), Is.EqualTo(sizeof(IEnumTfProperties)));
    }

    /// <summary>Validates that the <see cref = "IEnumTfProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumTfProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEnumTfProperties"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumTfProperties), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumTfProperties), Is.EqualTo(4));
        }
    }
}