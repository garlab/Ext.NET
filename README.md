# Ext.NET

Ext.NET is a set of features that extends quick inlining features to your C# apps.

## Examples

### Inline Each

    List<User> users = GetUsers();
    users.Each(u => u.Status = Status.Online);

### Shuffle

    List<Card> shuffledCards = GetAllCards().Shuffle();

### Grep

    List<User> users = GetUsers().Grep("John");

### Ruby-style loop

    10.Times(i => WriteLine("line: " + i));

Display :

    line: 0
    line: 1
    ...
    line: 9
