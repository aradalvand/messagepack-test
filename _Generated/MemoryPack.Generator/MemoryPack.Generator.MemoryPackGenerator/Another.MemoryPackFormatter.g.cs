﻿
// <auto-generated/>
#nullable enable
#pragma warning disable CS0108 // hides inherited member
#pragma warning disable CS0162 // Unreachable code
#pragma warning disable CS0164 // This label has not been referenced
#pragma warning disable CS0219 // Variable assigned but never used
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8601 // Possible null reference assignment
#pragma warning disable CS8602
#pragma warning disable CS8604 // Possible null reference argument for parameter
#pragma warning disable CS8619
#pragma warning disable CS8620
#pragma warning disable CS8631 // The type cannot be used as type parameter in the generic type or method
#pragma warning disable CS8765 // Nullability of type of parameter
#pragma warning disable CS9074 // The 'scoped' modifier of parameter doesn't match overridden or implemented member
#pragma warning disable CA1050 // Declare types in namespaces.

using System;
using MemoryPack;


/// <remarks>
/// MemoryPack GenerateType: Object<br/>
/// <code>
/// <b>int</b> X<br/>
/// </code>
/// </remarks>
partial record Another : IMemoryPackable<Another>, global::MemoryPack.IFixedSizeMemoryPackable
{

    static partial void StaticConstructor();

    static Another()
    {
        global::MemoryPack.MemoryPackFormatterProvider.Register<Another>();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    static int global::MemoryPack.IFixedSizeMemoryPackable.Size => 1 + System.Runtime.CompilerServices.Unsafe.SizeOf<int>();

    [global::MemoryPack.Internal.Preserve]
    static void IMemoryPackFormatterRegister.RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<Another>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.MemoryPackableFormatter<Another>());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<Another[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<Another>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    static void IMemoryPackable<Another>.Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, scoped ref Another? value) 
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteUnmanagedWithObjectHeader(1, value.@X);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    static void IMemoryPackable<Another>.Deserialize(ref MemoryPackReader reader, scoped ref Another? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }



        int __X;

        
        if (count == 1)
        {
            if (value == null)
            {
                reader.ReadUnmanaged(out __X);


                goto NEW;
            }
            else
            {
                __X = value.@X;

                reader.ReadUnmanaged(out __X);

                goto SET;
            }

        }
        else if (count > 1)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(Another), 1, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {
               __X = default!;
            }
            else
            {
               __X = value.@X;
            }


            if (count == 0) goto SKIP_READ;
            reader.ReadUnmanaged(out __X); if (count == 1) goto SKIP_READ;

    SKIP_READ:
            if (value == null)
            {
                goto NEW;
            }
            else
            {
                goto SET;
            }

        }

    SET:
        goto NEW;

        goto READ_END;

    NEW:
        value = new Another(__X)
        {

        };

    READ_END:

    END:

        return;
    }
}
