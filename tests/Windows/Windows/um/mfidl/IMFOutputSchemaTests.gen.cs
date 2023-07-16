// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFOutputSchema"/> struct.</summary>
public static unsafe partial class IMFOutputSchemaTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFOutputSchema"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFOutputSchema).GUID, Is.EqualTo(IID_IMFOutputSchema));
    }

    /// <summary>Validates that the <see cref = "IMFOutputSchema"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFOutputSchema>(), Is.EqualTo(sizeof(IMFOutputSchema)));
    }

    /// <summary>Validates that the <see cref = "IMFOutputSchema"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFOutputSchema).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFOutputSchema"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFOutputSchema), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFOutputSchema), Is.EqualTo(4));
        }
    }
}