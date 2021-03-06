# Patching

## Finalizer

A finalizer is a method that makes Harmony wrap the original and all other patches in a try/catch block. It can receive a thrown exception and even suppress it or return a different one.

It is a very good candidate for code that has to run regardless of what happens. Its counterpart is a Prefix with no side effects (void return type and no ref/out arguments). These are never skipped and thus serve as a way to run code guaranteed at the start of a method.

Finalizers are commonly used to:

- suppress exceptions
- remap exceptions
- make sure your code is always executed

### Suppressing any exceptions

```csharp
static Exception Finalizer()
{
	return null;
}
```

### Observing exceptions

```csharp
static void Finalizer(Exception __exception)
{
}
```

### Changing and rethrowing exceptions

```csharp
[Serializable]
public class MyException : Exception
{
	public MyException() { }
	public MyException(string message) : base(message) { }
	public MyException(string message, Exception innerException) : base(message, innerException) { }
	protected MyException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		throw new NotImplementedException();
	}
}

static Exception Finalizer(Exception __exception)
{
	return new MyException("Oops", __exception);
}
```

Beside their handling of exceptions they can receive the same arguments as Postfixes.
