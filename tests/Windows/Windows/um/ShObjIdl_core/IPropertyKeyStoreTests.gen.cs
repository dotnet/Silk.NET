// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPropertyKeyStore"/> struct.</summary>
public static unsafe partial class IPropertyKeyStoreTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPropertyKeyStore"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPropertyKeyStore).GUID, Is.EqualTo(IID_IPropertyKeyStore));
    }

    /// <summary>Validates that the <see cref = "IPropertyKeyStore"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPropertyKeyStore>(), Is.EqualTo(sizeof(IPropertyKeyStore)));
    }

    /// <summary>Validates that the <see cref = "IPropertyKeyStore"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPropertyKeyStore).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPropertyKeyStore"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPropertyKeyStore), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPropertyKeyStore), Is.EqualTo(4));
        }
    }
}