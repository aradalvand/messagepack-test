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
/// <b>int</b> Y<br/>
/// <b>string</b> Foo<br/>
/// <b>Another</b> Hi<br/>
/// <b>System.Net.IPAddress</b> Ip<br/>
/// <b>NodaTime.Instant</b> Now<br/>
/// <b>SomeVo</b> SomeVo<br/>
/// <b>Fuck</b> Fuck<br/>
/// </code>
/// </remarks>
partial record TestRequest : IMemoryPackable<TestRequest>
{
    static readonly IMemoryPackFormatter<global::System.Net.IPAddress> __IpFormatter = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<global::IPAddressFormatter>(typeof(global::TestRequest).GetProperty("Ip", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)).GetFormatter();
    static readonly IMemoryPackFormatter<global::NodaTime.Instant> __NowFormatter = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<global::InstantFormatter>(typeof(global::TestRequest).GetProperty("Now", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)).GetFormatter();
    static readonly IMemoryPackFormatter<global::Fuck> __FuckFormatter = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<global::FuckFormatter>(typeof(global::TestRequest).GetProperty("Fuck", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)).GetFormatter();

    static partial void StaticConstructor();

    static TestRequest()
    {
        global::MemoryPack.MemoryPackFormatterProvider.Register<TestRequest>();
        StaticConstructor();
    }

    [global::MemoryPack.Internal.Preserve]
    static void IMemoryPackFormatterRegister.RegisterFormatter()
    {
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<TestRequest>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.MemoryPackableFormatter<TestRequest>());
        }
        if (!global::MemoryPack.MemoryPackFormatterProvider.IsRegistered<TestRequest[]>())
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ArrayFormatter<TestRequest>());
        }

    }

    [global::MemoryPack.Internal.Preserve]
    static void IMemoryPackable<TestRequest>.Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, scoped ref TestRequest? value) 
    {

        if (value == null)
        {
            writer.WriteNullObjectHeader();
            goto END;
        }

        writer.WriteUnmanagedWithObjectHeader(8, value.@X, value.@Y);
        writer.WriteString(value.@Foo);
        writer.WritePackable(value.@Hi);
        writer.WriteValueWithFormatter(__IpFormatter, value.@Ip);
        writer.WriteValueWithFormatter(__NowFormatter, value.@Now);
        writer.WriteUnmanaged(value.@SomeVo);
        writer.WriteValueWithFormatter(__FuckFormatter, value.@Fuck);

    END:

        return;
    }

    [global::MemoryPack.Internal.Preserve]
    static void IMemoryPackable<TestRequest>.Deserialize(ref MemoryPackReader reader, scoped ref TestRequest? value)
    {

        if (!reader.TryReadObjectHeader(out var count))
        {
            value = default!;
            goto END;
        }



        int __X;
        int __Y;
        string __Foo;
        global::Another __Hi;
        global::System.Net.IPAddress __Ip;
        global::NodaTime.Instant __Now;
        global::SomeVo __SomeVo;
        global::Fuck __Fuck;

        
        if (count == 8)
        {
            if (value == null)
            {
                reader.ReadUnmanaged(out __X, out __Y);
                __Foo = reader.ReadString();
                __Hi = reader.ReadPackable<global::Another>();
                __Ip = reader.ReadValueWithFormatter<IMemoryPackFormatter<global::System.Net.IPAddress>, global::System.Net.IPAddress>(__IpFormatter);
                __Now = reader.ReadValueWithFormatter<IMemoryPackFormatter<global::NodaTime.Instant>, global::NodaTime.Instant>(__NowFormatter);
                reader.ReadUnmanaged(out __SomeVo);
                __Fuck = reader.ReadValueWithFormatter<IMemoryPackFormatter<global::Fuck>, global::Fuck>(__FuckFormatter);


                goto NEW;
            }
            else
            {
                __X = value.@X;
                __Y = value.@Y;
                __Foo = value.@Foo;
                __Hi = value.@Hi;
                __Ip = value.@Ip;
                __Now = value.@Now;
                __SomeVo = value.@SomeVo;
                __Fuck = value.@Fuck;

                reader.ReadUnmanaged(out __X);
                reader.ReadUnmanaged(out __Y);
                __Foo = reader.ReadString();
                reader.ReadPackable(ref __Hi);
                reader.ReadValueWithFormatter(__IpFormatter, ref __Ip);
                reader.ReadValueWithFormatter(__NowFormatter, ref __Now);
                reader.ReadUnmanaged(out __SomeVo);
                reader.ReadValueWithFormatter(__FuckFormatter, ref __Fuck);

                goto SET;
            }

        }
        else if (count > 8)
        {
            MemoryPackSerializationException.ThrowInvalidPropertyCount(typeof(TestRequest), 8, count);
            goto READ_END;
        }
        else
        {
            if (value == null)
            {
               __X = default!;
               __Y = default!;
               __Foo = default!;
               __Hi = default!;
               __Ip = default!;
               __Now = default!;
               __SomeVo = default!;
               __Fuck = default!;
            }
            else
            {
               __X = value.@X;
               __Y = value.@Y;
               __Foo = value.@Foo;
               __Hi = value.@Hi;
               __Ip = value.@Ip;
               __Now = value.@Now;
               __SomeVo = value.@SomeVo;
               __Fuck = value.@Fuck;
            }


            if (count == 0) goto SKIP_READ;
            reader.ReadUnmanaged(out __X); if (count == 1) goto SKIP_READ;
            reader.ReadUnmanaged(out __Y); if (count == 2) goto SKIP_READ;
            __Foo = reader.ReadString(); if (count == 3) goto SKIP_READ;
            reader.ReadPackable(ref __Hi); if (count == 4) goto SKIP_READ;
            reader.ReadValueWithFormatter(__IpFormatter, ref __Ip); if (count == 5) goto SKIP_READ;
            reader.ReadValueWithFormatter(__NowFormatter, ref __Now); if (count == 6) goto SKIP_READ;
            reader.ReadUnmanaged(out __SomeVo); if (count == 7) goto SKIP_READ;
            reader.ReadValueWithFormatter(__FuckFormatter, ref __Fuck); if (count == 8) goto SKIP_READ;

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
        value = new TestRequest(__X, __Y, __Foo, __Hi, __Ip, __Now, __SomeVo, __Fuck)
        {

        };

    READ_END:

    END:

        return;
    }
}
