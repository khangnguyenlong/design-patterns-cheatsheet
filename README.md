# Design Patterns Cheatsheet

## Cheatsheet

| No. | Design Pattern | Category | Problem | Idea | Description | Link |
|---:|---|---|---|---|---|---|
| 1 | **Prototype** | Creational | You need an independent copy of a complex object with only a few changes. | Clone an existing configured object instead of rebuilding it. | Creates new objects by copying an existing object. | [View](https://github.com/khangnguyenlong/design-patterns-cheatsheet/tree/main#prototype) |
| 2 | **Factory Method** | Creational |  |  |  | |
| 3 | **Abstract Factory** | Creational |  |  |  | |
| 4 | **Builder** | Creational |  |  |  | |
| 5 | **Singleton** | Creational |  |  |  | |
| 6 | **Adapter** | Structural |  |  |  | |
| 7 | **Bridge** | Structural |  |  |  | |
| 8 | **Composite** | Structural |  |  |  | |
| 9 | **Decorator** | Structural |  |  |  | |
| 10 | **Facade** | Structural |  |  |  | |
| 11 | **Flyweight** | Structural |  |  |  | |
| 12 | **Proxy** | Structural |  |  |  | |
| 13 | **Chain of Responsibility** | Behavioral |  |  |  | |
| 14 | **Command** | Behavioral |  |  |  | |
| 15 | **Interpreter** | Behavioral |  |  |  | |
| 16 | **Iterator** | Behavioral |  |  |  | |
| 17 | **Mediator** | Behavioral |  |  |  | |
| 18 | **Memento** | Behavioral |  |  |  | |
| 19 | **Observer** | Behavioral |  |  |  | |
| 20 | **State** | Behavioral |  |  |  | |
| 21 | **Strategy** | Behavioral |  |  |  | |
| 22 | **Template Method** | Behavioral |  |  |  | |
| 23 | **Visitor** | Behavioral |  |  |  | |

# Creational

## Prototype

### Problem

You need an independent copy of a complex object,  
with only a few changes,  
without affecting the original.

### Solution Idea

- Use an existing object as a template.
- Clone and customize it.

### Description

Prototype creates a new object by copying an existing configured object.

### Implementation

#### Approach 1: Explicit Deep Copy

```csharp
internal interface IPrototype<T>
{
    T DeepClone();
}

internal class HtmlDocument : IPrototype<HtmlDocument>
{
    public HtmlHeader Header { get; set; }
    public HtmlBody Body { get; set; }
    public HtmlFooter Footer { get; set; }

    public HtmlDocument DeepClone()
    {
        // Shallow copy
        var clone = (HtmlDocument)MemberwiseClone();

        // Deep copy
        clone.Header = Header?.DeepClone();
        clone.Body = Body?.DeepClone();
        clone.Footer = Footer?.DeepClone();

        return clone;
    }
}
```

#### Approach 2: Copy Through Serialization

```csharp
using System.Text.Json;

internal static class ObjectExtensions
{
    public static T DeepClone<T>(T source)
    {
        if (source is null)
        {
            return default;
        }

        var json = JsonSerializer.Serialize(source);
        return JsonSerializer.Deserialize<T>(json);
    }
}
```

```csharp
var clone = originalDocument.DeepClone();
```

---

## Factory Method

> TODO

## Abstract Factory

> TODO

## Builder

> TODO

## Singleton

> TODO

# Structural

## Adapter

> TODO

## Bridge

> TODO

## Composite

> TODO

## Decorator

> TODO

## Facade

> TODO

## Flyweight

> TODO

## Proxy

> TODO

# Behavior

## Chain of Responsibility

> TODO

## Command

> TODO

## Interpreter

> TODO

## Iterator

> TODO

## Mediator

> TODO

## Memento

> TODO

## Observer

> TODO

## State

> TODO

## Strategy

> TODO

## Template Method

> TODO

## Visitor

> TODO
