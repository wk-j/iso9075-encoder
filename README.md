## ISO9075 Encoder

```csharp
[Fact]
public void Encode()
{
    var text = "Hello & World 123";
    var expect = "Hello_x0020__x0026__x0020_World_x0020_123";
    Assert.Equal(expect, Encoder.Encode(text));
}

[Fact]
public void Decode() {
    var encoded = "Hello_x0020__x0026__x0020_World_x0020_123";
    var text = "Hello & World 123";
    Assert.Equal(text, Encoder.Decode(encoded));
}
```