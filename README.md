# LightTraveller.Guards
Using this throw helper (guard) library, you can skip typing boilerplate code to guard against unacceptable values of arguments passed to a method. 
This helps to produce a cleaner and more readable code
___
## Example: Checking for ```null```
The following method
```c#
using LightTraveller.Guards;

public class TicketService
{
    private readonly TicketRepository _repository;
    private readonly UserService _userService;
    private readonly TicketValidator _validator;
    

    public TicketService(TicketRepository repository, UserService userService, TicketValidator validator)
    {
        if (repository is null)
            throw new ArgumentNullException(nameof(repository));

        if (userService is null)
            throw new ArgumentNullException(nameof(userService));

        if (validator is null)
            throw new ArgumentNullException(nameof(validator));
        
        _repository = repository;
        _userService = userService;
        _validator = validator; 
    }
}
```
can be rewritten as

```c#
using LightTraveller.Guards;

public class TicketService
{
    private readonly TicketRepository _repository;
    private readonly UserService _userService;
    private readonly TicketValidator _validator;
    

    public TicketService(TicketRepository repository, UserService userService, TicketValidator validator)
    {
        _repository = Guard.Null(repository);        
        _userService = Guard.Null(userService);

        // An overload accepting a custom exception message
        _validator = Guard.Null(validator, "Make sure the passed argument is not null.");
    }
}
```
### Notice 
> As you can see in the example above, when using **Guards** library, 
you do not need to pass the name of the arguments, e.g., ```nameof(repository)``` or ```"repository"```, 
to the guard methods to be used for throwing exceptions. 
This is taken care of by using 
[```[CallerArgumentExpression]```](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute?view=net-6.0) 
attribute in the the methods of the ```Guard``` class.
___

## Installation
You can add the Nuget package of the **LightTraveller.Guards** by running the following command in the .NET CLI

```dotnet add package LightTraveller.Guards --version <VERSION NUMBER>```

For more information please go to the [nuget.org page of this library](https://www.nuget.org/packages/LightTraveller.Guards).

## How to Use
1. Add this to the ```using``` statements in your code: ```using LightTraveller.Guards;```
2. Simply call ```static``` methods of the ```Guard``` class by passing the argument to be checked to that method. Each method returns the instance passed to it if it passes the check; otherwise, throws an exception.

For a code sample, please look at the above example.

## Available Methods
1. ```Guard.Null``` throws if the generic input is null.
2. ```Guard.Empty``` throws if the ```string``` input is null, an empty string or consists only of white-space characters.
3. ```Gurad.NullOrEmpty``` throws if the ```IEnumerable<T>``` input is null, or an empty collection.
4. ```Guard.Zero``` throws if the input is zero.
5. ```Guard.Negative``` throws if the input is negative.
6. ```Guard.ZeroOrNegative``` throws if the input is zero or negative.
7. ```Guard.Positive``` throws if the input is positive.
8. ```Guard.ZeroOrPositive``` throws if the input is zero or positive.
9. ```Guard.OutOfRange``` throws if the generic ```IComparable<T>``` input is out of the specified range.
10. ```Guard.InvalidEnumValue``` throws if the input cannot be cast to a member of the specified enumeration.
11. ```Guard.ZeroPointer``` throws if the input is IntPtr.Zero.

