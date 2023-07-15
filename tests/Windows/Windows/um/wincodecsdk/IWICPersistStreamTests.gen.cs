// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICPersistStream"/> struct.</summary>
public static unsafe partial class IWICPersistStreamTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICPersistStream"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICPersistStream).GUID, Is.EqualTo(IID_IWICPersistStream));
    }

    /// <summary>Validates that the <see cref = "IWICPersistStream"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICPersistStream>(), Is.EqualTo(sizeof(IWICPersistStream)));
    }

    /// <summary>Validates that the <see cref = "IWICPersistStream"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICPersistStream).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICPersistStream"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICPersistStream), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICPersistStream), Is.EqualTo(4));
        }
    }
}