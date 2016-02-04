# Class2Dictionary
Class2Dictionary is a simple utitlity extension method to convert a class into a dictionary.

# Usage

C2D is an extension method and will work on any object that inherits the IC2D interface.

```
public class SampleClass : IC2D
{
   public int Id { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string Company { get; set; }
}
```

It can be used like this:

```
var sampleClass = new SampleClass();
var dictionary = sampleClass.ConvertC2D();
```

It returns a dictionary containing the property names as the keys, and the property values as the values.

I built it for use in sending POST requests but thought someone else might find it useful.

# Wish List

- Serialize to JSON
- Serialize to name/value string (FirstName=Tom,LastName=Swift)
- Make the keys generic so the dictionary can hold any object as a value