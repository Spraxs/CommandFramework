# Command Framework

### Classes:

 * [ReflectionUtil.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Utils/ReflectionUtil.cs)
 is used to handle all reflection in this project.
 * [Command.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Command.cs)
 handles all methods in a command class to be invoked with the right parameters.
 * [CommandHandler.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Handlers/CommandHandler.cs)
 handles initializing the command classes to a [new Command](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Command.cs) object. It alse handles the player input so the [Command class](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Command.cs) can invoke the right method.
 * [SubInfo.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Objects/SubInfo.cs) holds info about all the methods that can be executes as command.
 * [CommandAttributeMissingException.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Exceptions/CommandAttributeMissingException.cs) is an custom exception that indicates that certain attributes are missing.
 
 #### Classes - Attributes:
 * [CommandAttribute.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Attributes/CommandAttribute.cs) is the attribute on top of a command class. The string parameter is the name of the command.
 * [DescriptionAttribute.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Attributes/CommandAttribute.cs) is an attribute on each command method. This attribute can provide information about what the command does.
 * [MinArgsAttribute.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Attributes/MinArgsAttribute.cs) is an attribute on each command method. This attribute provides what amount the minimal parameters are for this method.
 * [SubAttribute.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Attributes/SubAttribute.cs) is an attribute that makes a normal method a command method.
 * [UsageAttribute.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Attributes/UsageAttribute.cs) is an attribute that can provide usage information about an command method.

#### A Command Class Example:
![Command Class Example](https://i.gyazo.com/5a5a742e88466124786318871d9f4029.png)

![Command: "test debug"](https://i.gyazo.com/95ee7c0a6efe0e090f28f273e91f30b7.png)
